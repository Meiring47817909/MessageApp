using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod() // Lambda expression
    .WithOrigins("http://localhost:4200", "https://localhost:4200"));

app.UseAuthentication(); // First authenticate the user before you can authorise them
app.UseAuthorization(); // Add authentication and authorisation middleware

app.MapControllers();

app.Run();
