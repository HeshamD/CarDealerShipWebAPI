using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealerShipWebAPI.Infrastructure.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleCategory",
                columns: table => new
                {
                    VehicleCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleCategoryName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategory", x => x.VehicleCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle_Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle_Make = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Vehicle_Model = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Vehicle_VinNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Vehicle_Mileage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Exterior_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Price = table.Column<double>(type: "float", nullable: false),
                    Vehicle_Trim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Doors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Cylinders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvaliable = table.Column<bool>(type: "bit", nullable: false),
                    Vehicle_Category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleCategory_Vehicle_Category_id",
                        column: x => x.Vehicle_Category_id,
                        principalTable: "VehicleCategory",
                        principalColumn: "VehicleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VehicleCategory",
                columns: new[] { "VehicleCategoryId", "VehicleCategoryName" },
                values: new object[] { 1, "Cars" });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleId", "Condition", "IsAvaliable", "Vehicle_Category_id", "Vehicle_Cylinders", "Vehicle_Description", "Vehicle_Doors", "Vehicle_Exterior_Color", "Vehicle_FuelType", "Vehicle_Make", "Vehicle_Mileage", "Vehicle_Model", "Vehicle_Price", "Vehicle_Trim", "Vehicle_VinNumber", "Vehicle_Year" },
                values: new object[] { 1, "good", true, 1, "4", "nice car", "4", "black", "gas", "hunda", "1200", "HR-v", 20000.0, "4", "1212313", "2022" });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Vehicle_Category_id",
                table: "Vehicle",
                column: "Vehicle_Category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehicleCategory");
        }
    }
}
