using WebApplicationKalum;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigurationService(builder.Services);

// Add services to the container.

var app = builder.Build();

startup.ConfigurationService(app, app.Environment);

app.Run();
