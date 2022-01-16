using Microsoft.EntityFrameworkCore;
using RestfulCRUDapp.Models;
using RestfulCRUDapp.PlayerData;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<PlayerContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("PlayerContextConnectionString")));

builder.Services.AddScoped<IPlayerData, SqlPlayerData>();

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
