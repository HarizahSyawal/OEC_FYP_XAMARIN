using System.Collections.Generic;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public interface IBluetoothService
	{

		#region Properties

		int RetryAttempts { get; set; }
		bool IsOpened { get; }

		#endregion

		#region Methods

		Task NavigateToSystemSettings();

		Task Start(string deviceName, int sleepTime, bool readAsCharArray);
		Task Cancel();
		Task<List<string>> GetPairedDevices();
				
		Task<bool> Open(string deviceName);
		Task Close();

		Task DiscardOutputBuffer();
		Task DiscardInputBuffer();

		Task<int> Read(byte[] buffer, int offset, int count);
		Task Write(byte[] buffer, int offset, int count);
		
		#endregion

	}

}
