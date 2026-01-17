using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Blogaj.Business.Abstract;
using Blogaj.Business.Concrete;
using Blogaj.DataAccess.Abstract;
using Blogaj.DataAccess.Context;
using Blogaj.DataAccess.Repositories;
using System.Reflection;
using Blogaj.API.Mapping;

var builder = WebApplication.CreateBuilder(args);

//                                  Mapping

// AutoMapper'da AddAutoMapper birden fazla overload'a sahiptir.
// Biz sadece Assembly gönderince, C# yanlýþ overload'u seçmeye çalýþýyordu
// ve "Action<IMapperConfigurationExpression>" beklediði için hata alýyorduk.
//
// cfg => { }  : Boþ bir configuration action vererek
// doðru overload'un seçilmesini saðlýyoruz.
// typeof(AboutMapping).Assembly : Profile class'larýnýn bulunduðu assembly.
// builder.Services.AddAutoMapper(typeof(AboutMapping).Assembly);
// Bu yüzden bu yazým çalýþýr, diðeri çalýþmaz.

builder.Services.AddAutoMapper(cfg => { }, AppDomain.CurrentDomain.GetAssemblies());


// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BlogajContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlConnection")
    )
);

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
