using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriyId",
                table: "Articles");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"), "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1350), null, null, false, null, null, "Asp.Net Core" },
                    { new Guid("9614dd78-111c-42ec-8f02-379368493c0a"), "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1360), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"), "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1420), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"), "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1430), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("227dc141-c829-4f93-b410-cb325d6405e6"), new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"), "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum – İyi ve Kötünün Uç Sınırları\" eserindeki 1.30.32 sayılı paragrafında yer alır. Bu eser Rönesans döneminde etik teorileri üzerine bilimsel inceleme konusu haline gelmiştir. Lorem Ipsum 1500'lü yıllardan itibaren aşağıdaki formuyla standartlaşmıştır: Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1230), null, null, new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("97be9323-86cc-42be-8206-970c4b741440"), new Guid("9614dd78-111c-42ec-8f02-379368493c0a"), "Lorem Ipsum, 500 yıl boyunca varlığını sürdürmekle kalmamış ve günümüzde elektronik yazı tipinin gerektiği birçok konuda hazır bir araç olarak kullanılmaya başlanmıştır. Lipsum 1960'larda içinde Lorem Ipsum paragraflarının bulunduğu letrasetlerin piyasaya çıkması ve 1990'larda Lorem Ipsum versiyonlarını içeren Aldus Pagemaker gibi programlarla beraber yaygın hale gelmiştir.\n", "Admin Test", new DateTime(2023, 8, 29, 18, 44, 38, 208, DateTimeKind.Local).AddTicks(1250), null, null, new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"), false, null, null, "Visual Studio Deneme Makalesi 1", 32 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("227dc141-c829-4f93-b410-cb325d6405e6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97be9323-86cc-42be-8206-970c4b741440"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ced153f-93fb-4415-a5e8-2f97d6ae5d73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9614dd78-111c-42ec-8f02-379368493c0a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2eff5f4b-13ae-4140-a98c-9df62488ce7e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("87595b6d-03fd-4807-964d-3e3fb11c0bd4"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriyId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
