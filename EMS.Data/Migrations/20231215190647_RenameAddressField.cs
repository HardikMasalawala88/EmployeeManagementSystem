using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Data.Migrations
{
    public partial class RenameAddressField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "AspNetUsers",
                newName: "Address");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "address");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "224047d7-9c97-4768-a0f6-50e7eec9fe29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f005a601-9810-44d8-adba-961e66fd9f4e", "AQAAAAEAACcQAAAAEByoMxcG2NiHABHXB1i7m2sfvzD166s96Xckg4fZ/L1iqKhyRhXY3qh8FXVyWSSMsw==", "b532f70d-266b-45f5-8008-bd6bb7ea18dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8545447-30d8-4910-8931-b5c22e47f8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d76a5708-0989-49e4-a5c2-9abc4348f2c3", "AQAAAAEAACcQAAAAENhvoWdBgMaLkAxdYzDvvyD0fYjK8RfxEvOk01HOA5gEuzKW5FEnbbNH49jycSLB4w==", "be60af20-682b-411e-9ba1-da6220c0ab01" });
        }
    }
}
