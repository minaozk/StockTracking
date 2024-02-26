﻿using StockTracking.DAL.Data;
using StockTracking.DAL.Repositories.Abstract;
using StockTracking.Entities.Concrete;

namespace StockTracking.DAL.Repositories.Concrete
{
	public class StockMovementRepository : RepositoryBase<StockMovement, int, SqlDbContext>, IStockMovementRepository
	{
	}
}
