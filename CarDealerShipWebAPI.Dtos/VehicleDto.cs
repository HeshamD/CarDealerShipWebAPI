

namespace CarDealerShipWebAPI.Dtos
{
    public class VehicleDto
    {
        [DataType(DataType.Date)]
        public string? Vehicle_Year { get; set; }
        [MaxLength(15)]
        public string? Vehicle_Make { get; set; }
        [MaxLength(10)]
        public string? Vehicle_Model { get; set; }
        [MaxLength(10)]
        public string? Vehicle_VinNumber { get; set; }
        public string? Vehicle_Mileage { get; set; }
        public string? Vehicle_Exterior_Color { get; set; }
        public string? Vehicle_Price { get; set; }
        public string? Vehicle_Trim { get; set; }
        public string? Vehicle_FuelType { get; set; }
        public string? Vehicle_Description { get; set; }
        public string? Vehicle_Doors { get; set; }
        public string? Vehicle_Cylinders { get; set; }
        public string? Condition { get; set; }
        public bool? IsAvaliable { get; set; }
        //public byte[] VehicleImg { get; set; }


        /// <summary>
        /// Navigation prop
        /// </summary>
        public int? Vehicle_Category_id { get; set; }
    }
}
