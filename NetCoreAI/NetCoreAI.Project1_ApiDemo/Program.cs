using Microsoft.EntityFrameworkCore;
using NetCoreAI.Project1_ApiDemo.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApiContext>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();


app.UseHttpsRedirection();

app.UseAuthorization();



app.Run();


