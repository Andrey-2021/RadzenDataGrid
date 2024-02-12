using BlazorApp1.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Radzen;
using System;

namespace BlazorApp1;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddRazorComponents()
			.AddInteractiveServerComponents();

            builder.Services.AddRadzenComponents();



		//!!!! get connection settings for DB
		string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
		if (connection != null)
		{
			builder.Services.AddDbContextFactory<MyDbContetx>(opt => opt.UseSqlServer(connection));
		}

	

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
		app.UseAntiforgery();

		app.MapRazorComponents<App>()
			.AddInteractiveServerRenderMode();

		app.Run();
	}
}
