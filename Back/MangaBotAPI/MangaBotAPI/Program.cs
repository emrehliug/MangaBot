using Infra.Context;
using Infra.Repository.Interfaces;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MangaBotContext>(
    contextdb => contextdb.UseMySql(builder.Configuration.GetConnectionString("MySql"),ServerVersion.AutoDetect("Server=186.202.152.149;Database=photobreak3;Uid=photobreak3;Pwd=Brasil@00;Persist Security Info=True;sslmode=None;"))
    );
builder.Services.AddScoped<IMangaRepository, MangaRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

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
