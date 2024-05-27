using Microsoft.OpenApi.Models;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Implementation;
using Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IJewelryService, JewelryService>();
builder.Services.AddScoped<IJewelryRepository, JewelryRepository>();
builder.Services.AddScoped<IWarrantyService, WarrantyService>();
builder.Services.AddScoped<IWarrantyRepository, WarrantyRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBillService, BillService>();
builder.Services.AddScoped<IBillRepository, BillRepository>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IPromotionRepository, PromotionRepository>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "JSSATS", Version = "v1" });
}); 
var app = builder.Build();

#region Swagger
app.UseSwagger(options => { options.RouteTemplate = "{documentName}/swagger.json"; });
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/v1/swagger.json", "JSSATS-API-V1");
    c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
    c.RoutePrefix = string.Empty;
});
# endregion
app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

app.Run();