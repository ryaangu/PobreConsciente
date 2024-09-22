using PobreConsciente.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add the dependencies.
builder.Services.AddApplicationDependency();
builder.Services.AddInfrastructureDependency(builder.Configuration.GetConnectionString("DefaultConnection"));

// Add the controllers.
builder.Services.AddControllers();

// Add the Swagger API.
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

app.MapControllers();

app.Run();