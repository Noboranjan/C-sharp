using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopRepository
{
    interface IEmployeeRepository
    {
        bool Insert(Employee b);
        bool Update(Employee b);
        bool Delete(string employeeId);
        Employee GetEmployee(string employeeId);
        List<Employee> GetAllEmployee();
    }
}
