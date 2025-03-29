
using E_commerce_System.Layer.DataAccess.Repository.IRepository;
using E_commerce_System.Layer.DataAccess.Repository;
using Layer.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using E_commerce_System.Layer.Models;
using E_commerce_System.Layer.Utility;




namespace E_commerce_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<ApplicationDbContext>(option=>      
            option.UseSqlServer(builder.Configuration.GetConnectionString("DC")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(options => {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            builder.Services.AddScoped<SignInManager<ApplicationUser>>();
            builder.Services.AddScoped<UserManager<ApplicationUser>>();
            builder.Services.AddScoped<ApplicationUser>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            builder.Services.AddRazorPages();


            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
