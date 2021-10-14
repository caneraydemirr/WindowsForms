using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class EmployeesContext
    {
        private EmployeesDAL employeesDAL = new EmployeesDAL();

        public List<Employees> GetAllEmployees()
        {
            return employeesDAL.GetAllEmployees();
        }

        public Employees GetEmployeesById(int id)
        {
            return employeesDAL.GetEmployeeById(id);
        }

        public bool InsertEmployee(Employees employees)
        {
            return employeesDAL.CreateEmployee(employees);
        }

        public bool DeleteEmployee(int employeeID)
        {
            return employeesDAL.DeleteEmployee(employeeID);
        }

        public bool UpdateEmployee(int id, Employees employees)
        {
            return employeesDAL.UpdateEmployee(id, employees);
        }
    }
}
