using AIO.IDOS3.Client.Mobile.Android.DependencyServices;
using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Java.IO;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class BluetoothService : IBluetoothService
    {

        #region Fields

        private static Context context;

        private CancellationTokenSource cancellationToken = null;
        private BluetoothSocket bluetoothSocket = null;

        #endregion

        #region Properties

        public int RetryAttempts { get; set; } = 3;

        public bool IsOpened
        {
            get
            {
                if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
                    return bluetoothSocket.IsConnected;

                return false;
            }
        }

        #endregion

        #region Methods

        public static void Init(Context context)
        {
            BluetoothService.context = context;
            DependencyService.Register<IBluetoothService, BluetoothService>();
        }



        private async Task loop(string name, int sleepTime, bool readAsCharArray)
        {
            BluetoothDevice bluetoothDevice = null;
            BluetoothAdapter bluetoothAdapter = null;
            BluetoothSocket bluetoothSocket = null;

            cancellationToken = new CancellationTokenSource();

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    Thread.Sleep(sleepTime);

                    bluetoothAdapter = await GetBluetoothAdapter();

                    foreach (var device in bluetoothAdapter.BondedDevices)
                    {
                        System.Diagnostics.Debug.WriteLine("Paired devices found: " + device.Name.ToUpper());
                        if (device.Name.ToUpper().IndexOf(name.ToUpper()) >= 0)
                        {

                            System.Diagnostics.Debug.WriteLine("Found " + device.Name + ". Try to connect with it!");
                            bluetoothDevice = device;
                            break;
                        }
                    }

                    if (bluetoothDevice == null)
                        System.Diagnostics.Debug.WriteLine("Named device not found.");
                    else
                    {
                        var uuid = UUID.FromString("00001101-0000-1000-8000-00805f9b34fb");

                        if ((int)global::Android.OS.Build.VERSION.SdkInt >= 10) // Gingerbread 2.3.3 2.3.4
                            bluetoothSocket = bluetoothDevice.CreateInsecureRfcommSocketToServiceRecord(uuid);
                        else
                            bluetoothSocket = bluetoothDevice.CreateRfcommSocketToServiceRecord(uuid);

                        if (bluetoothSocket != null)
                        {


                            //Task.Run ((Func<Task>)loop); /*) => {
                            await bluetoothSocket.ConnectAsync();


                            if (bluetoothSocket.IsConnected)
                            {
                                System.Diagnostics.Debug.WriteLine("Connected!");
                                var mReader = new InputStreamReader(bluetoothSocket.InputStream);
                                var buffer = new BufferedReader(mReader);
                                //buffer.re
                                while (cancellationToken.IsCancellationRequested == false)
                                {
                                    if (buffer.Ready())
                                    {
                                        //										string barcode =  buffer
                                        //string barcode = buffer.

                                        //string barcode = await buffer.ReadLineAsync();
                                        var chr = new char[100];
                                        //await buffer.ReadAsync(chr);
                                        string barcode = "";
                                        if (readAsCharArray)
                                        {

                                            await buffer.ReadAsync(chr);
                                            foreach (char c in chr)
                                            {
                                                if (c == '\0')
                                                    break;
                                                barcode += c;
                                            }

                                        }
                                        else
                                            barcode = await buffer.ReadLineAsync();

                                        if (barcode.Length > 0)
                                        {
                                            System.Diagnostics.Debug.WriteLine("Letto: " + barcode);
                                            Xamarin.Forms.MessagingCenter.Send<App, string>((App)Xamarin.Forms.Application.Current, "Barcode", barcode);
                                        }
                                        else
                                            System.Diagnostics.Debug.WriteLine("No data");

                                    }
                                    else
                                        System.Diagnostics.Debug.WriteLine("No data to read");

                                    // A little stop to the uneverending thread...
                                    System.Threading.Thread.Sleep(sleepTime);
                                    if (!bluetoothSocket.IsConnected)
                                    {
                                        System.Diagnostics.Debug.WriteLine("BthSocket.IsConnected = false, Throw exception");
                                        throw new Exception();
                                    }
                                }

                                System.Diagnostics.Debug.WriteLine("Exit the inner loop");

                            }
                        }
                        else
                            System.Diagnostics.Debug.WriteLine("BthSocket = null");

                    }


                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("EXCEPTION: " + ex.Message);
                }

                finally
                {
                    if (bluetoothSocket != null)
                        bluetoothSocket.Close();

                    bluetoothDevice = null;
                    bluetoothAdapter = null;
                }
            }

            System.Diagnostics.Debug.WriteLine("Exit the external loop");
        }

        private async Task<BluetoothAdapter> GetBluetoothAdapter()
        {
            var bluetoothPermissions = ContextCompat.CheckSelfPermission(context, Manifest.Permission.Bluetooth);
            if (bluetoothPermissions != Permission.Granted)
            {
                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    ActivityCompat.RequestPermissions((Activity)context, new string[] { Manifest.Permission.Bluetooth }, 1);
                    bluetoothPermissions = ContextCompat.CheckSelfPermission(context, Manifest.Permission.Bluetooth);

                    await Task.CompletedTask;
                });
            }

            if (bluetoothPermissions == Permission.Granted)
            {
                var bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
                if (bluetoothAdapter == null)
                    throw new Exception("Bluetooth Adapter not found");

                if (!bluetoothAdapter.IsEnabled)
                    bluetoothAdapter.Enable();

                return bluetoothAdapter;
            }

            throw new NullReferenceException("Bluetooth Device can not be accessed. Please check your Bluetooth Device Permission Settings.");
        }

        #endregion

        #region Implements BluetoothUtility

        public async Task NavigateToSystemSettings()
        {
            Intent intentOpenBluetoothSettings = new Intent();
            intentOpenBluetoothSettings.SetAction(global::Android.Provider.Settings.ActionBluetoothSettings);

            context.StartActivity(intentOpenBluetoothSettings);

            await Task.CompletedTask;
        }



        public async Task Start(string deviceName, int sleepTime = 200, bool readAsCharArray = false)
        {
            await Task.Run(async () => loop(deviceName, sleepTime, readAsCharArray));
        }

        public async Task Cancel()
        {
            if (cancellationToken != null)
                cancellationToken.Cancel();

            await Task.CompletedTask;
        }

        public async Task<List<string>> GetPairedDevices()
        {
            var bluetoothAdapter = await GetBluetoothAdapter();
            var pairedDevices = new List<string>();

            foreach (var device in bluetoothAdapter.BondedDevices)
                pairedDevices.Add(device.Name);

            await Task.CompletedTask;

            return pairedDevices;
        }


        public async Task<bool> Open(string deviceName)
        {
            var result = false;

            var bluetoothAdapter = await GetBluetoothAdapter();

            var bluetoothDevice = bluetoothAdapter.BondedDevices.Where(p => p.Name.Equals(deviceName, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
            if (bluetoothDevice != null)
            {
                var uuid = UUID.FromString("00001101-0000-1000-8000-00805f9b34fb");
                if ((int)global::Android.OS.Build.VERSION.SdkInt >= 10) // Gingerbread 2.3.3 2.3.4
                    bluetoothSocket = bluetoothDevice.CreateInsecureRfcommSocketToServiceRecord(uuid);
                else
                    bluetoothSocket = bluetoothDevice.CreateRfcommSocketToServiceRecord(uuid);

                if (bluetoothSocket == null)
                    throw new Exception("Bluetooth Device Socket can not be created");

                await bluetoothSocket.ConnectAsync();

                result = true;
            }
            else
                throw new Exception("Paired Bluetooth Device not found");

            return result;
        }

        public async Task Close()
        {
            if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
            {
                bluetoothSocket.Close();
                bluetoothSocket.Dispose();

                bluetoothSocket = null;
            }

            await Task.CompletedTask;
        }


        public async Task DiscardOutputBuffer()
        {
            if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
                bluetoothSocket.OutputStream.Flush();

            await Task.CompletedTask;
        }

        public async Task DiscardInputBuffer()
        {
            if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
                bluetoothSocket.InputStream.Flush();

            await Task.CompletedTask;
        }


        public async Task<int> Read(byte[] buffer, int offset, int count)
        {
            var attempts = RetryAttempts;

            while (attempts > 0)
            {
                if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
                {
                    var inputStreamInvoker = ((InputStreamInvoker)bluetoothSocket.InputStream);
                    if (!inputStreamInvoker.CanRead)
                        throw new Exception("Can not read from connected device");

                    if (inputStreamInvoker.BaseInputStream.Available() > 0)
                        return await bluetoothSocket.InputStream.ReadAsync(buffer, offset, count);

                    attempts--;
                    if (attempts > 0)
                        Thread.Sleep(1000);
                }
            }

            return 0;
        }

        public async Task Write(byte[] buffer, int offset, int count)
        {
            if ((bluetoothSocket != null) && bluetoothSocket.IsConnected)
            {
                var outputStreamInvoker = ((OutputStreamInvoker)bluetoothSocket.OutputStream);
                if (!outputStreamInvoker.CanWrite)
                    throw new Exception("Can not write to connected device");

                await bluetoothSocket.OutputStream.WriteAsync(buffer, offset, count);
            }
        }

        #endregion

    }

}

