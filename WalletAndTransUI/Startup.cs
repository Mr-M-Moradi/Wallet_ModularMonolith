using Application;
using Domain.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletAndTransUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services){
            services.AddControllersWithViews();// ادد Controllers و Views 


            //var builder = WebApplication.CreateBuilder(args); //for api?
            //1. اددContext برای لایه زیرساخت
            services.AddDbContext<WalletDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default"))); //ست کردن کانکشن استرینگ در ادامش بصورت لامبدا
            //2. تعریف اینترفیس و پیادهسازی Dependency 
            services.AddScoped<IWalletRepository, WalletDbContext>();
            //services.AddScoped<ITransactionRepository, TransactionRepository>();
            //3.ادد کردن لایه ی اپلیکیشن برای دسترسی UI
            services.AddScoped<CreateWallet>();
            //var app = builder.Build(); //for api?

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


