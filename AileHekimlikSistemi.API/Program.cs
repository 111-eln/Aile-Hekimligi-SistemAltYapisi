using AileHekimlikSistemi.Core.Repositories;
using AileHekimlikSistemi.Core.Services;
using AileHekimlikSistemi.Core.UnitOfWorks;
using AileHekimlikSistemi.Repository;
using AileHekimlikSistemi.Repository.Repositories;
using AileHekimlikSistemi.Repository.UnitOfWorks;
using AileHekimlikSistemi.Service;
using AileHekimlikSistemi.Service.Mapping;
using AileHekimlikSistemi.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWorks, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IHospitalService, HospitalService>();
//builder.Services.AddControllers()
//    .AddFluentValidation(x =>
//    {
//        x.RegisterValidatorsFromAssemblyContaining<HospitalDtoValidator>();
//        x.RegisterValidatorsFromAssemblyContaining<UDoctorDtoValidator>();
//        x.RegisterValidatorsFromAssemblyContaining<PatientDtoValidator>();
//    });

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

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

