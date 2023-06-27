using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class leaveRequest_initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmpId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71da9c87-340f-4e3b-ad71-d7f9602b7c57");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmpId",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedById",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daab8c11-d299-4fe9-b41b-9102f04ef93b", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0f7821-86c0-4b1e-891f-29d2c4ca5476", "AQAAAAEAACcQAAAAEEkD+UfsuztYGhHgEUVi0aciKxbuNjtBqPSSg9mawfpd+9c4dUxoDSQkf+IifkcICA==", "610e3b44-1e01-4fe6-a44e-351ca04869fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fa1e353-a430-4699-8558-ab3df5834737", "AQAAAAEAACcQAAAAEChxtcH1Urx3KHR23eWThiZpJqNh+1/3hBRG8jny976YhuMC/wKKqv9MGqdROiQe9Q==", "63f6596d-769f-4d19-8679-ea4bffe831cc" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmpId",
                table: "LeaveRequests",
                column: "RequestingEmpId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "RegisterViewModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmpId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daab8c11-d299-4fe9-b41b-9102f04ef93b");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmpId",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedById",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmpId",
                table: "LeaveRequests",
                column: "RequestingEmpId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "RegisterViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
