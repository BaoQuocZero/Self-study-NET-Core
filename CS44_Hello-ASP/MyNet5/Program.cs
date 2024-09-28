using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyNet5
{
    public class Program
    {
        /*
        Host (IHost) object:
            Dependency Injection (ID): IServiceProvider (ServiceCollection)
            Logging (ILogging)
            Configuration
            IHostedService => StartAsync: Run HTTP Server (Kestrel Http)
        1) Tao IHostBuilder
        2) Cau hinh, dang ky cac dich vu (goi ConfigureWebHostDefaults)
        3) IHostBuilder. Build() => Host (IHost)
        3) Host.Run();
        */

        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("Start app");
        //     IHostBuilder builder = Host.CreateDefaultBuilder();
        //     //Cấu hình mặt định cho Host tạo ra
        //     builder.ConfigureWebHostDefaults((IWebHostBuilder webBuilder) =>
        //     {
        //         //Tùy biến Host
        //         //webBuilder
        //         // webBuilder.UseWebRoot("public"); //Đổi thư mục wwwroot thành thư mục khác nếu cần
        //         webBuilder.UseStartup<MyStartUp>();
        //     });

        //     IHost host = builder.Build();
        //     host.Run();
        // }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // webBuilder.UseWebRoot("public"); //Đổi thư mục wwwroot thành thư mục khác nếu cần
                    webBuilder.UseStartup<MyStartUp>(); //Điều hướng vào Startup
                });
    }
}