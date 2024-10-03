using Clean14000716.Application;
using CleanArchitecture.API.Hub;
using CleanArchitecture.Application;
using CleanArchitecture.Application.Common.Interfaces.IAuthentication;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.MongoDb;
using CleanArchitecture.Common.Utilities;
using CleanArchitecture.Persistence;
using CleanArchitecture.WebCommon.Authentication;
using CleanArchitecture.WebCommon.Middleware;

namespace CleanArchitecture.API
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var settings = builder.Configuration.GetSection("SiteSettings").Get<SiteSettings>();

            // Configure the persistence in another layer
 
            builder.Services.AddScoped<IJWTService, JWTService>();

       

            builder.Services.AddSignalR();
            builder.Services.AddCors(options => {
                options.AddPolicy("CORSPolicy", builder => builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().SetIsOriginAllowed((hosts) => true));
            });

            builder.Services.AddJwtAuthentication();
            builder.Services.AddControllers();
            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddApplicationServices(builder.Configuration);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();

            app.UseCustomExceptionHandler();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CORSPolicy");
      
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
                endpoints.MapHub<MessageHub>("/messages");                
            });

            app.UseHttpsRedirection();



            app.MapControllers();

          //  app.MapControllerRoute(
          //    name: "default",
          //    pattern: "{controller}/{action}/{id:int?}",
          //    defaults: new { controller = "Home", action = "Index" }
          //);

            app.Run();
        }
    }
}