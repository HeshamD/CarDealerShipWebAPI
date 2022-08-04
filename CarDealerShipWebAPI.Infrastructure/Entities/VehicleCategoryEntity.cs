using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShipWebAPI.Infrastructure.Entities
{
    [Table("VehicleCategory")]
    public record VehicleCategoryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleCategoryId { get; set; }
        [MaxLength(10)]
        public string VehicleCategoryName { get; set; } = string.Empty;
        /// <summary>
        /// By this i can get a list of all the vehicles in this category
        /// </summary>
        public virtual List<VehicleEntity> Vehicles { get; set; }
    }
}
