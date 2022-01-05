using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Services;
using Microsoft.EntityFrameworkCore;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Services;
using AutoMapper;
using DeviceManagerBackend.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(MainProfile));

builder.Services.AddScoped<DeviceService>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

builder.Services.AddScoped<RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();

builder.Services.AddScoped<AuthorizationService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

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
