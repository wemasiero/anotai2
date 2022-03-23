using Anotai.Application.AutoMapper;
using Anotai.Data.Context;
using Anotai.IoC;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opt => 
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Template .NET Core",
        Version = "v1",
        Description = "ANOTAI API Models",
        Contact = new OpenApiContact
        {
            Name = "Wanderson Ermida",
            Email = "wemasiero@gmail.com"
        }
    })
);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSqlite<AppDbContext>(connectionString);
builder.Services.AddAutoMapper(typeof(AutoMapperSetup));
NativeInjector.RegisterServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();