using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OneMusic.Application.Interfaces;
using OneMusic.Application.Tools;
using OneMusic.Persistence.Context;
using OneMusic.Persistence.Repositories;
using OneMusic.Application.Services;
using OneMusic.WebApi.Controllers;

using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;//https gerekmesin
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience, // Dinleyici
        ValidIssuer = JwtTokenDefaults.ValidIssuer, // Yay�nc�
        ClockSkew = TimeSpan.Zero,//Token�n ba�lang�� noktas�n� s�f�rlama
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)), //kullan�c�n�n sayfay� a�mas� i�in sahip olmas� gereken key 16 karakter istiyor.
        ValidateLifetime = true, //Token�n ayakta kalma zaman�
        ValidateIssuerSigningKey = true,
    };
});

builder.Services.AddScoped<OneMusicContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IMusicRepository), typeof(MusicRepository));

builder.Services.AddApplicationService(builder.Configuration);

//builder.Services.AddMediatR(typeof(LoginController).Assembly);

builder.Services.AddControllers();
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

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
