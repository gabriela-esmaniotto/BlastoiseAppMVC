using BlastoiseApp.Application.Services;
using BlastoiseApp.Data.Contexts;
using BlastoiseApp.Data.Repositories;
using BlastoiseApp.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

#region Services


var cultureInfo = new CultureInfo("pt-BR");
cultureInfo.NumberFormat.CurrencySymbol = "R$";

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
CultureInfo.CurrentCulture = cultureInfo;
CultureInfo.CurrentUICulture = cultureInfo;

builder.Services.AddHttpClient();

builder.Services
		.AddDbContext<BlastoiseAppDbContext>(_ => _
				.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddMvc().AddRazorRuntimeCompilation();

builder.Services.AddControllersWithViews();

ConfigureServices(builder.Services);

#endregion

var app = builder.Build();


if (app.Environment.IsProduction())
{
	app.UseExceptionHandler("/Error/Index");
	app.UseHsts();
}
else
{
	app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseResponseCompression();
app.UseRouting();
//app.UseAuthentication();
app.UseAuthorization();
app.UseResponseCaching();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");


app.Run();


static void ConfigureServices(IServiceCollection services)
{
	services.AddScoped<IPokemonRepository, PokemonRepository>();
	services.AddScoped<IPokemonService, PokemonService>();

	services.AddScoped<IContactRepository, ContactRepository>();
	services.AddScoped<IContactService, ContactService>();
}

