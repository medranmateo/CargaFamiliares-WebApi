using CargaFamiliares_WebApi.Application.Interfaces.IRepositories;
using CargaFamiliares_WebApi.Application.Interfaces.IServices;
using CargaFamiliares_WebApi.Application.Repositories;
using CargaFamiliares_WebApi.Application.Services;
using CargaFamiliares_WebApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("Desarrollo",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyeccion de dependencias
builder.Services.AddScoped<IFamiliaresServices, FamiliaresService>();
builder.Services.AddScoped<IFamiliaresRepository, FamiliaresRepository>();
builder.Services.AddScoped<ITiposDescripcionService, TiposDescripcionService>();
builder.Services.AddScoped<ITiposDescripcionRepository, TiposDescripcionRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Desarrollo");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
