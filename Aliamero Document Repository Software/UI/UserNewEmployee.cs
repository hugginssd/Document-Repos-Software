using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliamero_Document_Repository_Software.DAL;
using Aliamero_Document_Repository_System.BLL;

namespace Aliamero_Document_Repository_Software.UI
{
    public partial class UserNewEmployee : UserControl
    {
        public UserNewEmployee()
        {
            InitializeComponent();
        }
        UserEmployeeBLL employeeBLL = new UserEmployeeBLL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        DataTable dt = null;
        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search here..." && txtSearch.Text != "")
            {
                dt = new DataTable();
                dt = employeeDAL.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }


        }
        void Reset()
        {
            txtID.Text = "";
            txtID.Enabled = false;
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmployeeID.Clear();
            txtEmailID.Clear();
            txtCellnumber.Clear();
            lblDepartment.Text = "";
            lblDesignation.Text = "";
            txtFirstname.Focus();
        }
    }
}
