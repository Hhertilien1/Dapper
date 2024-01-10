using System;
using System.Data;
using Dapper;

namespace BestBuy_BestPractices
{
	public class DapperDepartmentRepo : IDepartmentRepo
	{
		private readonly IDbConnection _conn;




		public DapperDepartmentRepo(IDbConnection conn)
		{
			_conn = conn;
		}

        public IEnumerable<Department> GetAllDepartments()
        {
			return _conn.Query<Department>("SELECT * FROM Departments;");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _conn.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);", new { departmentName = newDepartmentName });
        }
    }
}

