using EventSourcingCalendar.Application;
using EventSourcingCalendar.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
  // builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
  builder.Services
  .AddApplication()
  .AddInfrastructure();
  builder.Services.AddControllers();
}

var app = builder.Build();
{
  app.UseHttpsRedirection();
  // app.UseAuthorization();
  app.MapControllers();
  app.Run();
}

