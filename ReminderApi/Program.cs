var builder = WebApplication.CreateBuilder(args);

// ×ÒÅÍÈÅ ÏÎĞÒÀ ÈÇ ÎÊĞÓÆÅÍÈß (êàê òğåáóşò îáëàêà)
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

// Fix startup for Amvera

// Commit test for Amvera deployment
