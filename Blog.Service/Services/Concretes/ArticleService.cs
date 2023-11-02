using AutoMapper;
using Blog.Data.UnitofWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concretes
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitofWork unitofWork;
		private readonly IMapper mapper;

		public ArticleService(IUnitofWork unitofWork, IMapper mapper)
		{
			this.unitofWork = unitofWork;
			this.mapper = mapper;
		}
		public async Task<List<ArticleDto>> GetAllArticlesAsync()
		{

			var articles = await unitofWork.GetRepository<Article>().GetAllAsync();
			var map = mapper.Map<List<ArticleDto>>(articles);
			return map;
		}
	}
}
