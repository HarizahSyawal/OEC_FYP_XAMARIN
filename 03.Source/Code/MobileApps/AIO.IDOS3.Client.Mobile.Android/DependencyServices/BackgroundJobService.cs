using Android.App;
using Android.Content;
using Android.OS;
using Xamarin.Forms;
using static AIO.IDOS3.Client.Mobile.DependencyServices.BackgroundJobService;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class BackgroundJobManager
    {

        #region Methods

        public static void Init(ContextWrapper context)
        {
            MessagingCenter.Subscribe<StartLongRunningJob>(context, nameof(StartLongRunningJob), message =>
            {
                var intent = new Intent(context, typeof(BackgroundJobService));
                context.StartService(intent);
            });

            MessagingCenter.Subscribe<StopLongRunningJob>(context, nameof(StopLongRunningJob), message =>
            {
                var intent = new Intent(context, typeof(BackgroundJobService));
                context.StopService(intent);
            });
        }

        #endregion

    }

    [Service]
    public class BackgroundJobService : Service
    {

        #region Fields

        private static bool isRunning = false;

        #endregion

        #region Methods

        public override IBinder OnBind(Intent intent) { return null; }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (!isRunning)
            {
                Current.Start();
                isRunning = true;
            }

            return StartCommandResult.Sticky;
        }

        public override void OnDestroy()
        {
            isRunning = false;
            Current.Stop();

            base.OnDestroy();
        }

        #endregion

    }

}