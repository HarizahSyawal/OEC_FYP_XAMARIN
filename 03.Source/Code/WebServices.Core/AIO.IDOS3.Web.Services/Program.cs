using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AIO.IDOS3.Web.Services
{

    public class Program
    {

        #region Methods

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        #endregion

    }

}
