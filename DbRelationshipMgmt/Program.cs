using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using DbRelationshipMgmt.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MyAppDbContext>(options => options.UseSqlServer(connectionstring));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MyAppDbContext>();


builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<Iuploadimg, uploadimgRepository>();

builder.Services.AddScoped<ISubject, SubjectRepository>();
builder.Services.AddScoped<ISubjectTopic, SubjectTopicRepository>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
