using FastEndpoints;
using FastEndpoints.Swagger;

WebApplicationBuilder builder = WebApplication.CreateBuilder();
builder.Services
    .AddFastEndpoints()
    .AddCors()
    .SwaggerDocument();

WebApplication app = builder.Build();
app.UseFastEndpoints()
    .UseCors(i => i.AllowAnyOrigin())
    .UseSwaggerGen();
app.Run();