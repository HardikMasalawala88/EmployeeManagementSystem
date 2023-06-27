using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class LeaveRequest_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4ee0a0f-5e0d-477f-b3cf-870d9a8913ed");

            migrationBuilder.CreateTable(
                name: "RegisterViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterViewModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71da9c87-340f-4e3b-ad71-d7f9602b7c57", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab8649be-e198-4d25-89ff-9b64112eca62", "AQAAAAEAACcQAAAAEJvSu+R78hV8e+B+mrq3xDgwmALFBMe+maflvvp3rgol6urdv9aIe2gy8z97KER2ag==", "32d18d2c-3a87-45d3-8cb3-25fb52d59755" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a26a0c8-b1be-4ff5-b0d9-2b16e70f2e2c", "AQAAAAEAACcQAAAAEOh8TnznjJoM8d/OkacBvKVYVlurMO2T7PjEymLnmI6kXCBwMBooKzFNZYMSBc564A==", "31bfb714-ed0b-46fd-bbc3-3dc5b4974a67" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "RegisterViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "RegisterViewModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71da9c87-340f-4e3b-ad71-d7f9602b7c57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4ee0a0f-5e0d-477f-b3cf-870d9a8913ed", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a0e2549-2179-4a83-846a-8f376623c008", "AQAAAAEAACcQAAAAEIVjC17pRnUF41mH2NHzbLdrBuJ7twBN6jPu6pT8SfcqQAnRqH8ioJkIauyGd0ZliA==", "c796df6b-529a-462f-a93d-885d36367c13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1fe635-f31c-4a0c-8c39-a6194e3ed9da", "AQAAAAEAACcQAAAAEL5WVu/7jUul1rHLF8ulOFWqBSpDKHer8EYl5gvv7TEQeHcui3Vhi99JjMeG9JWwZA==", "50f22b07-d40f-48c4-98b2-4d3168c48148" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
