using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ВКЛЮЧАЕМ SWAGGER ВСЕГДА (важно для Amvera)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Reminder API v1");
    c.RoutePrefix = "swagger"; // swagger доступен по /swagger
});

app.UseAuthorization();

// Контроллеры
app.MapControllers();

// РЕДИРЕКТ С КОРНЯ НА SWAGGER
app.MapGet("/", () => Results.Redirect("/swagger"));

// Запуск приложения
app.Run();