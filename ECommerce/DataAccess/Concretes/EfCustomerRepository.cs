using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfCustomerRepository :EfRepositoryBase<Customer,long,BaseDbContext>, ICustomerRepository
{
    public EfCustomerRepository(BaseDbContext context) : base(context)
    {
    }
}