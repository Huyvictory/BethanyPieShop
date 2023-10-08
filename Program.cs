using BethanyPieShop.Mock;
using BethanyPieShop.Repository;

var builder = WebApplication.CreateBuilder(args);

//Register services through DI container to be used through one lifecycle scope
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
