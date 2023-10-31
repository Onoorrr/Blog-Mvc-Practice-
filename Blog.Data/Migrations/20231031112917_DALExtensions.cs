using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("53a5d1e7-0fcf-4719-8cbd-8268228a81da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("90bd1df0-5562-4c98-8eed-210839d1c6e1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1c8e6cf0-26ba-4982-8474-0112bf957194"), new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(3671), null, null, new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"), false, null, null, "Asp.net Core Deneme Makalesi 2", 15 },
                    { new Guid("f5e0357a-5910-4a4b-a8bb-0ac0e88bdd0c"), new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(3663), null, null, new Guid("1df68064-f397-4711-a73d-66fe21cd4060"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1df68064-f397-4711-a73d-66fe21cd4060"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 14, 29, 16, 224, DateTimeKind.Local).AddTicks(4323));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1c8e6cf0-26ba-4982-8474-0112bf957194"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f5e0357a-5910-4a4b-a8bb-0ac0e88bdd0c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("53a5d1e7-0fcf-4719-8cbd-8268228a81da"), new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5762), null, null, new Guid("1df68064-f397-4711-a73d-66fe21cd4060"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("90bd1df0-5562-4c98-8eed-210839d1c6e1"), new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.", "Onur", new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5772), null, null, new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"), false, null, null, "Asp.net Core Deneme Makalesi 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1df68064-f397-4711-a73d-66fe21cd4060"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6461));
        }
    }
}
