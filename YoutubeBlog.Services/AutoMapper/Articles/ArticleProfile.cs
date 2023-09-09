using System;
using AutoMapper;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Services.AutoMapper.Articles
{
	public class ArticleProfile : Profile
	{
		public ArticleProfile()
		{
			CreateMap<ArticleDto, Article>().ReverseMap();
			CreateMap<ArticleUpdateDto, Article>().ReverseMap();
			CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
        }
	}
}

