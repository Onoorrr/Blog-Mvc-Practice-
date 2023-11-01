using Blog.Data.Extensions;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Blog.Service.Extensions;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); // AddRazorRuntimeCompilation indirdiðimiz nugetý kullanmak için eklenmiþtir.
builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapAreaControllerRoute
	(
		name: "Admin",
		areaName: "Admin",
		pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
		);
	endpoints.MapDefaultControllerRoute();

}
);

app.Run();
