using StockTracking.DAL.Data;
using StockTracking.DAL.Repositories.Abstract;
using StockTracking.Entities.Concrete;

namespace StockTracking.DAL.Repositories.Concrete
{
	public class CustomerRepository : RepositoryBase<Customer, int, SqlDbContext>, ICustomerRepository
	{
	}
}
