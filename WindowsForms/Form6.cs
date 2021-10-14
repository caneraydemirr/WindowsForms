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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btn_shippers_Click(object sender, EventArgs e)
        {
            Form3 shipper = new Form3();
            shipper.Show();
            this.Hide();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Form2 customer = new Form2();
            customer.Show();
            this.Hide();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            Form4 employe = new Form4();
            employe.Show();
            this.Hide();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Form5 order = new Form5();
            order.Show();
            this.Hide();
        }
    }
}
