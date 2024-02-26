using StockTracking.Entities.Abstract;

namespace StockTracking.Entities.Concrete
{
	public class Supplier : BaseEntity<int>
	{
		public string CompanyName { get; set; }
		public string ContactName { get; set; }

		public string Address { get; set; }
		public string City { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }


	}
}
