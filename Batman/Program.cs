using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Batman.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BatmanContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BatmanContext") ?? throw new InvalidOperationException("Connection string 'BatmanContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
