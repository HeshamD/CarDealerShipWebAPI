

namespace CarDealerShipWebAPI.Services
{
    public interface IVehicleServices
    {
        public Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync();
        public Task<VehicleDto> GetVehicleByIdAsync(int vehicleId);
        public Task CreateVehicleAsync(VehicleDto vehicleDto);
        public Task UpdateVehicleAsync(int id,VehicleDto vehicleDto);
        public Task DeleteVehicleAsync(int id);
        public Task<IEnumerable<VehicleDto>> GetAllVehiclesByModelAsync(string model);


    }
}
