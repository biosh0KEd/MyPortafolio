using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portafolio;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services
	.AddBlazorise(options =>
	{
		options.Immediate = true;
	})
	.AddBootstrapProviders()
	.AddFontAwesomeIcons();

builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

await builder.Build().RunAsync();
//https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs