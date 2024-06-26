using Microsoft.EntityFrameworkCore;
using WepApiIndex.Models.ContextClass;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDistributedMemoryCache();
builder.Services.AddDbContextPool<MyContext>(x =>x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
builder.Services.AddControllers();
builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromDays(1);
    x.Cookie.HttpOnly = true;
    x.Cookie.IsEssential = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseSession();
app.MapControllers();

app.Run();
