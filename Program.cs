using MC_Five_to_Seven.Services.Five;
using MC_Five_to_Seven.Services.Six;
using MC_Five_to_Seven.Services.Seven;
using MC_Five_to_Seven.Services.Seven123;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFiveService, FiveService>();
builder.Services.AddScoped<ISixService, SixService>();
builder.Services.AddScoped<ISevenService, SevenService>();
builder.Services.AddScoped<ISeven123Service, Seven123Service>();

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
