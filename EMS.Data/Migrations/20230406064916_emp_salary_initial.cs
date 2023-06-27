using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class emp_salary_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_CreatedbyId",
                table: "EmpSalaries");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_RequestingEmpId",
                table: "EmpSalaries");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daab8c11-d299-4fe9-b41b-9102f04ef93b");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmpId",
                table: "EmpSalaries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedbyId",
                table: "EmpSalaries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
                name: "FK_EmpSalaries_AspNetUsers_CreatedbyId",
                table: "EmpSalaries",
                column: "CreatedbyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_RequestingEmpId",
                table: "EmpSalaries",
                column: "RequestingEmpId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_CreatedbyId",
                table: "EmpSalaries");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_RequestingEmpId",
                table: "EmpSalaries");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f7cff8-9762-484f-8e30-b918b711aff9");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmpId",
                table: "EmpSalaries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedbyId",
                table: "EmpSalaries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
                name: "FK_EmpSalaries_AspNetUsers_CreatedbyId",
                table: "EmpSalaries",
                column: "CreatedbyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_RequestingEmpId",
                table: "EmpSalaries",
                column: "RequestingEmpId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
