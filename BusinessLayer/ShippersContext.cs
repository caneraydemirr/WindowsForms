using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class ShippersContext
    {
        private ShippersDAL shippersDAL = new ShippersDAL();

        public List<Shippers> GetAllShippers()
        {
            return shippersDAL.GetAllShippers();
        }

        public Shippers GetShipperById(int id)
        {
            return shippersDAL.GetShipperById(id);
        }

        public bool InsertShipper(Shippers shipper)
        {
            return shippersDAL.CreateShipper(shipper);
        }

        public bool DeleteShipper(int shipperID)
        {
            return shippersDAL.DeleteShipper(shipperID);
        }

        public bool UpdateShipper(int id, Shippers shippers)
        {
            return shippersDAL.UpdateShipper(id, shippers);
        }
    }
}
