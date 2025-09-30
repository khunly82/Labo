using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a71a1f-699e-4a01-a3b3-89354a01ef4f"),
                columns: new[] { "EncodedPassword", "Salt" },
                values: new object[] { new byte[] { 216, 81, 205, 156, 80, 59, 186, 52, 227, 93, 123, 98, 206, 183, 20, 192, 195, 78, 229, 246, 167, 130, 23, 97, 241, 204, 34, 246, 231, 212, 36, 105, 86, 170, 219, 115, 152, 117, 156, 120, 157, 122, 101, 227, 114, 249, 226, 58, 62, 163, 166, 38, 192, 186, 88, 183, 113, 222, 104, 168, 55, 80, 106, 242 }, new Guid("3c0c3980-6add-4847-8e37-7bece142faaf") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Elo", "Email", "EncodedPassword", "Gender", "IsDeleted", "Role", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("15ff3f68-c3af-4ced-81f5-969f5d746c87"), new DateTime(2000, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800, "r@yopmail.com", new byte[] { 93, 222, 83, 130, 205, 176, 110, 92, 144, 78, 138, 253, 60, 135, 72, 69, 100, 178, 172, 154, 48, 12, 110, 140, 159, 236, 35, 14, 154, 112, 183, 99, 60, 93, 146, 228, 3, 73, 92, 49, 144, 125, 226, 154, 196, 96, 95, 210, 215, 78, 61, 146, 22, 151, 233, 34, 10, 216, 156, 16, 34, 250, 21, 201 }, "Male", false, "Player", new Guid("16898dcd-6038-4344-b7e3-23898b157e39"), "Ringo" },
                    { new Guid("2649548b-ba8d-4f9b-b1ab-c58bc64a063b"), new DateTime(2000, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500, "j@yopmail.com", new byte[] { 119, 142, 138, 220, 155, 186, 153, 27, 143, 9, 248, 122, 252, 215, 129, 126, 85, 159, 235, 28, 78, 135, 89, 214, 196, 236, 21, 230, 136, 202, 70, 145, 243, 50, 97, 101, 196, 144, 174, 159, 198, 156, 183, 188, 128, 203, 224, 105, 145, 138, 137, 177, 199, 156, 91, 229, 154, 240, 103, 62, 156, 104, 77, 6 }, "Male", false, "Player", new Guid("79e2e604-b4a9-421b-8f35-710a0f14e8dd"), "John" },
                    { new Guid("34303638-fe61-4d76-83d3-d4ca8576542a"), new DateTime(2000, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800, "s@yopmail.com", new byte[] { 5, 246, 36, 183, 186, 15, 76, 148, 226, 145, 147, 22, 170, 136, 221, 165, 231, 66, 3, 46, 26, 2, 14, 35, 103, 203, 156, 85, 96, 110, 89, 113, 235, 106, 58, 69, 57, 101, 74, 219, 156, 171, 104, 134, 8, 21, 109, 184, 167, 224, 231, 66, 224, 209, 36, 135, 68, 153, 205, 2, 179, 78, 217, 147 }, "Female", false, "Player", new Guid("5d891228-ac0c-41b3-809b-541b1ff591e5"), "Sarah" },
                    { new Guid("4ecd086e-adb9-47b4-bbc7-f8c9cb7ff4be"), new DateTime(2005, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200, "b@yopmail.com", new byte[] { 101, 205, 157, 212, 89, 133, 137, 235, 238, 166, 92, 126, 29, 160, 95, 232, 183, 115, 169, 159, 220, 140, 49, 40, 234, 112, 204, 141, 24, 53, 242, 89, 238, 21, 141, 245, 21, 184, 74, 246, 71, 57, 216, 158, 213, 146, 37, 19, 41, 201, 2, 179, 224, 214, 83, 213, 184, 194, 62, 32, 139, 87, 138, 108 }, "Female", false, "Player", new Guid("c66f7354-9927-4a30-9dff-8b94fb01dc77"), "Brithney" },
                    { new Guid("f0ade1ac-efff-4c7b-80d3-f9491bac46cd"), new DateTime(2000, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800, "g@yopmail.com", new byte[] { 197, 11, 86, 65, 2, 100, 32, 169, 164, 91, 254, 205, 178, 94, 40, 221, 98, 9, 25, 65, 181, 35, 168, 190, 248, 200, 45, 19, 92, 202, 10, 206, 9, 217, 36, 222, 116, 135, 176, 190, 250, 86, 190, 99, 238, 48, 156, 88, 47, 104, 114, 195, 253, 122, 27, 3, 136, 1, 126, 148, 34, 133, 88, 17 }, "Male", false, "Player", new Guid("c9d63daf-61a8-4d96-b9d8-54f50826d25b"), "Georges" },
                    { new Guid("f50c3b7f-0530-4c20-ba0b-2fb97d446b04"), new DateTime(2000, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1800, "p@yopmail.com", new byte[] { 121, 34, 190, 140, 33, 24, 165, 49, 124, 183, 85, 27, 126, 83, 119, 23, 11, 221, 119, 237, 52, 153, 51, 176, 14, 171, 218, 180, 89, 174, 241, 125, 241, 124, 251, 136, 121, 180, 142, 12, 201, 141, 255, 36, 36, 201, 6, 215, 158, 209, 16, 121, 12, 50, 102, 144, 249, 223, 197, 255, 202, 40, 99, 144 }, "Male", false, "Player", new Guid("21e788cb-c68f-48d7-8b96-43e4140e7aa4"), "Paul" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15ff3f68-c3af-4ced-81f5-969f5d746c87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2649548b-ba8d-4f9b-b1ab-c58bc64a063b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34303638-fe61-4d76-83d3-d4ca8576542a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ecd086e-adb9-47b4-bbc7-f8c9cb7ff4be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0ade1ac-efff-4c7b-80d3-f9491bac46cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f50c3b7f-0530-4c20-ba0b-2fb97d446b04"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a71a1f-699e-4a01-a3b3-89354a01ef4f"),
                columns: new[] { "EncodedPassword", "Salt" },
                values: new object[] { new byte[] { 35, 244, 107, 248, 178, 148, 85, 23, 41, 19, 159, 3, 114, 192, 251, 216, 12, 190, 247, 218, 168, 247, 148, 186, 11, 56, 247, 117, 60, 59, 108, 167, 181, 181, 64, 227, 91, 55, 143, 118, 138, 67, 126, 216, 205, 219, 123, 77, 125, 68, 82, 140, 48, 221, 154, 228, 185, 233, 37, 73, 240, 14, 239, 205 }, new Guid("bc2b9d77-1b95-4120-ae12-117be700e245") });
        }
    }
}
