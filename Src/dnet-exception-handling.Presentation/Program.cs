using dnet_exception_handling.Application.Common.Composers;
using dnet_exception_handling.Infrastructure.Common.Composer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.RegisterApplication();
builder.Services.RegisterInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
