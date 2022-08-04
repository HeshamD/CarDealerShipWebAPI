using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealerShipWebAPI.Infrastructure.Migrations
{
    public partial class seedingVehicleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleId", "Condition", "IsAvaliable", "Vehicle_Category_id", "Vehicle_Cylinders", "Vehicle_Description", "Vehicle_Doors", "Vehicle_Exterior_Color", "Vehicle_FuelType", "Vehicle_Make", "Vehicle_Mileage", "Vehicle_Model", "Vehicle_Price", "Vehicle_Trim", "Vehicle_VinNumber", "Vehicle_Year" },
                values: new object[] { 1, "good", true, 1, "4", "nice car", "4", "black", "gas", "hunda", "1200", "HR-v", "20000", "4", "1212313", "2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1);
        }
    }
}
