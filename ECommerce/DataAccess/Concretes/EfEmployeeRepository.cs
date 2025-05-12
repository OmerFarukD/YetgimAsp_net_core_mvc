using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfEmployeeRepository : EfRepositoryBase<Employee,long,MongoDbContext>, IEmployeeRepository
{
    public EfEmployeeRepository(MongoDbContext context) : base(context)
    {
    }
}