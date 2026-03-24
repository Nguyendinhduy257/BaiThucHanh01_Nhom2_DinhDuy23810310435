using Microsoft.EntityFrameworkCore;
using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using BaiThucHanh01_Nhom2_DinhDuy23810310435;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Chương trình bắt đầu xây dựng dự án từ đây
builder.Services.AddControllersWithViews();

//nhét PATH dẫn đến CSDL PostGreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//xây dựng dự án
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SanPham}/{action=Info}/{id?}")
    .WithStaticAssets();


app.Run();
