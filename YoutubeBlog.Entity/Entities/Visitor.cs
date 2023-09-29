using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Visitor : IEntityBase
    {
        public Visitor()
        {
            
        }
        public Visitor(string ipAdress, string userAgent)
        {
            IpAdress = ipAdress;
            UserAgent = userAgent;
        }
        public int Id { get; set; }
        public string IpAdress { get; set; }
        public string UserAgent { get; set; } // web tarayıcısından mı, mobil tarayıcıdan mı girmiş bilgisini buradan alıyoruz.
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }
    }
}
