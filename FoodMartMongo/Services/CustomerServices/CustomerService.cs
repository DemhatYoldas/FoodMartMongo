using AutoMapper;
using FoodMartMongo.Dtos.CustomerDtos;
using FoodMartMongo.Entities;
using MongoDB.Driver;

namespace FoodMartMongo.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _customerCollection;
        private readonly IMapper _mapper;

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
