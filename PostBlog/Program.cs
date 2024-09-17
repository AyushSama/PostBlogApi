using DataHelper.Entities.EnumFields;
using Microsoft.EntityFrameworkCore;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Application.BusinessServices;
using PostBlog.Core;
using PostBlog.Data.EFData.Interfaces;
using PostBlog.Data.EFData.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDbContextPool<InboxContext>(options =>
    options.UseSqlServer("server=172.16.1.90;uid=TTA2024;pwd=Rizvi@2024;database=RizviTTA;Min Pool Size=;Max Pool Size=500;TrustServerCertificate=True;MultipleActiveResultSets=True;Command timeout=500", sqloptions =>
    {
        sqloptions.CommandTimeout((int)TimeoutValues.ThreeMinutes);
    }));

builder.Services.AddScoped<IUsersAyushService, UsersAyushService>();
builder.Services.AddScoped<IUsersAyushRepo, UsersAyushRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
