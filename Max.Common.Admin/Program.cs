using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Max.Utilities.LogService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Max.Common.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("NLog/nlog.config").GetCurrentClassLogger();
            try
            {
             //   设置NLog
                LogHelper.Set(logger);
                logger.Debug("初始化 Main !");

                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception exception)
            {
                //NLog: catch setup errors
                 logger.Error(exception, "由于异常而停止程序!");
            }
            finally
            {
                //Ensure to flush and stop internal timers/threads before application-exit(Avoid segmentation fault on Linux)
                   NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                 Host.CreateDefaultBuilder(args)
                     .ConfigureWebHostDefaults(webBuilder =>
                     {
                         webBuilder.UseStartup<Startup>()
                         .ConfigureLogging(logging =>
                         {
                             logging.ClearProviders();
                             logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                         })
                         .UseNLog();  // NLog: Setup NLog for Dependency injection;;
                     });
    }
}
