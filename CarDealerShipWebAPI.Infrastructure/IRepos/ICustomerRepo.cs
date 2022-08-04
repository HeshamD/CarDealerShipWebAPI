using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShipWebAPI.Infrastructure.IRepos
{
    public interface ICustomerRepo : IGenericRepo<CustomerEntity>
    { 
        public Task<string> GetFirstNameAndLastName(Guid id);
    }
}
