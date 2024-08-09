using Rest.Models.Data;
using Microsoft.EntityFrameworkCore;
using Rest.Models.Repositories;
using Rest.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services
    .AddEndpointsApiExplorer();
builder.Services
    .AddSwaggerGen();
builder.Services
    .AddControllers();
builder.Services
    .AddScoped<IRepository, UsersRepository>()
    .AddScoped<IUserService, UserService>();
builder.Services
    .AddDbContext<ApplicationContext>(options 
        => options.UseNpgsql(connectionString));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.MapControllers();
app.Run();