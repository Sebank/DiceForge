using wwwapi.Data;
using wwwapi.Endpoints;
using wwwapi.Models;
using wwwapi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IRepository<Character>, Repository<Character>>();
builder.Services.AddScoped<IRepository<AbilityScores>, Repository<AbilityScores>>();
builder.Services.AddScoped<IRepository<Style>,  Repository<Style>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCharacterEndpoint();

app.Run();
