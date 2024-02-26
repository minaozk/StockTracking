using StockTracking.Entities.Abstract;

namespace StockTracking.Entities.Concrete
{
	public class Category : BaseEntity<int>
	{
		public string CategoryName { get; set; }
		public string Description { get; set; }
	}
}
