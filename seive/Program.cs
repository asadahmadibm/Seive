using Microsoft.EntityFrameworkCore;
using seive2;
using Sieve.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShoesContext>(x => x.UseSqlServer(@"server =.; database = test; User ID = sa; Password = ZahraAsad555555; encrypt=false"));

builder.Services.AddScoped<ISieveProcessor, SieveProcessor>();
builder.Services.AddScoped <IShoeRetrievalService, ShoeRetrievalService>();

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
