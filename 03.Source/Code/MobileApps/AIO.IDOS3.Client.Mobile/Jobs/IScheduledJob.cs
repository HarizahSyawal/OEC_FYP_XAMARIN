using System;
using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.Jobs
{

    public interface IScheduledJob
	{

		#region Properties

		TimeSpan Interval { get; }

		#endregion

		#region Methods

		Task<bool> Run();
		Task<bool> Abort();

		#endregion

	}

}