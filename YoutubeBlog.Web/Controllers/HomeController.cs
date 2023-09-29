using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Services.Services.Abstractions;
using YoutubeBlog.Web.Models;

namespace YoutubeBlog.Web.Controllers;

public class HomeController : Controller
{
    private readonly IArticleService articleService;

    public HomeController(IArticleService articleService)
    {
        this.articleService = articleService;
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
        var article = await articleService.GetArticleWithCategoryNonDeletedAsync(id);
        return View(article);
    }
}

