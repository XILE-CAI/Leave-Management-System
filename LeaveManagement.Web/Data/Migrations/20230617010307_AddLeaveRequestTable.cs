using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "be3b49a9-b5d8-4ce7-9dcf-39ef48486952");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "16beaf9a-0c9d-42c2-a657-a6a8250260e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01335036-c879-47de-91fe-ef0d6feff6be", "AQAAAAEAACcQAAAAEI1b4P3nz8ZkNdHirMOmi+XiG3i+HeHtTeCucYvOq/Qs4eDbDrn1THDfobcPiY9e8g==", "147542ee-ae75-4209-9c79-2d8dec28ab0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15f979c0-4994-4058-8129-2b9687442fb2", "AQAAAAEAACcQAAAAEKDdr1CXpTURTVCMHY9NUiItadIINPDes0AWOY5D8O1DST5Dui97nZnfBTPbO/+X4A==", "029ca99f-c0ce-4782-90db-287a65d4ec83" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
