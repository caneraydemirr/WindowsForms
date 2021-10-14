using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace WindowsForms
{
    public partial class Form3 : Form
    {
        List<Shippers> shipperList;
        Shippers shipper;
        ShippersContext shippersContext = new ShippersContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = shippersContext.GetAllShippers();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            shipper = shippersContext.GetShipperById(int.Parse(tb_search.Text.ToString()));
            shipperList = new List<Shippers>();
            shipperList.Add(shipper);
            dataGridView1.DataSource = shipperList;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Shippers ship = new Shippers()
            {
                ShipperID = int.Parse(tb_ID.Text.ToString()),
                CompanyName = tb_compname.Text,
                Phone = tb_phone.Text
            };
            shippersContext.InsertShipper(ship);
            guncelle();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Shippers ship = new Shippers()
            {
                ShipperID = int.Parse(tb_ID.Text.ToString()),
                CompanyName = tb_compname.Text,
                Phone = tb_phone.Text
            };
            shippersContext.UpdateShipper(ship.ShipperID, ship);
            guncelle();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_compname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void guncelle()
        {
            shipperList = shippersContext.GetAllShippers();
            dataGridView1.DataSource = shipperList;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }
    }
}
