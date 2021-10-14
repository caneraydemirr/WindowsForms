using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrdersContext
    {
        private OrdersDAL ordersDAL = new OrdersDAL();

        public List<Orders> GetAllOrders()
        {
            return ordersDAL.GetAllOrders();
        }

        public Orders GetOrdersById(int id)
        {
            return ordersDAL.GetOrderById(id);
        }

        public bool InsertOrder(Orders orders)
        {
            return ordersDAL.CreateOrder(orders);
        }

        public bool DeleteOrder(int orderID)
        {
            return ordersDAL.DeleteOrder(orderID);
        }

        public bool UpdateOrder(int id, Orders orders)
        {
            return ordersDAL.UpdateOrder(id, orders);
        }
    }
}
