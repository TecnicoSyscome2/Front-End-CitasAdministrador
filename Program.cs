using Blazored.LocalStorage;
using Front_End_Citas.Administrador;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Front_End_Citas.Administrador;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://147.93.136.6:9011/api/")
    BaseAddress = new Uri("http://192.168.1.35:9011/api/")
});

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
await builder.Build().RunAsync();
