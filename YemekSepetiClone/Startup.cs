using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.Business.Abstract;
using YemekSepetiClone.Business.Concrete;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using YemekSepetiClone.DataAccess.EntityFrameworkCore.Abstract.Interfaces;

namespace YemekSepetiClone
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<YemekSepetiContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContextFactory<YemekSepetiContext>(
                //options =>
                 //   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICategoryDal,EfCategoryDal> ();
            services.AddScoped<ICategoryService, CategoryManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env,YemekSepetiContext ctx)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ctx.Database.Migrate();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
