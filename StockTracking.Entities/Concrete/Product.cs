using StockTracking.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTracking.Entities.Concrete
{
	public class Product : BaseEntity<int>
	{
		public string ProductName { get; set; }
		public string Description { get; set; }

		public decimal UnitPrice { get; set; }

		public decimal Cost { get; set; }
		public int StockQuantity { get; set; }
		public int MinStockQuantity { get; set; }

		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Categories { get; set; }
	}
}
