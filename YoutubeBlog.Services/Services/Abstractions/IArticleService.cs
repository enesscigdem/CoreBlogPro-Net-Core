using System;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Services.Services.Abstractions
{
	public interface IArticleService
	{
        Task<List<ArticleDto>> GetAllArticlesAsync();
    }
}

