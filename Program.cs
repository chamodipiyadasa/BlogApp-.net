using BlogApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register DB Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=blog.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
