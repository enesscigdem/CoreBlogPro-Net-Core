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

    public async Task<IActionResult> Index()
    {
        var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
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
}

