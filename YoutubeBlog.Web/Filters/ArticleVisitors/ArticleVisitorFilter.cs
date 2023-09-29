using Microsoft.AspNetCore.Mvc.Filters;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Web.Filters.ArticleVisitors
{
    public class ArticleVisitorFilter : IAsyncActionFilter
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleVisitorFilter(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            List<Visitor> visitors = unitOfWork.GetRepository<Visitor>().GetAllAsync().Result;
            string getIp = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            string getUserAgent = context.HttpContext.Request.Headers["User-Agent"];
            Visitor visitor = new(getIp,getUserAgent);

            if (visitors.Any(x => x.IpAdress == visitor.IpAdress))
                return next();
            else
            {
                unitOfWork.GetRepository<Visitor>().AddAsync(visitor);
                unitOfWork.Save();
            }
            return next();
        }
    }
}
