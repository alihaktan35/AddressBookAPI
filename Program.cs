var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// Swagger'ı her zaman aktif et (development ve production'da)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Address Book API V1");
    c.RoutePrefix = "swagger"; // swagger/ path'ini kullan
});

app.UseCors("AllowAll");

// HTTPS redirection'ı kaldıralım (local'de sorun çıkarıyor)
// app.UseHttpsRedirection(); // Bu satırı kaldır veya comment out yap

app.UseAuthorization();
app.MapControllers();

app.Run();