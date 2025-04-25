using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ThriveHavenMovies.Data;
using ThriveHavenMovies.Models.AccountStuff;
using ThriveHavenMovies.Models.CartStuff;
using ThriveHavenMovies.Models.ConcessionStuff;
using ThriveHavenMovies.Models.MovieStuff;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IMovieRepository, MovieRepository>();
builder.Services.AddTransient<IPaymentRepository, PaymentRepository>();

builder.Services.AddTransient<ICartRepository, CartRepository>();
builder.Services.AddTransient<ITicketRepository, TicketRepository>();

builder.Services.AddTransient<IConcessionRepository, ConcessionRepository>();

builder.Services.AddTransient<IConcessionOrderRepository, ConcessionOrderRepository>();

builder.Services.AddTransient<IOrderRepository, OrderRepository>();

// Configure the database context with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Add Identity services with Guid as the key for both users and roles
builder.Services.AddIdentity<Users, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Add Razor Pages and other necessary services
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();  // Add authentication
app.UseAuthorization();   // Add authorization

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();  // Add this if you have Razor Pages

app.Run();
