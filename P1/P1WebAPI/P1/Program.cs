using P1;
using Microsoft.EntityFrameworkCore;
using Azure.Core.Pipeline;

Console.WriteLine("Hello");


//var optionsBuilder = new DbContextOptionsBuilder<FreeDatabaseNpContext>();
//optionsBuilder.UseSqlServer(["dbconnectionstring"]);

//FreeDatabaseNpContext context = new FreeDatabaseNpContext(optionsBuilder.Options);





 var builder = WebApplication.CreateBuilder(args);


// // Add services to the container.

var dbconnectionstring = builder.Configuration["ConnectionStrings:dbconncetionstring"];
 builder.Services.AddDbContext<GunplaDbContext>(option => option.UseSqlServer(dbconnectionstring));
builder.Services.AddScoped<IGunplaRepository,GunplaRepository>();
builder.Services.AddScoped<IGunplaService,GunplaService>();
builder.Services.AddControllers();

// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddSwaggerGen();

 var app = builder.Build();

// // Configure the HTTP request pipeline.
 if (app.Environment.IsDevelopment())
 {
     app.UseSwagger();
     app.UseSwaggerUI();
 }

 app.UseHttpsRedirection();


// app.MapGet("/all2", (GunplaRepository repo) => 
// {
//     return repo.GetAllModels();
// })
// .WithName("All Models")
// .WithOpenApi();


// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

app.MapControllers();
 app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }



//http://localhost:5058/swagger/v1/swagger.json