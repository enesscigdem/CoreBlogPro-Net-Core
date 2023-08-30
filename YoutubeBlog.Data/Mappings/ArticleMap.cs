using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum – İyi ve Kötünün Uç Sınırları\" eserindeki 1.30.32 sayılı paragrafında yer alır. Bu eser Rönesans döneminde etik teorileri üzerine bilimsel inceleme konusu haline gelmiştir. Lorem Ipsum 1500'lü yıllardan itibaren aşağıdaki formuyla standartlaşmıştır: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ViewCount = 15,
                CategoryId = Guid.Parse("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"),
                ImageId = Guid.Parse("2eff5f4b-13ae-4140-a98c-9df62488ce7e"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now
            },
        new Article
        {
            Id = Guid.NewGuid(),
            Title = "Visual Studio Deneme Makalesi 1",
            Content = "Lorem Ipsum, 500 yıl boyunca varlığını sürdürmekle kalmamış ve günümüzde elektronik yazı tipinin gerektiği birçok konuda hazır bir araç olarak kullanılmaya başlanmıştır. Lipsum 1960'larda içinde Lorem Ipsum paragraflarının bulunduğu letrasetlerin piyasaya çıkması ve 1990'larda Lorem Ipsum versiyonlarını içeren Aldus Pagemaker gibi programlarla beraber yaygın hale gelmiştir.\n",
            ViewCount = 32,
            CategoryId = Guid.Parse("9614dd78-111c-42ec-8f02-379368493c0a"),
            ImageId = Guid.Parse("87595b6d-03fd-4807-964d-3e3fb11c0bd4"),
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.Now
        });
        }
    }
}

