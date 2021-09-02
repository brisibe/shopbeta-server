using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;
using shopbeta_server.Infrastructure.Authentication;
using shopbeta_server.Infrastructure.Logger;
using shopbeta_server.Infrastructure.Repository;
using shopbeta_server.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta_server.Extensions
{
    public static class ServiceExtensions
    {
       // public static void ConfigureCors(this IServiceCollection services) =>
       //services.AddCors(options =>
       //{

       //    options.AddPolicy("CorsPolicy" , builder =>
       //    {
       //        builder.WithOrigins("http://shopbeta.vercel.app", "https://www.shopbeta.vercel.app");
       //    });
       //});

        public static void ConfigureAuthManager(this IServiceCollection services) =>
            services.AddScoped<IAuthenticationManager, AuthenticationManager>();

        public static void ConfigureLogger(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts => 
            opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("shopbeta")));

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<User>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
                o.User.RequireUniqueEmail = true;
            });
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);

            builder.AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var secretKey = configuration.GetSection("SECRET").Value ?? throw new ArgumentNullException("secret is null");


            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = configuration.GetSection("jwt_validIssuer").Value ?? throw new ArgumentNullException("issuer is null"),
                    ValidAudience = configuration.GetSection("jwt_validAudience").Value ?? throw new ArgumentNullException("audience is null"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
           
            
        }

        public static void ConfigureAzureBlog(this IServiceCollection services, IConfiguration configuration) =>
            services.AddScoped(_ =>
            {
                return new BlobServiceClient(configuration.GetConnectionString("AzureBlobStorage"));
            });

        public static void ConfigureFileUpload(this IServiceCollection services) =>
            services.AddScoped<IStorageService, AzureStorageService>();

        //public static void ConfigureResponseCaching(this IServiceCollection services) =>
        //   services.AddResponseCaching();
       
    }
}
