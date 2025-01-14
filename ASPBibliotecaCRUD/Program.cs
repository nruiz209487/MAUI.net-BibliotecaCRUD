var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Soporte para MVC (vistas)
builder.Services.AddControllers(); // Soporte para APIs

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Para producción (HSTS)
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Mapea las rutas para controladores de API (esto es necesario para que la API funcione correctamente)
app.MapControllers(); // Agrega esto para que las rutas de la API sean mapeadas correctamente

// Mapea las rutas para vistas (MVC)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();