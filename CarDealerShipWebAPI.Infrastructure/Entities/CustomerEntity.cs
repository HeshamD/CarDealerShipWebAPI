

namespace CarDealerShipWebAPI.Infrastructure.Entities
{
    public record CustomerEntity
    {
        public Guid Customer_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(10, ErrorMessage = "Please Enter Valid Number")]
        public string PhoneNumber { get; set; }
        [MaxLength(5,ErrorMessage = "Please Enter Valid Zip Code")]
        public string ZipCode { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
