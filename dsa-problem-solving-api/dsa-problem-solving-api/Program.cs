using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Data;
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
builder.Services.AddSingleton<IPlatformData, SqlPlatformData>();
builder.Services.AddSingleton<IProblemData, SqlProblemData>();

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
