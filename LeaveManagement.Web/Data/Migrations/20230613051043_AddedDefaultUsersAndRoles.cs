using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371", "5c99a26e-4abb-493d-89da-1556a939f326", "Administrator", "ADMINISTRATOR" },
                    { "8538AE88-5776-412C-A021-AEB9A18A6C63", "11d74201-71bd-49c4-9cbe-bc879a03306f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04a5aa24-6df5-43f2-969a-77487b583f3a", 0, "61b46264-2763-48b2-b188-2081fa16a04c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEIq+S3RyFrvVRhOHXVtp4t1DJD2n98KwQ2PEzvzT/Pzs3blbbQ88CfEgm7P2+vXcHQ==", null, false, "ca9328d9-5716-421e-84d4-f930f264f7f4", null, false, null },
                    { "CDC8CC71-5228-45F8-B077-8015BCC612E0", 0, "c9530b77-4e35-4d6b-a119-9743348625db", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEDmd1rr6v9Cv46rrk+pFVXU48Lz6A6lIkmckccRjlnw0Eq70zlXA58IosWO/KWvZ7w==", null, false, "946c72d8-d026-40cb-9796-37377d0ec995", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371", "04a5aa24-6df5-43f2-969a-77487b583f3a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8538AE88-5776-412C-A021-AEB9A18A6C63", "CDC8CC71-5228-45F8-B077-8015BCC612E0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371", "04a5aa24-6df5-43f2-969a-77487b583f3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8538AE88-5776-412C-A021-AEB9A18A6C63", "CDC8CC71-5228-45F8-B077-8015BCC612E0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60F0F1C3-449A-4FE0-8E0D-28D8EA6B6371");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8538AE88-5776-412C-A021-AEB9A18A6C63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a5aa24-6df5-43f2-969a-77487b583f3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CDC8CC71-5228-45F8-B077-8015BCC612E0");
        }
    }
}
