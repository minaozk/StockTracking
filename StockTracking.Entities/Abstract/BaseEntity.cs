namespace StockTracking.Entities.Abstract
{
	public class BaseEntity<TId>
	{
		public TId Id { get; set; }

	}
}