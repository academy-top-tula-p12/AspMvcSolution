using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


//app.MapControllerRoute(
//    name: "info",
//    pattern: "info/{controller}/{action}/{id}");

app.MapControllerRoute(
    name: "news",
    pattern: "news/{action=Index}/{category:alpha}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");



app.Run();
