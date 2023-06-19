using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodtoLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b386856-4c02-4493-a1f4-a74a2963fdf8", "AQAAAAEAACcQAAAAEJarJxCyzXJ5GhpEQ7szIjpcu/VSVcW5tCESJ66830ex7C032X0amtoTLrOJD02QXA==", "1322a6d0-492b-4d3e-876b-a4f39728b297" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07c2e9f-b70e-4092-84de-7757c5751c25", "AQAAAAEAACcQAAAAENxGe2SUqvhSyRRzJ8ipbTgKuL5sW63jFi1kZcWSbjbrkDWOEno0GY15k5jT0QTP5w==", "2179c8fc-debf-4572-8c61-4c8c25f04355" });
        }
    }
}
