using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;


namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
            HttpResponseMessage response = client.GetAsync("api/regions").Result;
            var result = response.Content.ReadAsAsync<IEnumerable<Regions>>().Result;
            dataGridView1.DataSource = result;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
            HttpResponseMessage response = client.GetAsync("api/regions/"+textBox1.Text).Result;
            Regions region = response.Content.ReadAsAsync<Regions>().Result;
            List<Regions> regionsList = new List<Regions>();
            regionsList.Add(region);
            dataGridView1.DataSource = regionsList;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Regions region = new Regions() {RegionID=int.Parse(RegionID.Text), RegionDescription = RegionDescription.Text};
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8088/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/regions/",region).Result;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
