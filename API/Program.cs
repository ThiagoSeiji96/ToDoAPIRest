using Dominio.Service.Implementations;
using Dominio.Service.Interface;
using Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//var connectionString = builder.Configuration.GetConnectionString("ToDoApp");
//builder.Services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddSingleton<ToDoDbContext>();

builder.Services.AddScoped<ITarefaServico, TarefaServico>();

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
