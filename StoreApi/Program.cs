using System.Text;
using StoreApi.Extensions;

Console.OutputEncoding = Encoding.Unicode;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddPostgreSqlDbContext(builder.Configuration);
builder.Services.AddPostgreSqlIdentityContext();
builder.Services.AddConfigureIdentityOptions();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

await app.Services.InitializeRoleAsync();

app.Run();