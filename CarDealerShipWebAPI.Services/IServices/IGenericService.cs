using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShipWebAPI.Services.IServices
{
    public interface IGenericService<T> where T:class
    {
        public T Create(T TT);
        public Task<T> CreateAsync(T TT);
        public void Delete(Guid id);
        public void DeleteAsync(Guid id);
        public IEnumerable<T> GetAll();
        public T GetById(Guid id);
        public T GetById(Guid? id);
        public Task<IEnumerable<T>> GetAllASync();
        public Task<T> GetByIdAsync(Guid id);
        public Task<T> UpdateByIdAsync(T obj, Guid id);

    }
}
