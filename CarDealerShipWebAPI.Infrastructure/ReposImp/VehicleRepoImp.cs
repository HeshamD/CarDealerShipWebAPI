



using Microsoft.EntityFrameworkCore;

namespace CarDealerShipWebAPI.Infrastructure.ReposImp
{
    public class VehicleRepoImp : IVehicleRepo
    {

        private readonly ApplicationDbContext db;
        public VehicleRepoImp( ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task CreateVehicleAsync(VehicleEntity vehicleEntity)
        {
            await db.Vehicles.AddAsync(vehicleEntity);
            db.SaveChanges();
        }

        public IEnumerable<VehicleEntity> GetAllVehicle()
        {
            var vehicles  = db.Vehicles.ToList();
            return vehicles;
        }

        public async Task<IEnumerable<VehicleEntity>> GetAllVehicleAsync()
        {
            var vehicles = await db.Vehicles.ToListAsync();
            return vehicles;
        }

        public async Task<VehicleEntity> GetVehicleByIdAsync(int id)
        {
            var vehicle = await db.Vehicles.SingleOrDefaultAsync(v => v.VehicleId == id);
            return vehicle;
        }

        public async Task<IEnumerable<VehicleEntity>> GetAllVehiclesByModel(string model)
        {
            var vehicle = await db.Vehicles.Where(v => v.Vehicle_Model == model).OrderBy(v => v.Vehicle_Year).ToListAsync();
            return vehicle;
        }
        public async Task UpdateVehicleByIdAsync(int id)
        {
            var vehicle = await db.Vehicles.FindAsync(id);
            if(vehicle == null)
            {
                return;
            }
            db.Vehicles.Update(vehicle);
            db.SaveChanges();

        }
        public async Task DeleteVehicleByIdAsync(int id)
        {
            var vehicle = await db.Vehicles.SingleOrDefaultAsync(v => v.VehicleId == id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
        }

        public async Task UpdateVehicleAsync(VehicleEntity vehicleEntity)
        {
            db.Vehicles.Update(vehicleEntity);
            db.SaveChanges();
        }




    }
}
