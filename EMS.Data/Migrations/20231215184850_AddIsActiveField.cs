using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class AddIsActiveField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RegisterViewModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "LeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "LeaveAllocations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmpSalaries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d3d7f2-8022-4856-9714-e109394c51ee", true, "AQAAAAEAACcQAAAAELy+PD9NlN/mGUyf1EdgQS4zlDWhJA+lbGYwmL9lZlvTENOuv8Fw1FoP2fyPC1lrvA==", "dbb10e7a-352e-4fe2-bc1f-4efdfb1713a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e28c27a-e827-4774-a06d-1d563ddbb4e6", true, "AQAAAAEAACcQAAAAEBIVAdelUGoreKatmoRmLQM3p4aij4LUySI6xz6U0e3ZwDWGT1b0IkRFVN7n2q7pPA==", "9ef1f074-a708-412a-9c74-b9fe9b64dcba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RegisterViewModel");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmpSalaries");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10514fb3-d97d-44a1-ae7f-71bf3ee278bc", "AQAAAAEAACcQAAAAEA/AUv4ahntD9CbFkB9g8Y/dwNJfH2LemKWhNxahQeQjssJ1t7KZHcnz+MyPJpudUA==", "33c47204-c4c6-4e3c-b609-0d16f90ed08e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "510ae883-2628-4777-af5e-b9d3de917a8e", "AQAAAAEAACcQAAAAEBw1tCrTq0jevLbOfvAqde/SKOngbFxrFCKE2C1xBqu/wmEl+zoo56sgFmL4Eh0sQw==", "3bf0997d-8fb3-41d9-bd82-a26a1db4c0fe" });
        }
    }
}
