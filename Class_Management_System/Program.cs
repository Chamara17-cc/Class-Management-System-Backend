global using Microsoft.EntityFrameworkCore;
using Class_Management_System.Data;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Configure CORS policies
builder.Services.AddCors(options => {
    options.AddPolicy("ReactJSDomain",
        policy => policy.WithOrigins("*") // For development, allow any origin; for production, restrict
        .AllowAnyHeader()
        .AllowAnyMethod()
    );
});

// Alternative CORS policy (you should use only one CORS policy in production)
builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Add DbContext configuration
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBCS"))
);

// Add controllers
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use the CORS middleware
app.UseCors("ReactJSDomain"); // Apply the selected CORS policy

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
