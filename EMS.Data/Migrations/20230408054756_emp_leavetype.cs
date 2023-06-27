using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class emp_leavetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f7cff8-9762-484f-8e30-b918b711aff9");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32108ee4-a935-4ca2-bc32-07befeaac7e8", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7128eae-e5a5-42db-b455-d5f52728a3bf", "AQAAAAEAACcQAAAAEDC2NEEWsL7t7DlsVvJ/EBR1aYQA8RSE//YHwWltcHeNfttwU6+gBrgVHhDfuesFNA==", "628cddce-9bbe-4868-b5f6-522d92aa1390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b3d0ea0-3c56-441f-ae73-87583a5a377b", "AQAAAAEAACcQAAAAENeklXOyVwkQd4BBVKWHT7TqeiqrEkSGTO0+qBNQnsHtM1WWxrfz7DKOivPSriq0jg==", "aa55f8ba-3df5-4929-a805-461ea5fca8f2" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32108ee4-a935-4ca2-bc32-07befeaac7e8");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0f7cff8-9762-484f-8e30-b918b711aff9", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64223228-c70a-483f-bbdb-7082f4d503d1", "AQAAAAEAACcQAAAAEOZ3UOy/AGzubffVQ0UaHIFMzAtir4z6wwWxVG6S9ZrXKKfeLpv1zqvPsgJstmgF1g==", "a885145d-3732-4474-aea7-1f5ec6b8b33e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02eb0496-30d7-4b37-8650-bec7e4b8dde5", "AQAAAAEAACcQAAAAEH7oXP7ppfJu/NYOH/bhgMkdRgBQ+5JdfaZR7jV3ua/EZoeWBR+Kx5h5Gl7E2vDT3A==", "91bede64-3348-485a-b3d1-73eded4d8384" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
