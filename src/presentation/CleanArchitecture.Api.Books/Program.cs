var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
builder.Configuration.AddJsonFile($"settings/secret/secret.{app.Environment.EnvironmentName}.json", false, true);
builder.Configuration.AddJsonFile($"settings/config/config.{app.Environment.EnvironmentName}.json", false, true);


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
const int substring = -30;
Console.WriteLine();
Console.WriteLine($"{nameof(app.Environment.ApplicationName),substring} {app.Environment.ApplicationName}");
Console.WriteLine($"{nameof(app.Environment.ContentRootPath),substring} {app.Environment.ContentRootPath}");
Console.WriteLine($"{nameof(app.Environment.EnvironmentName),substring} {app.Environment.EnvironmentName}");
foreach (var item in app.Configuration.AsEnumerable())
{
    if (item.Key.StartsWith("SECRET_") || item.Key.StartsWith("CONFIG_"))
    {
        if (string.IsNullOrEmpty(item.Value))
        {
            throw new Exception($"{item.Key} has no valid value");
        }

        Console.WriteLine($"{item.Key,substring} {item.Value}");
    }
}
Console.WriteLine();

app.UseAuthorization();
app.MapControllers();
app.Run();