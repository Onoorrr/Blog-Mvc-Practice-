using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"), "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6130), null, null, false, null, null, "Test2" },
                    { new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"), "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6125), null, null, false, null, null, "Test" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1df68064-f397-4711-a73d-66fe21cd4060"), "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6457), null, null, "Test", "jpg", false, null, null },
                    { new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"), "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6461), null, null, "Test2", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("53a5d1e7-0fcf-4719-8cbd-8268228a81da"), new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5762), null, null, new Guid("1df68064-f397-4711-a73d-66fe21cd4060"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("90bd1df0-5562-4c98-8eed-210839d1c6e1"), new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5772), null, null, new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"), false, null, null, "Asp.net Core Deneme Makalesi 2", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("53a5d1e7-0fcf-4719-8cbd-8268228a81da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("90bd1df0-5562-4c98-8eed-210839d1c6e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1df68064-f397-4711-a73d-66fe21cd4060"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
