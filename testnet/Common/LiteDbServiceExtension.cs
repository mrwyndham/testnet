using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using testnet.Models;


namespace testnet.Common
{
    public static class LiteDbServiceExtension
    {
        public static void AddLiteDb(this IServiceCollection services, string databasePath)
        {
            services.AddSingleton<TestnetContext, TestnetContext>();
            services.AddTransient<Models.Services.UserInfoService, Models.Services.UserInfoService>();
            services.AddTransient<Models.Services.ProductsService, Models.Services.ProductsService>();
            services.Configure<LiteDbConfig>(options => options.DatabasePath = databasePath);
        }
    }
}
