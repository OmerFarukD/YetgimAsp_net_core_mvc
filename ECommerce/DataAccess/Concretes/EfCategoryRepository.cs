using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfCategoryRepository(BaseDbContext context) : EfRepositoryBase<Category,int,BaseDbContext>(context),  ICategoryRepository
{
    
    
  
}