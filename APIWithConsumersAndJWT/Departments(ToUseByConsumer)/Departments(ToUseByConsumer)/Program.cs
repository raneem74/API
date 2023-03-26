
using Departments_ToUseByConsumer_.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
using System.Net;
using System.Text;

namespace Departments_ToUseByConsumer_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DepartmentContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("APIlab3Conn"))
            );

            //inject user manager & role manager 
            builder.Services.AddIdentity<AppUser, IdentityRole>()
              .AddEntityFrameworkStores<DepartmentContext>();

            // Authorization with JWT token in Authentication check
            //to make [Authorize] understand how to check the token
            builder.Services.AddAuthentication(options =>
          {
              options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
              options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
              options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
          }).AddJwtBearer(options =>
          {
              options.SaveToken = true;//allow save 
              options.RequireHttpsMetadata = false;//to use https protocol
              options.TokenValidationParameters = new TokenValidationParameters()//what makes the token valid?
              {
                  ValidateIssuer = true,//ensure the token is from the same Issuer (provider)
                  ValidIssuer = builder.Configuration["JWT:ValidIssuer"],//the url of provider (could be more than one provider)
                  ValidateAudience = true,///check the Audience
                  ValidAudience = builder.Configuration["JWT:ValidAudience"],
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))//decrypt
              };
          });

            //for webApp consumer
            builder.Services.AddCors(CorsOptions =>
            {
                CorsOptions.AddPolicy("myPolicy", CorsPolicyBuilder =>
                {
                    CorsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            }
          );



            builder.Services.AddControllers();
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

            //for webApp consumer
            app.UseCors("myPolicy");
            //for webApp consumer
            app.UseStaticFiles();

            app.UseAuthentication();
            
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}