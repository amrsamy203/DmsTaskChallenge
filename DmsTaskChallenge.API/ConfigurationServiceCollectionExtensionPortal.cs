using DmsTaskChallenge.Repository.Repositories.Base;
using DmsTaskChallenge.Repository.Data;
using DmsTaskChallenge.Services.Implementation;
using DmsTaskChallenge.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using DmsChallenge.Repository.Repositories.Base;

namespace DmsTaskChallenge.API
{
    public static class ConfigurationServiceCollectionExtensionPortal
    {
        public static IServiceCollection AddAppCollection(this IServiceCollection services, IConfiguration config)
        {
            #region configuration connection string

            string connectionString = "localConn";
            #endregion

            #region resolving the services
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IUomService, UomService>();
            #endregion


            #region resolve the context 
            services.AddDbContext<DmsTaskChallengeContext>(options =>
                    options.UseSqlServer(config.GetConnectionString(connectionString)));
            #endregion

            #region configure swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DmsTaskChallenge", Version = "v1" });
            });
            #endregion

            return services;
        }
    }
}
