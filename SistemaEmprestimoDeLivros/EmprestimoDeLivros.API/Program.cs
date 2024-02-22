using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoDeLivros.Persistence;
using SistemaEmprestimoDeLivros.Application.Services;
using SistemaEmprestimoDeLivros.Persistence.Context;
using System;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

CreateDatabase(app);

static void CreateDatabase(WebApplication app)
{
    var servicesScope = app.Services.CreateScope();
    var dataContext = servicesScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();

}

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
