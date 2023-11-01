using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Contollers
{
	[Area("Admin")] //Areanın dışında ki controllerla karışmaması için belirtmemiz gerekiyor.
	public class HomeController : Controller
	{
		private readonly IArticleService articleService;

		public HomeController(IArticleService articleService)
        {
			this.articleService = articleService;
		}
        public async Task<IActionResult> Index()
		{
			var articles = await articleService.GetAllArticlesAsync();
			return View(articles);
		}
	}
}
