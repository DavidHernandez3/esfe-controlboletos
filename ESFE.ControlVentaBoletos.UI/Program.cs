using Microsoft.EntityFrameworkCore;
using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using ESFE.ControlVentaBoletos.BL.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ControlVentaBoletosContext>(opciones => {
	opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IGenericRepository<Asignacion>, AsignacionRepository>();
builder.Services.AddScoped<IGenericRepository<Boleto>, BoletoRepository>();

builder.Services.AddScoped<IAsignacionService, AsignacionService>();
builder.Services.AddScoped<IBoletoService, BoletoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
