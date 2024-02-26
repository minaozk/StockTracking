﻿using StockTracking.Entities.Abstract;

namespace StockTracking.Entities.Concrete
{
	public class Customer : BaseEntity<int>
	{
		public string NameSurname { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public DateTime CreatedDate { get; set; }

	}
}
