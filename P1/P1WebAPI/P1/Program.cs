using P1;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello");

//string connectionString ="Server=tcp:240401netnp.database.windows.net,1433;Initial Catalog=FreeDatabaseNP;Persist Security Info=False;User ID=training-admin;Password="revtrain1!";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

//var optionsBuilder = new DbContextOptionsBuilder<FreeDatabaseNpContext>();
//optionsBuilder.UseSqlServer(["dbconnectionstring"]);

//FreeDatabaseNpContext context = new FreeDatabaseNpContext(optionsBuilder.Options);





 var builder = WebApplication.CreateBuilder(args);


// // Add services to the container.
 builder.Services.AddDbContext<GunplaDbContext>(option => option.UseSqlServer(builder.Configuration["dbconnsctionstring"]));
builder.Services.AddScoped<GunplaRepository>();
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

 app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }



//http://localhost:5058/swagger/v1/swagger.json