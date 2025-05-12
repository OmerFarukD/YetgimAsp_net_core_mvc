using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfCategoryRepository(BaseDbContext context) : ICategoryRepository
{
    
    
    public void Add(Category category)
    {
        category.CreatedTime = DateTime.Now;
       context.Categories.Add(category);
       context.SaveChanges();
    }

    public void Update(Category category)
    {
        category.UpdatedTime = DateTime.Now;
        context.Categories.Update(category);
        context.SaveChanges();
    }

    public void Delete(Category category)
    {
        context.Categories.Remove(category);
        context.SaveChanges();
    }

    public List<Category> GetAll()
    {
        return context.Categories.ToList();
    }

    public Category? GetById(int id)
    {
        return context.Categories.Find(id);
    }
}