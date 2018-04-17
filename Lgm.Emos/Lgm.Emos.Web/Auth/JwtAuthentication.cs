using Lgm.Emos.Web.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lgm.Emos.Web.Auth
{
    static public class JwtAuthentication
    {
        static public void AddJwtAuthentication(this IServiceCollection services)
        {
            //services.AddSingleton<IJwtFactory, JwtFactory>();

            //services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();

            //// jwt wire up
            //// Get options from app settings
            //var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            //// Configure JwtIssuerOptions
            //services.Configure<JwtIssuerOptions>(options =>
            //{
            //    options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
            //    options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            //});

            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidateIssuer = true,
            //    ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

            //    ValidateAudience = true,
            //    ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = _signingKey,

            //    RequireExpirationTime = false,
            //    ValidateLifetime = true,
            //    ClockSkew = TimeSpan.Zero
            //};

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            //}).AddJwtBearer(configureOptions =>
            //{
            //    configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
            //    configureOptions.TokenValidationParameters = tokenValidationParameters;
            //    configureOptions.SaveToken = true;
            //});

            //// api user claim policy
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("ApiUser", policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
            //});
        }
    }
}
