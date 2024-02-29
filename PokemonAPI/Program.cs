using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;
using PokemonAPI.Repositories;
using PokemonAPI.Repositories.Interfaces;
using PokemonAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbPokemonContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
builder.Services.AddScoped<PokemonService>();

builder.Services.AddScoped<IPokemonTypeRepository, PokemonTypeRepository>();
builder.Services.AddScoped<PokemonTypeService>();

builder.Services.AddScoped<IPokemonDietRepository, PokemonDietRepository>();
builder.Services.AddScoped<PokemonDietService>();

builder.Services.AddScoped<IPokemonSizeRepository, PokemonSizeRepository>();
builder.Services.AddScoped<PokemonSizeService>();

builder.Services.AddScoped<IPokemonRarityRepository, PokemonRarityRepository>();
builder.Services.AddScoped<PokemonRarityService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
