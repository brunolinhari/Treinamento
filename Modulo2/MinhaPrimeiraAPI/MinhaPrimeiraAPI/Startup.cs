using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MinhaPrimeiraAPI.DAL;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;

namespace MinhaPrimeiraAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context, Context>(options => options.UseInMemoryDatabase(databaseName: "ProdutosInMemory"));

            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                //c.SwaggerDoc("v1", new Info { Title = "Minha Primeira API", Version = "v1" });
                //c.RoutePrefix = string.Empty;
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Minha Primeira API",
                    Description = "Um simples exemplo de ASP.NET Core Web API",
                    //TermsOfService = new Uri("https://example.com/terms"),
                    TermsOfService = "https://example.com/terms",
                    Contact = new Contact
                    {
                        Name = "Bruno Linhari",
                        Email = string.Empty,
                        //Url = new Uri("https://twitter.com/spboyer"),
                        Url = "https://twitter.com/spboyer",
                    },
                    License = new License
                    {
                        Name = "Minha Licença",
                        //Url = new Uri("https://example.com/license"),
                        Url = "https://example.com/license",
                    }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha Primeira API V1");
            });
            app.UseMvc();
        }
    }
}
