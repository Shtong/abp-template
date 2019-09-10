namespace Abp.Starter.Web.Startup
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Main entry point of the web server
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This method is called on application start, and runs the Kestrel server
        /// </summary>
        /// <param name="args">Command line arguments passed to the application</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates and configures the Kestrel host
        /// </summary>
        /// <param name="args">Command line arguments passed to the application</param>
        /// <returns>A configured Kestrel setup</returns>
        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
