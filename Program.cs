using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace helloworld
    {
    public class Startup
        {
        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
            {
            applicationBuilder.Run(async context =>
            {
                await context.Response.WriteAsync("Sample Docker Content commit");

            });
            }
        }

    class Program
        {
       
        static void Main(string[] args)
            {
            WebHost.CreateDefaultBuilder()
            .UseStartup<Startup>()
            .UseKestrel()
            .UseUrls("http://0.0.0.0:5050")
            .Build()
            .Run();
            }
        }

        
    }