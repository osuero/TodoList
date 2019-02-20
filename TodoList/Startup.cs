using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Task.Data.Source;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TodoList
{
    public class Startup
    {

        /// <summary>
        /// this is how we inject the configuration file
        /// </summary>
        public IConfiguration Configuration { get; set; }
       
        /// <summary>
        /// This constructor initialize the config file
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //after adding this service is required to install the mvc package
            services.AddMvc();
            //adding entityframework is required 
            services
                .AddDbContext<DataTaskContext>//add datacontext service
                (options => options.
                    UseSqlServer(Configuration.////espesify connection string
                    GetConnectionString("TaskConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //adding reference to mvc
            app.UseMvc();
            //this make possible to use mvc on the pacakage


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
