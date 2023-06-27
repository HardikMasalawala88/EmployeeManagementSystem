using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class empSalary_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32108ee4-a935-4ca2-bc32-07befeaac7e8");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "EmpSalaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "EmpSalaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ConveyanceAllowance",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "EmpSalaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "EmpSalaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "EPF",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "GrossSalary",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HRA",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "LOPDays",
                table: "EmpSalaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MedicalAllowance",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PaidDays",
                table: "EmpSalaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ProfessionalTax",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TotalWorkingDays",
                table: "EmpSalaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0f7cff8-9762-484f-8e30-b918b711aff9", "3", "Employee", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53107f0-2927-4178-b86a-64faec272f22", "AQAAAAEAACcQAAAAEMAd+Rk5dtukJ5+pNTkrF7gGuhkDiV8F+Cc3b7eTkdGyOPlJPRh8EXHU+0z/4AsLNA==", "27935cd1-b57f-4e43-b0b2-0ae22a45a476" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "867d758a-7a67-465f-9eab-3a2b8e58970d", "AQAAAAEAACcQAAAAEEyMZ/el91nX4oUV/DJ38XnC4KENEVNDCIJg0PjbC3PP77VJksDld/NmtAQWORalhQ==", "d500f89a-d803-4fda-b4f5-abe07562e45a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f7cff8-9762-484f-8e30-b918b711aff9");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "ConveyanceAllowance",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "EPF",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "GrossSalary",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "HRA",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "LOPDays",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "MedicalAllowance",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "PaidDays",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "ProfessionalTax",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "TotalWorkingDays",
                table: "EmpSalaries");

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
        }
    }
}
