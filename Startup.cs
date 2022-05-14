namespace WebApiKalum


{
    public class Startup 
    {
        public Startup IConfiguracion Configuration(get;)
        public Startup(IConfiguracion _Configuration)
        {
            this.Configuration = _Configuration;
        }

        public void ConfigureServices(IServiceCollection _services)
        {
            _services.AddControllers();
            _services.AddDbContexts<>
        }
    }

}