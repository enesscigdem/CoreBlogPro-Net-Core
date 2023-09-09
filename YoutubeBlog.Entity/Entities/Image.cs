using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Image : EntityBase
    {
        public Image()
        {

        }
        public Image(string fileName, string fileType)
        {
            FileName=fileName;
            FileType=fileType;
        }
        public Guid Id { get; set; }
		public string FileName { get; set; }
		public string FileType { get; set; }
		public ICollection<Article> Articles { get; set; }
		public ICollection<AppUser> Users { get; set; }
    }
}

