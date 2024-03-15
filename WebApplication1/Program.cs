using MaktabBank.Core.Core.Interface.AppServices;
using MaktabBank.Core.Core.Interface.Repository;
using MaktabBank.Core.Core.Interface.Services;
using MaktabBank.Infrastructure.EfCore;
using MaktabBank.Infrastructure.EfCore.Repositories;
using MaktabBank.Services.AppServices;
using MaktabBank.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

builder.Services.AddScoped<IBankAccountAppServices, BankAccountAppServices>();
builder.Services.AddScoped<IBankAccountServices, BankAccountServices>();
builder.Services.AddScoped<IBankAccountRepository, BankAcountRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IMessageServices, SmsServices>();
builder.Services.AddScoped<IMessageServices, EmailServices>();

builder.Services.AddScoped<IUserServices, UserServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
