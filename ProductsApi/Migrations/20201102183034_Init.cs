using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 1, "Water", 0.5, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 2, "Blouse", 50.0, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 3, "Jeans", 120.0, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 4, "Hat", 20.0, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 5, "Laptop", 2310.0, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 6, "Mug", 12.0, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 7, "Fork", 1.5, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ValidFrom", "ValidTo" },
                values: new object[] { 8, "Spoon", 2.5, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
