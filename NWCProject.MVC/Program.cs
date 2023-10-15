using Microsoft.EntityFrameworkCore;
using NWCProject;
using NWCProject.Repositories;
using NWCProject.Repositories.HelperMethods;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NwcDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MyConection"))
            );
builder.Services.AddScoped<SubscriberRepository>();
builder.Services.AddScoped<EstateTypesRepository>();
builder.Services.AddScoped<InvoiceCalculateHelper>();
builder.Services.AddScoped<SubscriptionRepository>();
builder.Services.AddScoped<InvoicesRepository>();
builder.Services.AddScoped<SliceValuesRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSerilogRequestLogging();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
