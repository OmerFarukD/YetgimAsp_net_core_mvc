using ECommerce.DataAccess.abstracts;
using ECommerce.Models;
using ECommerce.Models.Dtos.Categories;
using ECommerce.Services.Abstracts;

namespace ECommerce.Services.Concretes;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public List<CategoryResponseDto> GetAll()
    {
        List<CategoryResponseDto> responses = new List<CategoryResponseDto>();
        List<Category> categories = _categoryRepository.GetAll();

        
        foreach (Category category in categories)
        {
            CategoryResponseDto dto = new CategoryResponseDto()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };
            
            responses.Add(dto);
        }
        return responses;
    }

    public CategoryResponseDto GetById(int id)
    {
        Category category = _categoryRepository
            .Get(filter: x=>x.Id == id, include:false,tracking:false);
        CategoryResponseDto dto = new CategoryResponseDto()
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
        };
        return dto;
    }

    public void Add(Category category)
    {
        _categoryRepository.Add(category);
    }
}