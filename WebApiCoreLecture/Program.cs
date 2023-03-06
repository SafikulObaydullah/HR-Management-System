using Microsoft.EntityFrameworkCore;
using OrderStore.Domain.Interfaces;
using System.Security.Cryptography;
using WebApiCoreLecture.Model;
using WebApiCoreLecture.Service.EmployeeRepo;
using WebApiCoreLecture.Service.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EmployeeContext>(op =>
{
   op.UseSqlServer(builder.Configuration.GetConnectionString("ConEmp"));
});
builder.Services.AddCors(x => x.AddPolicy("MyPolicy", builder =>
{
   builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddTransient<IEmployeeBasicInformation, EmployeeBasicInformation>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
