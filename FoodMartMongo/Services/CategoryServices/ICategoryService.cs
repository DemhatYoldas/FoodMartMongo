using FoodMartMongo.Dtos.CategoryDtos;

namespace FoodMartMongo.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryDto(CreateCategoryDto createCategoryDto);
        Task UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategory(string id);
        Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id);
    }
}
