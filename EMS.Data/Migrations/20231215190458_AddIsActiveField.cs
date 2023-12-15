using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class AddIsActiveField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "RegisterViewModel");

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
                values: new object[] { "f005a601-9810-44d8-adba-961e66fd9f4e", true, "AQAAAAEAACcQAAAAEByoMxcG2NiHABHXB1i7m2sfvzD166s96Xckg4fZ/L1iqKhyRhXY3qh8FXVyWSSMsw==", "b532f70d-266b-45f5-8008-bd6bb7ea18dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d76a5708-0989-49e4-a5c2-9abc4348f2c3", true, "AQAAAAEAACcQAAAAENhvoWdBgMaLkAxdYzDvvyD0fYjK8RfxEvOk01HOA5gEuzKW5FEnbbNH49jycSLB4w==", "be60af20-682b-411e-9ba1-da6220c0ab01" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests");

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

            migrationBuilder.CreateTable(
                name: "RegisterViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateofJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterViewModel", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_RegisterViewModel_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "RegisterViewModel",
                principalColumn: "Id");
        }
    }
}
