using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using SMS.BLL.Contacts;
using SMS.BLL.Services;
using SMS.DAL.Contacts;
using SMS.DAL.Data;
using SMS.DAL.Repositories;
using SMS.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));

builder.Services.AddAutoMapper(typeof(ApplicationMapper));


builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IWindowRepository, WindowRepository>();
builder.Services.AddScoped<ISubElementRepository, SubElementRepository>();


builder.Services.AddScoped<IOrderService, OrderService>();
//builder.Services.AddScoped<IWindowService, WindowService>();
//builder.Services.AddScoped<ISubElementService, SubElementService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
