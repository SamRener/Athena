using Athena.IoC;
using Athena.Presentation.Components;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SRenerCq;

var builder = WebApplication.CreateBuilder();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazorContextMenu();
builder.Services.AddAthena();
builder.Services.AddSRenerCq<Program>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

#if DEBUG
await app.UseDevelopmentAthena();
#endif

app.Run();