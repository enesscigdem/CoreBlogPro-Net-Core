using Microsoft.AspNetCore.Identity;
using NToastNotify;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Extensions;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddNToastNotifyToastr(new NToastNotify.ToastrOptions()
    {
        PositionClass = ToastPositions.TopRight,
        TimeOut = 3000
    })
    .AddRazorRuntimeCompilation();

builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    //projeyi canlıya alırsan bu kısımları kaldır, buraları test için kullanmak çok daha mantıklı olacaktır.
    opt.Password.RequireNonAlphanumeric = false; // test aşamasında örneğin password için 123456 verdik. ( büyük küçük harf zorunluluğu vs. pasif ediyoruz
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
    //örneğin kullanıcı giriş yapmadı ama admin/.. path'ini biliyor. bu durumda kullanıcıyı belirlemiş olduğumuz bu path'e yönlendireceğiz.
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "YoutubeBlog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest // http ve https destekler. canlıya çıkılırsa always seçilmesi daha mantıklıdır.
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(1); // bu cookie'nin ne kadar sistemde tutulacağını belirliyoruz. örneğin bir siteye giriş yaptım fromdays(7) tanımlarsam 7 gün boyunca hiç çıkmayacak.
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccesDenied"); // Yetkisiz bir giriş olduğunda burası çalışacak.
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseNToastNotify();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();
app.UseAuthentication(); // bu ikisinin sıralaması önemli ! authentication üstte kalmalı.
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapDefaultControllerRoute(); // admin verdiğim bi alanı admin olarak çağırıcam vermezsem default olarak çağırılacak.
});

app.Run();

