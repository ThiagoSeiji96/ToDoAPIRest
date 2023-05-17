using Dominio.Service.Implementations;
using Dominio.Service.Interface;
using Entidade.Repositories;
using Microsoft.EntityFrameworkCore;
using Repositorio;
using Repositorio.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//var connectionString = builder.Configuration.GetConnectionString("ToDoApp");
//builder.Services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(connectionString));

var connectionString = builder.Configuration.GetConnectionString("ToDoApp");
builder.Services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(connectionString));

//builder.Services.AddSingleton<ToDoDbContext>();

builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IListaDeTarefasRepositorio, ListaDeTarefasRepositorio>();
builder.Services.AddScoped<ITarefaServico, TarefaServico>();
builder.Services.AddScoped<IUsuarioServico, UsuarioServico>();
builder.Services.AddScoped<IListaDeTarefasServico, ListaDeTarefasServico>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
//{
//    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
//}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
