using AutoMapper;
using FoodMartMongo.Dtos.CustomerDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _customerCollection;
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _customerCollection = database.GetCollection<Customer>(_databaseSettings.CustomerCollectionName);
            _mapper= mapper;
        }


        public Task CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCustomerDto>> GetResultCustomerAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
        {
            throw new NotImplementedException();
        }
    }
}
