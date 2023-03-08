var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET TIME IN FORMAT UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();
//test CI-CI IN AZURE
