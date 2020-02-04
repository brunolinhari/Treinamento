using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BOL.Api.Configurations;
using BOL.Api.Extensions;
using BOL.Busines.Interfaces;
using BOL.Busines.Notificações;
using BOL.Data.Context;
using BOL.Data.Repository;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using KissLog.Listeners;
using Microsoft.AspNetCore.Http;
using KissLog;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace BOL.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //            services.AddScoped<ILogger>((context) =>
            //            {
            //                return Logger.Factory.Get();
            //            });

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.ReportApiVersions = true; //API Headers
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.AddDbContext<ApiContext>(opt=>{opt.UseSqlServer(Configuration.GetConnectionString("sql"));});
            services.AddIdentityConfig(Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddApiConfig();
            services.AddDependencyInjectionConfig();
            services.AddSwaggerConfig();
            services.AddResponseCaching();
            //services.AddHealthChecks().AddSqlServer(Configuration.GetConnectionString("sql"), name: "BancoSQL")
            //                          .AddCheck("Fornecedores", new SqlServerHealthCheck(Configuration.GetConnectionString("sql")));
            //services.AddHealthChecksUI();
            services.AddResponseCompression(opt => 
            { 
                opt.Providers.Add<BrotliCompressionProvider>(); 
                opt.EnableForHttps = true; 
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                             .AddXmlDataContractSerializerFormatters();
                             //.AddJsonOptions(opcoes => //Ignorar Props Null
                             //{
                             //    opcoes.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore; 
                             //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure
        (
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, 
            IApiVersionDescriptionProvider provider
        )
        {
            loggerFactory.AddFile("log/bol-{Date}.txt", Microsoft.Extensions.Logging.LogLevel.Error, fileSizeLimitBytes: 100000000);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseKissLogMiddleware(options => {
            //    options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
            //        Configuration["KissLog.OrganizationId"],
            //        Configuration["KissLog.ApplicationId"])
            //    ));
            //});

            app.UseHttpsRedirection();
            app.UseSwaggerConfig(provider);
            app.UseResponseCaching();
            app.UseResponseCompression();
            //app.UseHealthChecks("/api/hc", new HealthCheckOptions
            //{
            //    Predicate = _ => true,
            //    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            //});
            //app.UseHealthChecksUI(); // /healthchecks-ui
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
