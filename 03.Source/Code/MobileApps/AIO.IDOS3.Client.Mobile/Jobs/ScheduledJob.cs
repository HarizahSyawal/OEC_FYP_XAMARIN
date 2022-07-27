using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Jobs
{

    public class ScheduledJob : IScheduledJob
	{

        #region Fields

        private Func<Task<bool>> runAsync { get; }
        private Func<Task<bool>> abortAsync { get; }

        #endregion

        #region Constructors

        internal ScheduledJob(int seconds, Func<Task<bool>> runAsync, Func<Task<bool>> abortAsync)
        {
			Interval = TimeSpan.FromSeconds(seconds);
            this.runAsync = runAsync;
            this.abortAsync = abortAsync;
        }

        #endregion

        #region Methods

        #endregion

        #region Implements IScheduleJob

        public TimeSpan Interval { get; }



        public async Task<bool> Run()
        {
            return await runAsync();
        }

        public async Task<bool> Abort()
        {
            return await abortAsync();
        }

        #endregion

    }

}
