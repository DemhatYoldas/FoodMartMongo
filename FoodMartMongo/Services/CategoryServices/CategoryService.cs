using FoodMartMongo.Dtos.CategoryDtos;

namespace FoodMartMongo.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public Task CreateCategoryDto(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
