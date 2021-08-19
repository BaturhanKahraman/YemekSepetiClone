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
using YemekSepetiClone.DataAccess.Abstract.Interfaces;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;
using Microsoft.OpenApi.Models;

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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",new OpenApiInfo { Title = "My API V1",Version = "v1" });
            });
            services.AddDbContext<YemekSepetiContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContextFactory<YemekSepetiContext>(
                //options =>
                 //   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICategoryDal,EfCategoryDal> ();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IMealDal,EfMealDal>();
            services.AddScoped<IMealService,MealManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env,YemekSepetiContext ctx)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","My API V1");
                c.RoutePrefix = string.Empty;
            });
            ctx.Database.Migrate();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
