using AIO.IDOS3.Client.Mobile.Jobs;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.DependencyServices
{

    public partial class BackgroundJobService
    {

        #region Classes

        public class StartLongRunningJob
        {

        }

        public class StopLongRunningJob
        {

        }

        #endregion

        #region Static Members

        private static BackgroundJobService current = null;
        public static BackgroundJobService Current
        {
            get
            {
                if (current == null)
                    current = new BackgroundJobService();

                return current;
            }
        }


        internal static readonly CompositeDisposable EventSubscriptions = new CompositeDisposable();

        #endregion

        #region Fields

        private static Dictionary<string, IScheduledJob> scheduledJobs = new Dictionary<string, IScheduledJob>();

        #endregion

        #region Constructors

        static BackgroundJobService()
        {

        }


        private BackgroundJobService()
        {

        }

        #endregion

        #region Methods

        public static void AddScheduleJob(string name, IScheduledJob job)
        {
            if (!string.IsNullOrEmpty(name) && !scheduledJobs.ContainsKey(name))
                scheduledJobs.Add(name, job);
        }

        public static void RemoveScheduleJob(string name)
        {
            if (!string.IsNullOrEmpty(name) && scheduledJobs.ContainsKey(name))
                scheduledJobs.Remove(name);
        }

        public static void StartService()
        {
            var message = new StartLongRunningJob();
            MessagingCenter.Send(message, nameof(StartLongRunningJob));
        }

        public static void StopService()
        {
            var message = new StopLongRunningJob();
            MessagingCenter.Send(message, nameof(StopLongRunningJob));
        }


        public void Start()
        {
            foreach (var job in scheduledJobs)
            {
                var observable = SyncRepeatObservable(job.Value);
                EventSubscriptions.Add(observable);
            }
        }

        public void Stop()
        {
            EventSubscriptions.Clear();
        }

        public void Clear()
        {
            EventSubscriptions.Clear();
            scheduledJobs.Clear();
        }



        private static IDisposable SyncRepeatObservable(IScheduledJob job)
        {
            return Observable
                .FromAsync(job.Run)
                .Delay(job.Interval)
                .Repeat()
                .TakeWhile(e => e)
                .Subscribe();
        }

        #endregion

    }

}
