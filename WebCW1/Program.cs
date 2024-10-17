using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDataAccess();
app.Run();
