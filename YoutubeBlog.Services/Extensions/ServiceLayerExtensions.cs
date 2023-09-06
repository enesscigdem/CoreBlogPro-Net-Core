using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repository.Abstractions;
using YoutubeBlog.Data.Repository.Concretes;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Services.Services.Abstractions;
using YoutubeBlog.Services.Services.Concrete;

namespace YoutubeBlog.Services.Extensions
{
	public static class ServiceLayerExtensions
	{
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}

