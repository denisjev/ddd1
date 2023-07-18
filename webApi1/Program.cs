using DDD1.Infraestructure.InputPort;
using DDD1.Application.InputAdapter;
using DDD1.Infraestructure.OutputAdapter.EFRepositories;

using Microsoft.EntityFrameworkCore;
//using Pomelo.EntityFrameworkCore.MySql;
using DDD1.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySql(builder.Configuration.GetConnectionString("AppDbContext"),
    new MySqlServerVersion(new Version(8,0))).EnableDetailedErrors());

builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonUseCaseServices, PersonUseCaseServices>();

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
