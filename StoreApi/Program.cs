using System.Text;
using StoreApi.Extensions;

Console.OutputEncoding = Encoding.Unicode;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenCustomConfig();
builder.Services.AddControllers();

builder.Services.AddPostgreSqlDbContext(builder.Configuration);
builder.Services.AddPostgreSqlIdentityContext();
builder.Services.AddConfigureIdentityOptions();
builder.Services.AddJwtTokenGenerator();
builder.Services.AddShoppingCartService();
builder.Services.AddOrderService();
builder.Services.AddAuthenticationConfig(builder.Configuration);
builder.Services.AddPaymentService();
builder.Services.AddCors();
builder.Services.AddFileStorageService(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.UseCors(op =>
{
    op.AllowAnyHeader();
    op.AllowAnyMethod();
    op.AllowAnyOrigin();
    op.WithExposedHeaders("*");
});

app.UseAuthentication();
app.UseAuthorization();

await app.Services.InitializeRoleAsync();

app.Run();