


namespace CarDealerShipWebAPI.Services.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // from vehicleEntity to vehicleDto
            CreateMap<VehicleEntity, VehicleDto>()
                .ForMember(dest => dest.Vehicle_Cylinders, src => src.MapFrom(src => src.Vehicle_Cylinders))
                .ReverseMap(); //dest is the dto     
        }


    }
}
