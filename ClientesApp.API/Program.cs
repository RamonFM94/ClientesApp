using ClientesApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerConfig();

var app = builder.Build();

app.UseSwaggerConfig();
app.UseAuthorization();
app.MapControllers();

app.Run();
