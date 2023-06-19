using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "0b83d556-c05a-43dc-8062-58b2a157c853");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "0a003239-f08d-4cd9-a121-cc8a7f87c4e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4b386856-4c02-4493-a1f4-a74a2963fdf8", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEJarJxCyzXJ5GhpEQ7szIjpcu/VSVcW5tCESJ66830ex7C032X0amtoTLrOJD02QXA==", "1322a6d0-492b-4d3e-876b-a4f39728b297", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d07c2e9f-b70e-4092-84de-7757c5751c25", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAENxGe2SUqvhSyRRzJ8ipbTgKuL5sW63jFi1kZcWSbjbrkDWOEno0GY15k5jT0QTP5w==", "2179c8fc-debf-4572-8c61-4c8c25f04355", "User@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "5c99a26e-4abb-493d-89da-1556a939f326");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "11d74201-71bd-49c4-9cbe-bc879a03306f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "61b46264-2763-48b2-b188-2081fa16a04c", false, null, "AQAAAAEAACcQAAAAEIq+S3RyFrvVRhOHXVtp4t1DJD2n98KwQ2PEzvzT/Pzs3blbbQ88CfEgm7P2+vXcHQ==", "ca9328d9-5716-421e-84d4-f930f264f7f4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c9530b77-4e35-4d6b-a119-9743348625db", false, null, "AQAAAAEAACcQAAAAEDmd1rr6v9Cv46rrk+pFVXU48Lz6A6lIkmckccRjlnw0Eq70zlXA58IosWO/KWvZ7w==", "946c72d8-d026-40cb-9796-37377d0ec995", null });
        }
    }
}
