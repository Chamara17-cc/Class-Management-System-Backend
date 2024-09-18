global using Microsoft.EntityFrameworkCore;
using Class_Management_System.Data;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
builder.Services.AddCors(options => {
    options.AddPolicy("ReactJSDomain",
        policy => policy.WithOrigins("*")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
        );
});
builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins(" *").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
}));
builder.Services.AddControllers();

// Configure DbContext
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBCS")));


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
