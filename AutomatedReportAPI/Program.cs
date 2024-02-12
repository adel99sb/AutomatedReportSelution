using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//string path = Environment.CurrentDirectory;
//Console.WriteLine(path);
//string[] appPath = path.Split(new string[] { "bin" }, StringSplitOptions.None);
//Console.WriteLine(appPath[0]);
//var path = @"C:\Users\adela\OneDrive\Desktop\AutomatedReport\DB";
//AppDomain.CurrentDomain.SetData("DataDirectory", path);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

using var scope = builder.Services.BuildServiceProvider().CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
dbContext.Database.EnsureCreated(); // Creates the database if not exists
dbContext.Database.Migrate(); // Applies pending migrations

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<WhatsAppService>();
builder.Services.AddMyRepositories();

var app = builder.Build();
app.UseMiddleware<WhatsAppMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
