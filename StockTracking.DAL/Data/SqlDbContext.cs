using Microsoft.EntityFrameworkCore;
using StockTracking.Entities.Concrete;

namespace StockTracking.DAL.Data
{
	public class SqlDbContext : DbContext
	{
		public SqlDbContext()
		{

		}
		public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<StockMovement> StockMovements { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Return> Returns { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.;Database=DbStockTracking;Trusted_Connection=true;Trust Server Certificate=true");
		}


	}
}
