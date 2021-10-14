using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace WindowsForms
{
    public partial class Form4 : Form
    {
        EmployeesContext employeesContext = new EmployeesContext();
        Employees employees;
        List<Employees> employeeList;
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tb_deleted.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_lName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_fName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_title.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_toc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            tb_bDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_hDate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            tb_address.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tb_city.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tb_region.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_postalCode.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tb_country.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tb_hPhone.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            tb_extension.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            tb_notes.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            tb_reportsTo.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            tb_photoPath.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var result = employeesContext.GetAllEmployees();
            dataGridView1.DataSource = result;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_search.Text != null && tb_search.Text != "")
            {
                employees = employeesContext.GetEmployeesById(int.Parse(tb_search.Text));
                if (employees != null)
                {
                    employeeList = new List<Employees>();
                    employeeList.Add(employees);
                    dataGridView1.DataSource = employeeList;
                    return;
                }
            }
            var result = employeesContext.GetAllEmployees();
            dataGridView1.DataSource = result;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees()
            {
                EmployeeID = int.Parse(tb_ID.Text),
                LastName = tb_lName.Text,
                FirstName = tb_fName.Text,
                Title = tb_title.Text,
                TitleOfCourtesy = tb_toc.Text,
                BirthDate = Convert.ToDateTime(tb_bDate.Text),
                HireDate = Convert.ToDateTime(tb_hDate.Text),
                Address = tb_address.Text,
                City = tb_city.Text,
                Region = tb_region.Text,
                PostalCode = tb_postalCode.Text,
                Country = tb_country.Text,
                HomePhone = tb_hPhone.Text,
                Extension = tb_extension.Text,
                Notes = tb_notes.Text,
                ReportsTo = int.Parse(tb_reportsTo.Text),
                PhotoPath = tb_photoPath.Text
            };
            employeesContext.UpdateEmployee(employees.EmployeeID, employees);
            updateDataGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees()
            {
                EmployeeID = int.Parse(tb_ID.Text),
                LastName = tb_lName.Text,
                FirstName = tb_fName.Text,
                Title = tb_title.Text,
                TitleOfCourtesy = tb_toc.Text,
                BirthDate = Convert.ToDateTime(tb_bDate.Text),
                HireDate = Convert.ToDateTime(tb_hDate.Text),
                Address = tb_address.Text,
                City = tb_city.Text,
                Region = tb_region.Text,
                PostalCode = tb_postalCode.Text,
                Country = tb_country.Text,
                HomePhone = tb_hPhone.Text,
                Extension = tb_extension.Text,
                Notes = tb_notes.Text,
                ReportsTo = int.Parse(tb_reportsTo.Text),
                PhotoPath = tb_photoPath.Text
            };
            employeesContext.InsertEmployee(employees);
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            employeeList = employeesContext.GetAllEmployees();
            dataGridView1.DataSource = employeeList;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeesContext.DeleteEmployee(int.Parse(tb_deleted.Text));
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
