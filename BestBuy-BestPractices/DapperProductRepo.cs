using System;
using System.Data;
using Dapper;

namespace BestBuy_BestPractices
{
	public class DapperProductRepo : IProductRepo
	{
        private readonly IDbConnection _conn;
		public DapperProductRepo(IDbConnection conn)
		{
            _conn = conn;
		}

        public void CreateProduct(string name, double price, int categoryID)
        {
            _conn.Execute("INSERT INTO products (Name, Price, CategoryID)" + "VALUES (@name, @price, @categoryID);", new {name = name, price = price, categoryID = categoryID});
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}

