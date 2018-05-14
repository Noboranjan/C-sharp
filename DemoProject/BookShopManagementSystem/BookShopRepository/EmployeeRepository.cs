using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
         public bool Insert(Employee emp)
        {
            try
            {
                string query = "INSERT into Employees VALUES ('" + emp.EmployeeId + "', '" + emp.Password + "', '" + emp.EmployeeName + "', " + emp.Salary + ", '" + emp.Designation + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Employee emp)
        {
            try
            {
                string query = "UPDATE Employees SET EmployeeName = '" + emp.EmployeeName + "', Salary =" + emp.Salary + ", Designation = '" + emp.Designation + "WHERE EmployeeID = '" + emp.EmployeeId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string employeeId)
        {
            try
            {
                string query = "DELETE From Employees WHERE EmployeeID='"+employeeId+"'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Employee GetEmployee(string employeeId)
        {
            string query = "SELECT * from Employees WHERE EmployeeID = '" + employeeId + "'";
            Employee emp = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                emp = new Employee();
                emp.EmployeeId = sdr["EmployeeID"].ToString(); 
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
                emp.Password = sdr["Password"].ToString();
                
            }
            dcc.CloseConnection();
            return emp;
        }

        public List<Employee> GetAllEmployee()
        {
            string query = "SELECT * from Employees";
            List<Employee> empList = new List<Employee>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = sdr["EmployeeID"].ToString();
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();

                empList.Add(emp);
            }
            dcc.CloseConnection();
            return empList;
        }

        public bool UserLoginValidation(Employee emp)
        {
            string query = "SELECT * from Employees WHERE EmployeeID = '" + emp.EmployeeId + "' AND EmployeePassword='" + emp.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr =  dcc.GetData(query);
           // dcc.CloseConnection();
            if (sdr.Read())
            {
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }

    }
}
