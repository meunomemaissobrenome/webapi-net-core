using Microsoft.EntityFrameworkCore;
using WebApi_Estoque.RepoSitory.Context;
using WebApi_Estoque.RepoSitory.repos;
using WebApi_Estoque.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ServiceProduto>();
builder.Services.AddScoped<ServiceCliente>();
builder.Services.AddScoped<ProdutoRepository>();
builder.Services.AddScoped<ClienteRepository>();



var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataBaseContext>(options =>
  options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowAngular");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

