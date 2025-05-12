using ECommerce.Models;
using ECommerce.Models.Dtos.Categories;

namespace ECommerce.Services.Abstracts;

public interface ICategoryService
{
    List<CategoryResponseDto> GetAll();
    CategoryResponseDto GetById(int id);
    void Add(Category category);
}