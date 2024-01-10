using System;
namespace BestBuy_BestPractices
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
		public void CreateProduct(string name, double price, int categoryID);
	}


}

