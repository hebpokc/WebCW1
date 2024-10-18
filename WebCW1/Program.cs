using BusinessLogic;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinessLogic();

var app = builder.Build();

app.Run();
