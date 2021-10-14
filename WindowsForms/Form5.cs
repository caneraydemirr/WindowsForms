using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form5 : Form
    {
        OrdersContext ordersContext = new OrdersContext();
        CustomersContext customersContext = new CustomersContext();
        EmployeesContext employeesContext = new EmployeesContext();
        Orders order;
        List<Orders> orderList;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var result = ordersContext.GetAllOrders();
            dataGridView1.DataSource = result;

            var resultCustomer = customersContext.GetAllCustomers();
            cb_customer.DataSource = resultCustomer;
            cb_customer.DisplayMember = "CompanyName";
            cb_customer.ValueMember = "CustomerID";

            var resultEmployees = employeesContext.GetAllEmployees();
            cb_employee.DataSource = resultEmployees;
            cb_employee.DisplayMember = "LastName";
            cb_employee.ValueMember = "EmployeeID";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tb_deleted.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_customer.Text = "";
            cb_customer.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_employee.Text = "";
            cb_employee.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            tb_orderDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_reqDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_shipDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_shipVia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_freight.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tb_shipName.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tb_shipAddress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_shipCity.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tb_shipRegion.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tb_shipPostalCode.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            tb_shipCountry.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders()
            {
                OrderID = int.Parse(tb_ID.Text),
                CustomerID = cb_customer.SelectedValue.ToString(),
                EmployeeID = int.Parse(cb_employee.SelectedValue.ToString()),
                OrderDate = Convert.ToDateTime(tb_orderDate.Text),
                RequiredDate = Convert.ToDateTime(tb_reqDate.Text),
                ShippedDate = Convert.ToDateTime("1996-09-03 00:00:00.000"),//Convert.ToDateTime(tb_shipDate.Text),
                ShipVia = int.Parse(tb_shipVia.Text),
                Freight = decimal.Parse(tb_freight.Text),
                ShipName = tb_shipName.Text,
                ShipAddress = tb_shipAddress.Text,
                ShipCity = tb_shipCity.Text,
                ShipRegion = tb_shipRegion.Text,
                ShipPostalCode = tb_shipPostalCode.Text,
                ShipCountry = tb_shipCountry.Text
            };
            ordersContext.InsertOrder(orders);
            updateDataGrid();
        }
        private void updateDataGrid()
        {
            orderList = ordersContext.GetAllOrders();
            dataGridView1.DataSource = orderList;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_search.Text != null && tb_search.Text != "")
            {
                order = ordersContext.GetOrdersById(int.Parse(tb_search.Text));
                if (order != null)
                {
                    orderList = new List<Orders>();
                    orderList.Add(order);
                    dataGridView1.DataSource = orderList;
                    return;
                }
            }
            var result = ordersContext.GetAllOrders();
            dataGridView1.DataSource = result;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders()
            {
                OrderID = int.Parse(tb_ID.Text),
                CustomerID = cb_customer.SelectedValue.ToString(),
                EmployeeID = int.Parse(cb_employee.SelectedValue.ToString()),
                OrderDate = Convert.ToDateTime(tb_orderDate.Text),
                RequiredDate = Convert.ToDateTime(tb_reqDate.Text),
                ShippedDate = Convert.ToDateTime("1996-09-03 00:00:00.000"),//Convert.ToDateTime(tb_shipDate.Text),
                ShipVia = int.Parse(tb_shipVia.Text),
                Freight = decimal.Parse(tb_freight.Text),
                ShipName = tb_shipName.Text,
                ShipAddress = tb_shipAddress.Text,
                ShipCity = tb_shipCity.Text,
                ShipRegion = tb_shipRegion.Text,
                ShipPostalCode = tb_shipPostalCode.Text,
                ShipCountry = tb_shipCountry.Text
            };
            ordersContext.UpdateOrder(orders.OrderID, orders);
            updateDataGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ordersContext.DeleteOrder(int.Parse(tb_deleted.Text));
            updateDataGrid();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }
    }
}
