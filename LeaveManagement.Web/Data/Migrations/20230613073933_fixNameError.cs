using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class fixNameError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "period",
                table: "LeaveAllocations",
                newName: "Period");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "40f1e1b5-778e-49ab-bcd1-4312b23aae72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "50f60cac-04a2-4b00-89c4-a535f2c7da03");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "423751b0-1af0-4e6c-8d2d-1d23b5fc057b", "AQAAAAEAACcQAAAAEAkAKYc8fjFL7/bV8tYbMRjbe/4V5Gpj9vVunlhmycyY8Hb38qBAUR7YsVW93Nle5A==", "7add291b-0fbd-44a7-b655-b2c040cee984" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6844fa79-0b29-4ab8-9d28-d72831c9ca88", "AQAAAAEAACcQAAAAEE/DFUWjkM2QoNsSInvHa7oMU3MtFwTgTEF9rLvzpxgD/sz+WoR0vT5Jxvl5AQFX6g==", "5da5b3d7-d6c9-42f8-920f-434d7bdd5993" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Period",
                table: "LeaveAllocations",
                newName: "period");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "421ccc26-6798-49f1-ac2f-42f09b28b3b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "14ef4077-09b5-4ec7-8da8-f7916f14d757");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adcc91b4-876e-42bf-810b-36faee1450d7", "AQAAAAEAACcQAAAAEIKn79N8/icxNc2aPuivZpbZnQ7lrFDBfOjXm8wWhr4qMlsQyv3TrxM53sabIyphMQ==", "99670f83-69ab-4e8c-bf9e-b2d1a1ad697f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "332ddbc5-605c-40e3-a99b-2e0c70659ac0", "AQAAAAEAACcQAAAAEIwVg+PjbfYnAbQm5wTIkOy7s7obgMv+qggmpSoQr0rWNlR3Zfm9B2tBXepg2dwBbA==", "5e2db0ff-4fb3-4bfc-8436-36137b93b274" });
        }
    }
}
