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
    options.UseSqlServer("Server=AyushSama\\SQLEXPRESS;Database=tta_dev;Trusted_Connection=True;TrustServerCertificate=True;", sqloptions =>
    {
        sqloptions.CommandTimeout((int)TimeoutValues.ThreeMinutes);
    }));


builder.Services.AddScoped<IPostsAyushService, PostsAyushService>();
builder.Services.AddScoped<IPostsAyushRepo,PostsAyushRepo>();

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
