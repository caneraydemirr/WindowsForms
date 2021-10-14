using DataLayer;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using BusinessLayer;


namespace WindowsForms
{
    public partial class Form2 : Form
    {
        Customers customers;
        List<Customers> customerList;
        CustomersContext customersContext = new CustomersContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var result = customersContext.GetAllCustomers();
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers() 
            {
                CustomerID = tb_ID.Text, CompanyName = tb_compname.Text, ContactName=tb_contactname.Text, 
                ContactTitle=tb_contitle.Text, Address=tb_adress.Text, City=tb_city.Text, Region=tb_region.Text, PostalCode=tb_postalCode.Text,
            Country=tb_country.Text, Phone=tb_phone.Text, Fax=tb_fax.Text
            };
            customersContext.InsertCustomer(customers);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_search.Text!=null && tb_search.Text != "")
            {
                customers = customersContext.GetCustomerById(tb_search.Text);
                if (customers != null)
                {
                    customerList = new List<Customers>();
                    customerList.Add(customers);
                    dataGridView1.DataSource = customerList;
                    return;
                }
            }
            var result = customersContext.GetAllCustomers();
            dataGridView1.DataSource = result;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers()
            {
                CustomerID = tb_ID.Text,
                CompanyName = tb_compname.Text,
                ContactName = tb_contactname.Text,
                ContactTitle = tb_contitle.Text,
                Address = tb_adress.Text,
                City = tb_city.Text,
                Region = tb_region.Text,
                PostalCode = tb_postalCode.Text,
                Country = tb_country.Text,
                Phone = tb_phone.Text,
                Fax = tb_fax.Text
            };
            customersContext.UpdateCustomer(customers.CustomerID, customers);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tb_deleted.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_compname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_contactname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_contitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_adress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_city.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_region.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_postalCode.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tb_country.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tb_phone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_fax.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            customersContext.DeleteCustomer(tb_deleted.Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }
    }
}
