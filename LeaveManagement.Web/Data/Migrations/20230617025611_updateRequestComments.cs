using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371",
                column: "ConcurrencyStamp",
                value: "0f00b59c-5767-4488-8905-f017604fc383");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63",
                column: "ConcurrencyStamp",
                value: "5722dd4f-ba73-47eb-bc3e-173b8fdedc67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec4ba2ce-e0a8-4922-9722-9dd492c2a345", "AQAAAAEAACcQAAAAEF9ugOkYeJy4o28i8Z2L1A4k5nAvt1GqsmXbPTmenZ+/46iVyYf2fPliTf6Lshw7pg==", "2256135f-f90b-4adc-b1ad-f1f357fc3b54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf957eeb-1d60-4527-a395-9b035debcc6c", "AQAAAAEAACcQAAAAEG+xcy/nfZuNwKan8tYkzpmzhK1q1yp/aUf9y9zgWm6EBypraQI3M7wCDn/00mL5rQ==", "8452ced4-8ca2-428f-8108-af7f92460154" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
