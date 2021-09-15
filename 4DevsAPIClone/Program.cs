using _4DevsAPIClone.Services;
using _4DevsAPIClone.Services.Interfaces;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "_4DevsAPIClone", Version = "v1" });
});

builder.Services.AddMvc();
builder.Services.AddTransient<ILegalPersonServices, LegalPersonServices>();
builder.Services.AddTransient<IPhysicalPersonServices, PhysicalPersonServices>();
builder.Services.AddTransient<IAdressServices, AdressServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "_4DevsAPIClone v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
