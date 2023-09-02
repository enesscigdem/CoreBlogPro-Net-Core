using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repository.Abstractions;
using YoutubeBlog.Data.Repository.Concretes;
using YoutubeBlog.Data.UnitOfWorks;

namespace YoutubeBlog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            // IRepository ve Repository sınıfı için ben IRepository sınıfını çağırdığımda bana repository nesnesi oluşturması gerektiğini belirteceğim bir scope ekliyoruz. Scope'un amacı bu. IRepository'e bir istek yolladığımda repository'i dönmüş olacak.
            // Bu da dependency injection oluyor. Bunu normalde program.cs de yazmamız lazımdı ama biz extension method yazdığımız için normal program.cs dosyamızı kirletmeden buraya yazıyoruz.
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
 
