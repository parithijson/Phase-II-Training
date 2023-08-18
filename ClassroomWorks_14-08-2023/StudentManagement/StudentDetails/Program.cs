using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Controllers;
using Microsoft.Build.Framework;
using StudentDetails.Services.Interfaces;
using StudentDetails.Services.ServiceClasses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentContext>(
        optionsAction: options => options.UseSqlServer(
                builder.Configuration.GetConnectionString(name: "SQLConnection")
            ));

builder.Services.AddScoped<IStudent, StudentService>();


var app = builder.Build();

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
