using DataGridASP.Models.DAL.DataContexts;
using DataGridASP.Models.Services;
using DataGridASP.Models.Services.CRUD;
using Microsoft.EntityFrameworkCore;

namespace DataGridASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddMvcCore();

            string connection = builder.Configuration.GetConnectionString("Connection")!;
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            builder.Services.AddScoped<DataEntityService>();

            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.MapRazorPages();

            app.MapControllers();

            app.Run();
        }
    }
}