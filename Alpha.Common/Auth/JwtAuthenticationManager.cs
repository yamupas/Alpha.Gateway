using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Alpha.Common.Auth
{
    public static class JwtAuthenticationManager
    {
        //public const string SecurityKey = "DwkdopIDAISOPDQWD59AS8D9AWD2ASD9sd59qwd";
        //public static void AddCustomJwtAuthentication(this IServiceCollection services)
        //{
        //    services.AddAuthentication(options =>
        //    {
        //        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    }).AddJwtBearer(o =>
        //    {
        //        o.RequireHttpsMetadata = false;
        //        o.SaveToken = false;
        //        o.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            ValidateIssuerSigningKey = true,
        //            ValidateIssuer = false,
        //            ValidateAudience = false,
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecurityKey))
        //        };
        //    });
        //}
    }
}
