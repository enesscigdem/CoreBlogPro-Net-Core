using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("227dc141-c829-4f93-b410-cb325d6405e6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97be9323-86cc-42be-8206-970c4b741440"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("09ca6853-ef03-4295-92c5-c183ab4a10b8"), new Guid("9614dd78-111c-42ec-8f02-379368493c0a"), "Lorem Ipsum, 500 yıl boyunca varlığını sürdürmekle kalmamış ve günümüzde elektronik yazı tipinin gerektiği birçok konuda hazır bir araç olarak kullanılmaya başlanmıştır. Lipsum 1960'larda içinde Lorem Ipsum paragraflarının bulunduğu letrasetlerin piyasaya çıkması ve 1990'larda Lorem Ipsum versiyonlarını içeren Aldus Pagemaker gibi programlarla beraber yaygın hale gelmiştir.\n", "Admin Test", new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7790), null, null, new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"), false, null, null, "Visual Studio Deneme Makalesi 1", 32 },
                    { new Guid("4bd61593-6c22-40dd-b379-241cbf0627d1"), new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"), "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum – İyi ve Kötünün Uç Sınırları\" eserindeki 1.30.32 sayılı paragrafında yer alır. Bu eser Rönesans döneminde etik teorileri üzerine bilimsel inceleme konusu haline gelmiştir. Lorem Ipsum 1500'lü yıllardan itibaren aşağıdaki formuyla standartlaşmıştır: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin Test", new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7770), null, null, new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9614dd78-111c-42ec-8f02-379368493c0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 30, 20, 29, 35, 38, DateTimeKind.Local).AddTicks(7990));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("09ca6853-ef03-4295-92c5-c183ab4a10b8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4bd61593-6c22-40dd-b379-241cbf0627d1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("227dc141-c829-4f93-b410-cb325d6405e6"), new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"), "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum – İyi ve Kötünün Uç Sınırları\" eserindeki 1.30.32 sayılı paragrafında yer alır. Bu eser Rönesans döneminde etik teorileri üzerine bilimsel inceleme konusu haline gelmiştir. Lorem Ipsum 1500'lü yıllardan itibaren aşağıdaki formuyla standartlaşmıştır: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1230), null, null, new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("97be9323-86cc-42be-8206-970c4b741440"), new Guid("9614dd78-111c-42ec-8f02-379368493c0a"), "Lorem Ipsum, 500 yıl boyunca varlığını sürdürmekle kalmamış ve günümüzde elektronik yazı tipinin gerektiği birçok konuda hazır bir araç olarak kullanılmaya başlanmıştır. Lipsum 1960'larda içinde Lorem Ipsum paragraflarının bulunduğu letrasetlerin piyasaya çıkması ve 1990'larda Lorem Ipsum versiyonlarını içeren Aldus Pagemaker gibi programlarla beraber yaygın hale gelmiştir.\n", "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1250), null, null, new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"), false, null, null, "Visual Studio Deneme Makalesi 1", 32 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9614dd78-111c-42ec-8f02-379368493c0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"),
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1430));
        }
    }
}
