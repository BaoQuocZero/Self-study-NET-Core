public class MyStartUp
{
    // Đăng ký các dịch vụ ứng dụng (DI)
    public void ConfigureServices(IServiceCollection services)
    {
        // services.AddSingleton
    }

    // Xây dựng pipeline (chuỗi Middleware)
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Terminate Middleware cho route "/abc"
        app.Map("/abc", app1 =>
        {
            app1.Run(async (context) =>
            {
                await context.Response.WriteAsync("Noi dung tra ve tu ABC");
            });
        });

        // Terminate Middleware cho các route khác
        app.Run(async (HttpContext context) =>
        {
            await context.Response.WriteAsync("Xin chao day la MyStartUp");
        });
    }
}