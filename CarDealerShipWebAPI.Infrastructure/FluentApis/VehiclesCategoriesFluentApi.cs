

namespace CarDealerShipWebAPI.Infrastructure.FluentApis
{
    public class VehiclesCategoriesFluentApi : IEntityTypeConfiguration<VehicleCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleCategoryEntity> builder)
        {
            builder.HasMany(vc => vc.Vehicles)
                .WithOne(v => v.VehicleCategoryEntity)
                .HasForeignKey(v => v.Vehicle_Category_id);
        }
    }
}
