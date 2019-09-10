namespace Abp.Starter.Web.Startup
{
    using Abp.AspNetCore;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // ASP.NET Core MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // ABP and Dependency Injection
            return services.AddAbp<AbpStarter_Cn_WebModule>();
        }

        /// <summary>
        /// Configures the application's request process pipeline
        /// </summary>
        /// <param name="app">The pipeline builder</param>
        /// <param name="env">A description of the current server environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // When Kestrel receives an HTTP request, it will be sent to the first
            // middleware declared in this method, which will then usually call the next
            // one (although it does not *have* to), which will call the next one, etc...
            // As a result, the order in which you add middleware is important !
            // For more information about Kestrel middlware, see :
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index?view=aspnetcore-2.2

            // This initializes ABP for the current request
            app.UseAbp();

            if (env.IsDevelopment())
            {
                // If an exception is thrown during the next steps, show the developper error page
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // If an exception is thrown during the next steps, re-runs the request as if the requested URL was "/Error"
                app.UseExceptionHandler("/Error");

                // HTST forces the client browser to use HTTPS
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // If the request is on http://, redirect it to https://
            app.UseHttpsRedirection();

            // If the requested URL matches one of the physical files present in wwwroot, directly return this file's contents.
            app.UseStaticFiles();

            // Processes the authentication data contained in the request, to be used by the next steps
            app.UseAuthentication();

            // Check if the request matches one of the existing MVC pages or controllers
            app.UseMvc();

            // If the request reaches that point, Kestrel returns a 404 error response
        }
    }
}
