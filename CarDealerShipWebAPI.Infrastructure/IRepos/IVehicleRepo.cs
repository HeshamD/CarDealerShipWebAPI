

namespace CarDealerShipWebAPI.Infrastructure.IRepos
{
    public interface IVehicleRepo
    {
        public IEnumerable<VehicleEntity> GetAllVehicle();
        public Task<IEnumerable<VehicleEntity>> GetAllVehicleAsync();
        public Task<VehicleEntity> GetVehicleByIdAsync(int id);
        public Task CreateVehicleAsync(VehicleEntity vehicleEntity);
        public Task<IEnumerable<VehicleEntity>> GetAllVehiclesByModel(string model);
        public Task DeleteVehicleByIdAsync(int id);
        public Task UpdateVehicleByIdAsync(int id);
        public Task UpdateVehicleAsync(VehicleEntity vehicleEntity);


    }
}
