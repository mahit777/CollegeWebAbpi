using CollegeWebAbpi.Data;
using CollegeWebAbpi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient(typeof(ICollegeService), typeof(CollegeService));
builder.Services.AddDbContext<CollegeContext>();
builder.Services.AddTransient(typeof(DbContext), typeof(CollegeContext));

var context = new CollegeContext();
context.Database.EnsureCreated();
context.SaveChanges();

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
