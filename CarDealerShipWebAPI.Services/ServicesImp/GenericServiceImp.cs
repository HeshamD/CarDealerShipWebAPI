

namespace CarDealerShipWebAPI.Services.ServicesImp
{
    public class GenericServiceImp<T> : IGenericService<T> where T : class
    {
        private IGenericRepo<T> _baseRepository;
        private IMapper _mapper;

        public GenericServiceImp(IGenericRepo<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }


        public T Create(T TT)
        {
            var _mapperEntity = _mapper.Map<T>(TT);

            return _baseRepository.Add(TT);
        }

        public async Task<T> CreateAsync(T TT)
        {
            var _mapperEntity = _mapper.Map<T>(TT);

            return await _baseRepository.AddAsync(TT);
        }

        public void Delete(Guid id)
        {
            _baseRepository.DeleteById(id);
        }

        public void DeleteAsync(Guid id)
        {
            _baseRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllASync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public T GetById(Guid? id)
        {
            return _baseRepository.GetById(id);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public async Task<T> UpdateByIdAsync(T obj, Guid id)
        {
            var TT = await _baseRepository.GetByIdAsync(id);

            var _mapperEntity = _mapper.Map<T>(obj);

            return await _baseRepository.UpdateAsync(_mapperEntity);
        }

    }
}
