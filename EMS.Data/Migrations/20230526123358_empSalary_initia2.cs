using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class empSalary_initia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "NetSalary",
                table: "EmpSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "EmpSalaries");

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
    }
}
