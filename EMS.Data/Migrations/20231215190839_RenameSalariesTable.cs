using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class RenameSalariesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_CreatedbyId",
                table: "EmpSalaries");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpSalaries_AspNetUsers_RequestingEmpId",
                table: "EmpSalaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpSalaries",
                table: "EmpSalaries");

            migrationBuilder.RenameTable(
                name: "EmpSalaries",
                newName: "Salaries");

            migrationBuilder.RenameIndex(
                name: "IX_EmpSalaries_RequestingEmpId",
                table: "Salaries",
                newName: "IX_Salaries_RequestingEmpId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpSalaries_CreatedbyId",
                table: "Salaries",
                newName: "IX_Salaries_CreatedbyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fc3e9b8-c094-40d2-8951-10527afdfb5a", "AQAAAAEAACcQAAAAEKPYqaJeOxPonHzHzg1E5BGU1uoR2Ph0pKe/AnBCD5HcMDDNXYZqwybPP0DSJmg6rg==", "507ab1ae-a2fd-42bb-a847-3c86e00d0f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c5bab40-ed58-424a-ad57-689e7a409e4b", "AQAAAAEAACcQAAAAECsPAtC4LyTEqBdUvE7ArTCAuwI4vFI6YOFMbimmeT3LQEfu6BfyaMPMmjdjpQOK1Q==", "828b2ef6-1ab0-4c73-875f-bf604a02e3bf" });

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_AspNetUsers_CreatedbyId",
                table: "Salaries",
                column: "CreatedbyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_AspNetUsers_RequestingEmpId",
                table: "Salaries",
                column: "RequestingEmpId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_AspNetUsers_CreatedbyId",
                table: "Salaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_AspNetUsers_RequestingEmpId",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "EmpSalaries");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_RequestingEmpId",
                table: "EmpSalaries",
                newName: "IX_EmpSalaries_RequestingEmpId");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_CreatedbyId",
                table: "EmpSalaries",
                newName: "IX_EmpSalaries_CreatedbyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpSalaries",
                table: "EmpSalaries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de5c723a-3a14-43e8-911d-dbf680079e0d", "AQAAAAEAACcQAAAAEMdILKTzAOh9wWQrHdYsvOJOQqIvZB01B1oNvcH0aRAWVJqSqkIE2FflZe4mx24IWg==", "eab28153-ecf5-4b02-95c3-7017c2a7c48a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f657ff9d-1149-4a45-9ad3-f103ede78d17", "AQAAAAEAACcQAAAAEDSF2JZgzpHm18nAPEFpYmLHy75iwMDh+cxURMMrVV00v2LACVwyW7drQvNelDPB2Q==", "279d2efd-479e-45cd-a43e-706bbb34222d" });

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
    }
}
