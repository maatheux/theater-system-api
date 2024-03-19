using TheaterSystem.Api;
using TheaterSystem.Application;
using TheaterSystem.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddPresentation();
    builder.Services.AddAppliction();
    builder.Services.AddInfrastructure();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    app.Run();
}
