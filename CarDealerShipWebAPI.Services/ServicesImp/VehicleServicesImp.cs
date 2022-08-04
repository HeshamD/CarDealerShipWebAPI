

using System.Diagnostics;

namespace CarDealerShipWebAPI.Services.ServicesImp
{
    public class VehicleServicesImp:IVehicleServices
    {
        private readonly IVehicleRepo _IVehicleRepo;
        private readonly IMapper _Mapper;

        public VehicleServicesImp(IVehicleRepo vehicleRepo,IMapper mapper)
        {
            _IVehicleRepo = vehicleRepo;
            _Mapper = mapper;
        }

        public async Task<VehicleDto> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _IVehicleRepo.GetVehicleByIdAsync(vehicleId);

            if(vehicle == null)
            {
                return null;
            }

            return _Mapper.Map<VehicleDto>(vehicle);

        }

        public async Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync()
        {
            var Vehicles = await _IVehicleRepo.GetAllVehicleAsync();

            var vehicles_DTO = _Mapper.Map<IEnumerable<VehicleDto>>(Vehicles);

            return vehicles_DTO;
        }

        public async Task CreateVehicleAsync(VehicleDto vehicleDto)
        {
            var vehicle =_Mapper.Map<VehicleEntity>(vehicleDto); //()in the brackets is the source
            await _IVehicleRepo.CreateVehicleAsync(vehicle);
        }
        public async Task UpdateVehicleAsync(int id,VehicleDto vehicleDto)
        {
            var Vehicle = await _IVehicleRepo.GetVehicleByIdAsync(id);

            Vehicle = _Mapper.Map<VehicleEntity>(vehicleDto);

            await _IVehicleRepo.UpdateVehicleAsync(Vehicle);
        }

        public async Task DeleteVehicleAsync(int id)
        {
            await _IVehicleRepo.DeleteVehicleByIdAsync(id);
        }

        public async Task<IEnumerable<VehicleDto>> GetAllVehiclesByModelAsync(string model)
        {
            var VehiclesEntities = await _IVehicleRepo.GetAllVehiclesByModel(model);

            var VehiclesDtos = _Mapper.Map<IEnumerable<VehicleDto>>(VehiclesEntities);

            return VehiclesDtos;
        }
    }
}
