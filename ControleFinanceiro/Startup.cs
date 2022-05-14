using ControleFinanceiro.Data;
using ControleFinanceiro.Repository;
using ControleFinanceiro.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro
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
            services.AddSwaggerGen();
            services.AddDbContext<FinancialContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("SqlConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "financial-control v1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
