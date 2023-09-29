using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Services.Services.Abstractions;
using YoutubeBlog.Web.Models;

namespace YoutubeBlog.Web.Controllers;

public class HomeController : Controller
{
    private readonly IArticleService articleService;
    private readonly IHttpContextAccessor httpContextAccessor;
    private readonly IUnitOfWork unitOfWork;

    public HomeController(IArticleService articleService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
    {
        this.articleService = articleService;
        this.httpContextAccessor = httpContextAccessor;
        this.unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
    {
        var articles = await articleService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);
        return View(articles);
    }
    [HttpGet]
    public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
    {
        var articles = await articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
        return View(articles);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public async Task<IActionResult> Detail(Guid id)
    {
        var ipAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        var articleVisitors = await unitOfWork.GetRepository<ArticleVisitor>().GetAllAsync(null, x => x.Visitor, y => y.Article);
        var article = await unitOfWork.GetRepository<Article>().GetAsync(x => x.Id == id);

        var result = await articleService.GetArticleWithCategoryNonDeletedAsync(id);
        var visitor = await unitOfWork.GetRepository<Visitor>().GetAsync(x => x.IpAdress == ipAddress);
        var addArticleVisitors = new ArticleVisitor(article.Id, visitor.Id);
        if (articleVisitors.Any(x => x.VisitorId == addArticleVisitors.VisitorId && x.ArticleId == addArticleVisitors.ArticleId))
            return View(result);
        else
        {
            await unitOfWork.GetRepository<ArticleVisitor>().AddAsync(addArticleVisitors);
            article.ViewCount += 1;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();
        }
        return View(result);
    }
}

