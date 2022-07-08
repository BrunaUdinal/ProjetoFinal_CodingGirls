using Gerenciamento_EvolutionSchool.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//builder.Services.AddDbContext<Gerenciamento_EvolutionSchool_Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(@"Server=tcp:evolutionschool.database.windows.net,1433;Initial Catalog=Gerenciamento_EvolutionSchool;Persist Security Info=False;User ID=raizes;Password=brudi1010*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddDbContext<Gerenciamento_EvolutionSchool_Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
