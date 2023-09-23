using GestionStock.Domain.Interface;
using GestionStock.Domain.Model;
using GestionStock.Domain.Services;
using GestionStock.Infrastructure;
using GestionStock.Infrastructure.Repositories;
using GestionStock.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStock.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GestionStock.API", Version = "v1" });
            });
            //SQL Server configuration
            services.AddDbContext<GestionStockContext>
                (options => options.UseSqlServer(
                      Configuration.GetConnectionString("Default"), x => x.MigrationsAssembly("GestionStock.Infrastructure")
                ));

            //DI
            services.AddTransient<IRepository<Client>, ClientRepository>();
            services.AddTransient<IRepository<Produit>, ProduitRepository>();
            services.AddTransient<IRepository<Commande>, CommandeRepository>();
            services.AddTransient<IRepository<LignesCommande>, LignesCommandeRepository>();

            // DI Service
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IProduitService, ProduitService>();
            services.AddTransient<ICommandeService, CommandeService>();
            services.AddTransient<ILignesCommandeService, LignesCommandeService>();

            // DI UnitOfWork

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GestionStock.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
