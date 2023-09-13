using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<INewsLetterDal, EFNewsLetterDal>();
builder.Services.AddScoped<INewsLetterService, NewsLetterManager>();
builder.Services.AddScoped<IMessageDal, EFMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IHomePageDal, EFHomePageDal>();
builder.Services.AddScoped<IHomePageService, HomePageManager>();
builder.Services.AddScoped<IAboutDal, EFAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAdminDal, EFAdminDal>();
builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IContactClientDal, EFContactClientDal>();
builder.Services.AddScoped<IContactClientService, ContactClientManager>();
builder.Services.AddScoped<IBestSellerDal, EFBestSellerDal>();
builder.Services.AddScoped<IBestSellerService, BestSellerManager>();
builder.Services.AddScoped<ICommentDal, EFCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddDbContext<Context>();

builder.Services.AddSession(options =>
{
    // Oturum zaman aþýmý süresini belirleyin (örneðin 20 dakika)
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    // Oturum bilgilerinin çerezde saklanmasýný etkinleþtirin
    options.Cookie.IsEssential = true;
});
builder.Services.AddMvc();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/AdminLogin/Login/";
});
builder.Services.ConfigureApplicationCookie(options =>
{
	options.AccessDeniedPath = "/Error/Index/";
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/Index");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseStatusCodePagesWithReExecute("/Error/Index/", "?cod={0}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomePage}/{action=Index}/{id?}");

app.Run();
