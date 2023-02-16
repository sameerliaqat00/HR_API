using HR_API;
using HR_API.Data;
using HR_API.Repository;
using HR_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<ICompanyProfileRepository, CompanyProfileRepository>();
builder.Services.AddScoped<ICompanyTypeRepository, CompanyTypeRepository>();
builder.Services.AddScoped<ISalaryMethodRepository, SalaryMethodRepository>();
builder.Services.AddScoped<ILoanEligibleMonthRepository, LoanEligibleRepository>();
builder.Services.AddScoped<IRegularizedPeriodRepository, RegularizedPeriodRepository>();
builder.Services.AddScoped<IWorkLocationRepository, WorkLocationRepository>();

builder.Services.AddControllers(option =>
{
    option.ReturnHttpNotAcceptable=true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

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
