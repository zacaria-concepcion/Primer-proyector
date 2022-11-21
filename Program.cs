using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Zacaria20181285;
using Zacaria20181285.Data;
using Zacaria20181285.Data.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSqlite<Zacaria20181285DbContext>("Data Source=.//Data//Context//localDB.sqlite");
builder.Services.AddScoped<Zacaria20181285DbContext,Zacaria20181285DbContext>();

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

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
 using (var scope = scopeFactory.CreateScope()) 
 { var db = scope.ServiceProvider.GetRequiredService<Zacaria20181285DbContext>();
  if (db.Database.EnsureCreated()) {

} } 

app.Run();
