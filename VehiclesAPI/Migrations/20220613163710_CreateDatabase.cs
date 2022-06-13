using Microsoft.EntityFrameworkCore.Migrations;

namespace VehiclesAPI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wheel = table.Column<int>(type: "int", nullable: false),
                    HeadLight = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Color", "Model" },
                values: new object[,]
                {
                    { 1, "red", "Raptor" },
                    { 2, "blue", "Terhi" },
                    { 3, "black", "Hydrolift" },
                    { 4, "red", "Terhi" },
                    { 5, "white", "Raptor" },
                    { 6, "black", "Raptor" },
                    { 7, "red", "Raptor" },
                    { 8, "red", "Hydrolift" },
                    { 9, "blue", "Hydrolift" },
                    { 10, "black", "Terhi" }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Color", "Model" },
                values: new object[,]
                {
                    { 10, "black", "Setra" },
                    { 9, "blue", "Man" },
                    { 8, "red", "Man" },
                    { 7, "red", "Man" },
                    { 6, "black", "BMC" },
                    { 5, "white", "BMC" },
                    { 4, "red", "Setra" },
                    { 3, "black", "Setra" },
                    { 2, "blue", "Man" },
                    { 1, "red", "BMC" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "HeadLight", "Model", "Wheel" },
                values: new object[,]
                {
                    { 1, "red", false, "BMW", 4 },
                    { 2, "blue", false, "Mercedes", 4 },
                    { 3, "black", false, "Lamborghini", 4 },
                    { 4, "red", false, "Mercedes", 4 },
                    { 5, "white", false, "Lamborghini", 4 },
                    { 6, "black", false, "BMW", 4 },
                    { 7, "red", false, "BMW", 4 },
                    { 8, "red", false, "Lamborghini", 4 },
                    { 9, "blue", false, "Lamborghini", 4 },
                    { 10, "black", false, "BMW", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
