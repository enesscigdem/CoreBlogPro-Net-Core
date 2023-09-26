using System;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repository.Abstractions;
using YoutubeBlog.Data.Repository.Concretes;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Services.FluentValidations;
using YoutubeBlog.Services.Helpers.Images;
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
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IIMageHelper, ImageHelper>();
            services.AddScoped<IDashboardService, DashboardService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(assembly);


            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture=new System.Globalization.CultureInfo("tr");
            });

            return services;
        }
    }
}

