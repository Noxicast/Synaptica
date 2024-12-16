using Microsoft.EntityFrameworkCore;
using Synaptica.Data;
using Synaptica.Services;

var builder = WebApplication.CreateBuilder(args);

// Services configuration
builder.Services.AddScoped<CourseService>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<SessionService>();

// Database configuration
builder.Services.AddDbContext<SynpaticaDbContext>(options =>
    options.UseSqlServer(
        "Server=DEVON;Database=synaptica;Trusted_Connection=True;TrustServerCertificate=True;",
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: new[] { 4060, 40197, 40501, 40613, 49918, 49919, 49920 }  // Common transient errors
            );
            sqlOptions.CommandTimeout(30);
        }
    ));

var app = builder.Build();

// Configure error handling first
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Configure endpoints
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();