using Microsoft.EntityFrameworkCore;
using Synaptica.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register the database context
builder.Services.AddDbContext<SynpaticaDbContext>(options =>
    options.UseSqlServer("Server=DEVON;Database=synpatica;Trusted_Connection=True;TrustServerCertificate=True;"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();


