using Microsoft.EntityFrameworkCore;
using Synaptica.Data;
using Synaptica.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//added to register session services just to manage session data, in this case its currently just the users name
builder.Services.AddSingleton<SessionService>();


builder.Services.AddDbContext<SynpaticaDbContext>(options =>
    options.UseSqlServer("Server=DEVON;Database=synaptica;Trusted_Connection=True;TrustServerCertificate=True;"));


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();

//Temp
app.MapFallbackToPage("/_Host");

// added this so on start register page is shown instead of dashboard
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapRazorPages();
//     endpoints.MapBlazorHub();

//     // Redirect "/" to "/register" on app startup
//     endpoints.MapGet("/", context =>
//     {
//         context.Response.Redirect("/register");
//         return Task.CompletedTask;
//     });

//     // this just falls back to the main page if there is an error
//     app.MapFallbackToPage("/_Host");
// });

app.Run();


