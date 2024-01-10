using System;
namespace BestBuy_BestPractices
{
	public interface IDepartmentRepo
	{
		public IEnumerable<Department> GetAllDepartments();
		public void InsertDepartment(string newDepartmentName);
	}


}

