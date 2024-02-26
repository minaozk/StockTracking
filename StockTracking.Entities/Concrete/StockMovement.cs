using StockTracking.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTracking.Entities.Concrete
{
	public class StockMovement : BaseEntity<int>
	{
		public int ProductId { get; set; }
		[ForeignKey(nameof(ProductId))]
		public Product Products { get; set; }

		public DateTime DepartureDate { get; set; }

		public int Quantity { get; set; }

		public string MovementType { get; set; }

		public int SupplierId { get; set; }

		[ForeignKey(nameof(SupplierId))]
		public Supplier Suppliers { get; set; }

		public string? Description { get; set; }

	}
}
