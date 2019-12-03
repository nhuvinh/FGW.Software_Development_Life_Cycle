using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
				public interface IEmployeeStorage
				{
								void DeleteEmployee(int id);
				}

				public class EmployeeStorage : IEmployeeStorage
				{
								private EmployeeContext _db;
								public EmployeeStorage()
								{
												_db = new EmployeeContext();
								}
								public void DeleteEmployee(int id)
								{
												var employee = _db.Employees.Find(id);
												if (employee == null) return;
												_db.Employees.Remove(employee);
												_db.SaveChanges();
								}
				}
}
