using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Tienda.Data;
using Tienda.Modelos;
using Tienda.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql("server=192.168.1.30;user=remote;password=bodoque*1611;database=Tienda",
        new MySqlServerVersion(new Version(10, 11, 3)))); // Asegúrate de usar la versión correcta de MySQL
builder.Services.AddScoped<IRepositorio<Modelo_Abm_Marca>, RepositorioMarca>();
builder.Services.AddScoped<IRepositorio<Modelo_Abm_TipoProd>, RepositorioTipoProd>();
builder.Services.AddScoped<IRepositorio<Modelo_ModelodeProductos>, RepositorioModelo>();
builder.Services.AddScoped<IRepositorio<Articulos>, RepositorioArticulos>();
builder.Services.AddScoped<IRepositorio<ModeloVenta_Articulos>, RepositorioVenta_Articulos>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
