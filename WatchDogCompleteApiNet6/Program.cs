using System.Text.Json;
using System.Text.Json.Serialization;
using WatchDog;
using WatchDog.src.Enums;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddWatchDogServices();
builder.Services.AddWatchDogServices(opt =>
{
    opt.IsAutoClear = true;
    opt.ClearTimeSchedule = WatchDogAutoClearScheduleEnum.Monthly;
    opt.DbDriverOption = WatchDogDbDriverEnum.Mongo;
    //opt.SetExternalDbConnString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=test;";
    opt.SetExternalDbConnString = "mongodb://localhost:27017";
});
builder.Logging.AddWatchDogLogger();

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

app.UseWatchDogExceptionLogger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseWatchDog(conf =>
{
    conf.WatchPageUsername = "admin";
    conf.WatchPagePassword = "Qwerty@123";
    conf.Blacklist = "/auth";
});

app.Run();
