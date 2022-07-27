using AIO.IDOS3.Data.Entity;
using AIO.IDOS3.Web.Services.SignalRHubs;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Linq;

namespace AIO.IDOS3.Web.Services
{

    public class Startup
    {

        #region Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Methods

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            MainDbContext.ConfigureDbContext = (object context, DbContextOptionsBuilder builder) =>
            {
                builder.UseSqlServer(Configuration.GetConnectionString("DefaultDB"));
            };

            services.AddDbContext<MainDbContext>();
            services.AddScoped<MainDbContext>();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });

            services.AddOData();

            services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = int.MaxValue;
                options.MemoryBufferThreshold = int.MaxValue;
            });

            services.AddSignalR()
                .AddHubOptions<ChatHub>((options) =>
                {
                    options.EnableDetailedErrors = true;
                })
                .AddJsonProtocol(options => { options.PayloadSerializerOptions.PropertyNamingPolicy = null; });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    // Initilize database/service context here
            //    //var context = serviceScope.ServiceProvider.GetService<MainDataContext>();
            //}


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
                RequestPath = new PathString("/Resources")
            });

            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapODataRoute("OData", "DataServices", MainDbContext.EdmModel);

                endpoints.MapHub<ChatHub>("/" + nameof(ChatHub));

                endpoints.EnableDependencyInjection();
                endpoints.
                    Count().
                    Filter().
                    OrderBy().
                    Expand().
                    Select().
                    MaxTop(null);

                endpoints.SetTimeZoneInfo(TimeZoneInfo.Utc);
            });
        }

        #endregion

    }

}
