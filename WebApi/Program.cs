
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using Ymyp67CVProjectDataAccess.Contexts;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddDbContext<Ymyp67CVProjectDbContext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("HadiHome"),
            //        options =>
            //        {
            //            options.MigrationsAssembly(Assembly.GetAssembly(typeof(Ymyp67CVProjectDbContext))!.GetName().Name);
            //        });
            //});
            builder.Services.AddDbContext<Ymyp67CVProjectDbContext>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
