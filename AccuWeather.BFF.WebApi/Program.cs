using AccuWeather.BFF.Agents.Mapping;
using AccuWeather.BFF.Models.Settings;
using AccuWeather.BFF.WebApi.DI;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.AzureKeyVault;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(InfraDataPersistenceProfile));
builder.Configuration
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddAzureKeyVault(
        builder.Configuration["KeyVaultClientDNS"],
        builder.Configuration["KeyVaultClientId"],
        builder.Configuration["KeyVaultClientSecret"],
        new DefaultKeyVaultSecretManager());

builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("Settings"));
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new IocModule()));

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
