using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AIO.IDOS3.Client.Test
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

        //public static void Main(string[] args)
        //{
        //    var context = new MainServiceDataContext(new Uri("http://localhost:6305/DataServices"));

        //    var roles = context.GetEntity<vRole>().Execute();
        //    var text = "";
        //    foreach (var item in roles)
        //        text += string.Format("ID: {0}, Description: {1}\n", item.ID, item.Description);

        //    Console.WriteLine(text);
        //}

        #endregion

    }

}
