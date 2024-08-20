using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

Host.CreateDefaultBuilder(args)
    .ConfigureWebHost(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                await context.Response.WriteAsync("Hello World!");
            });
        });
    })
    .Build()
    .Run();
