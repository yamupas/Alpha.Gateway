using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Alpha.Common.Auth
{
    public static class JwtExtensions
    {

        public const string SecurityKey = "DwkdopIDAISOPDQWD59AS8D9AWD2ASD9sd59qwd";//"secretJWTsigningKey@123";

        public static void AddJwtAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                   // ValidIssuer = "https://localhost:5002",
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecurityKey))
                };
            });
        }

        //public static string SecurityKey = ""; // ;"DwkdopIDAISOPDQWD59AS8D9AWD2ASD9sd59qwd";
        //public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        //{

        //    var options = new JwtOptions();
        //    var section = configuration.GetSection("jwt");
        //    section.Bind(options);
        //    services.Configure<JwtOptions>(configuration.GetSection("jwt"));

        //    services.AddAuthentication(opt => {
        //        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    }).AddJwtBearer(cfg =>
        //        {
        //            cfg.RequireHttpsMetadata = false;
        //            cfg.SaveToken = true;
        //            cfg.TokenValidationParameters = new TokenValidationParameters()
        //            {
        //                ValidateIssuerSigningKey = true,
        //                ValidateIssuer = false,
        //                ValidateAudience = false,
        //               // ValidIssuer = options.JwtIssuer,                       
        //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(options.JwtKey))
        //            };
        //        });           
        //}
    }
}
