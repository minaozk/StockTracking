using StockTracking.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTracking.Entities.Concrete
{
	public class Order : BaseEntity<int>
	{
		public int CustomerId { get; set; }
		[ForeignKey(nameof(CustomerId))]
		public Customer Customers { get; set; }
		public int ProductId { get; set; }
		[ForeignKey(nameof(ProductId))]
		public Product ProductS { get; set; }
		public int Quantity { get; set; }
		public string OrderStatus { get; set; }
	}
}
