
WebApplicationBuilder builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();
builder.Services.AddCors()
    .AddEndpointsApiExplorer()
    .AddOpenApiDocument(config =>
    {
        config.Title = "Sports Web API";
        config.Version = "v1";
    });

WebApplication app = builder.Build();
app.UseCors(i => i.AllowAnyOrigin())
    .UseAuthorization()
    .UseOpenApi()
    .UseRouting()
    .UseStaticFiles()
    .UseDefaultFiles()
    .UseHsts()
    .UseHttpsRedirection();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage()
        .UseSwaggerUi();
}

app.Run();