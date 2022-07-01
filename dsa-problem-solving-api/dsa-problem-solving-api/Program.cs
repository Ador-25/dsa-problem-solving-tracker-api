using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Data;
using dsa_problem_solving_api.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// For Entity Framework 
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProblemContextConnectionString"));
});
builder.Services.AddControllers();
<<<<<<< HEAD
builder.Services.AddScoped<IPlatformData, SqlPlatformData>();
=======
// builder.Services.AddSingleton<IPlatformData, SqlPlatformData>();
// builder.Services.AddSingleton<IProblemData, SqlProblemData>();
builder.Services.AddScoped<IGenericData<Platform>, SqlGenericPlatformData>();
builder.Services.AddScoped<IGenericData<Problem>, SqlGenericProblemData>();

>>>>>>> 0c35d9a7fd5d90b2cbd5ee4a5963417c63ed48c5

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

app.UseAuthorization();

app.MapControllers();

app.Run();
