using Microsoft.EntityFrameworkCore;
namespace WebApiKalum

{
    public class Startup 
    {
        public Startup IConfiguracion Configuration {get;}
        public Startup(IConfiguracion _Configuration)
        {
            this.Configuration = _Configuration;
        }

        public void ConfigureServices(IServiceCollection _services)
        {
            _services.AddControllers();
            _services.AddControllers().AddNewtonsoftJson(options => options.)
            _services.AddDbContexts<KalumDbContex>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            _services.AddEndpointsApiExplorer();
            _services.AddSwaggerGen();
        }
        public void Configure(IAplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.Routing();
            app.UseAuthorization();
            app.UseEnpoints(endpoint => {
                endpoint.MapControllers();  
            })
        }
    }

}