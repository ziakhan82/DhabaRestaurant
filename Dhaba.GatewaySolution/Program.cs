using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddAuthentication("Bearer")
               .AddJwtBearer("Bearer", options =>
               {

                   options.Authority = "https://localhost:44319/";
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateAudience = false
                   };

               });
builder.Services.AddOcelot();
app.MapGet("/", () => "Hello World!");

app.Run();
await app.UseOcelot();
