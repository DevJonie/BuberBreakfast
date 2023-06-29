using BuberBreakfast.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.MapControllers();
    app.Run();
}
