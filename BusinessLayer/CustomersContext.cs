using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CustomersContext
    {
        private CustomersDAL customersDAL = new CustomersDAL();

        public List<Customers> GetAllCustomers()
        {
            return customersDAL.GetAllCustomers();
        }

        public Customers GetCustomerById(string id)
        {
            return customersDAL.GetCustomerById(id);
        }

        public bool InsertCustomer(Customers customers)
        {
            return customersDAL.CreateCustomer(customers);
        }

        public bool DeleteCustomer(string customerID)
        {
            return customersDAL.DeleteCustomer(customerID);
        }

        public bool UpdateCustomer(string id, Customers customers)
        {
            return customersDAL.UpdateCustomer(id, customers);
        }
    }
}
