using StockTracking.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockTracking.Entities.Concrete
{
	public class Return : BaseEntity<int>
	{
		public int Id { get; set; }

		public int ProductId { get; set; }
		[ForeignKey(nameof(ProductId))]
		public Product Products { get; set; }

		public int ReturnQuantity { get; set; }
		public DateTime ReturnDate { get; set; }
		public string? ReasonForReturn { get; set; }
	}
}
