

namespace CarDealerShipWebAPI.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehiclesFluentApi());
            modelBuilder.ApplyConfiguration(new VehiclesCategoriesFluentApi());

            modelBuilder.Entity<VehicleCategoryEntity>().HasData(new VehicleCategoryEntity { VehicleCategoryId = 1, VehicleCategoryName = "Cars" });
            modelBuilder.Entity<VehicleEntity>().HasData(new VehicleEntity
            {
                VehicleId = 1,
                Vehicle_Category_id = 1,
                Vehicle_Cylinders = "4",
                Vehicle_Description = "nice car",
                Vehicle_Doors = "4",
                Vehicle_Exterior_Color = "black",
                Vehicle_FuelType = "gas",
                Vehicle_Make = "hunda",
                Vehicle_Model = "HR-v",
                Vehicle_Mileage = "1200",
                Vehicle_Price = 20000,
                Vehicle_VinNumber = "1212313",
                Vehicle_Trim = "4",
                Vehicle_Year = "2022",
                Condition ="good",
                IsAvaliable =true
            });
        }


        //Create the dbset for the tables in the db
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<VehicleCategoryEntity> VehicleCategories { get; set; }
    }
}
