

namespace CarDealerShipWebAPI.Infrastructure.Entities
{
    public record CustomerEntity
    {
        public Guid Customer_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
