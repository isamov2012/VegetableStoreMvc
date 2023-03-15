using Microsoft.EntityFrameworkCore;
using VegetableStoreMvc.Models;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Registrera Context-klassen f�r dependency injection
builder.Services.AddDbContext<ApplicationContext>
    (o => o.UseSqlServer(connString));

builder.Services.AddScoped<FakeDataBase>();
// St�d f�r controllers och views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// St�d f�r att mappa HTTP-anrop till v�ra controllers
app.UseRouting();

// St�d f�r Route-attribut p� v�ra Action-metoder
app.UseEndpoints(c => c.MapControllers());



app.Run();