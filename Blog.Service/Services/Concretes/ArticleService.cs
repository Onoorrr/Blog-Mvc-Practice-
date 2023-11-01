using Blog.Data.UnitofWorks;
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

        public ArticleService(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitofWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
