using GameProAppFanAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllers();
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default", "{Controller=Home}/{Action=Porno}/{id?}");

app.Run();
