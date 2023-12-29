using rwwo.webapicqrsmediar.Data;
using rwwo.webapicqrsmediar.Repositories;
using MediatR;
using rwwo.webapicqrsmediar.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(StudentDetails).Assembly);
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
