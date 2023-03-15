using Microsoft.EntityFrameworkCore;
using VegetableStoreMvc.Models;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Registrera Context-klassen för dependency injection
builder.Services.AddDbContext<ApplicationContext>
    (o => o.UseSqlServer(connString));

builder.Services.AddScoped<FakeDataBase>();
// Stöd för controllers och views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Stöd för att mappa HTTP-anrop till våra controllers
app.UseRouting();

// Stöd för Route-attribut på våra Action-metoder
app.UseEndpoints(c => c.MapControllers());



app.Run();