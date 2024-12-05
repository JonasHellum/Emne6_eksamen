using Emne6_Eksamen.Components;
using Emne6_Eksamen.Components.Pages;
using Emne6_Eksamen.Components.Pages.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<BooksService>();
builder.Services.AddHttpClient<CharacterService>();

builder.Services
    .AddSingleton<IBooksService, BooksService>()
    .AddSingleton<ICharacterService, CharacterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();