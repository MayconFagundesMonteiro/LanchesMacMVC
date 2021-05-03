using LanchesMacMVC.Extensao;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LanchesMacMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //criamos o método de extensão CreateAdminRole
            CreateHostBuilder(args).Build().CreatedAdminRole().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
