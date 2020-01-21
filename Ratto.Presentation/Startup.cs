using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

using Microsoft.EntityFrameworkCore;
using Ratto.Infra.Context;
using Ratto.Domain.Interfaces.Services;
using Ratto.Domain.ServicesDomain;
using Ratto.Domain.Interfaces.Repositories;
using Ratto.Infra.Repositories;
using Ratto.Application.Interface;
using Ratto.Application.Services;

namespace Ratto.Presentation
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "RattoApi", Version = "v1" });
            });

            this.DependencyInjections(services);


            services.AddDbContext<RattoContext>
               (options => options.UseSqlServer(Configuration.GetConnectionString("RattoConnectionString")));

        }

        public void DependencyInjections(IServiceCollection services)
        {

            //App Services
            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient<IEnderecoAppService, EnderecoAppService>();

            //Services
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IEnderecoService, EnderecoService>();

            //Repositories
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddTransient<IRepositoryCliente, RepositoryCliente>();
            services.AddTransient<IRepositoryEndereco, RepositoryEndereco>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RattoApi");
            });


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
