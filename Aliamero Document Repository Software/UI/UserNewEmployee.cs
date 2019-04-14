using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
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
        OpenFileDialog a = new OpenFileDialog();
        UserEmployeeBLL ebll = new UserEmployeeBLL();
        EmployeeDAL edal = new EmployeeDAL();
        DataTable dt = null;
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text !="" && txtLastname.Text !="")
            {
                try
                {
                    ebll.Cellnumber = txtCellnumber.Text;
                    ebll.Firstname = txtFirstname.Text.ToUpper();
                    ebll.Lastname = txtLastname.Text.ToUpper();
                    ebll.Designation = cmbDesignation.Text.ToUpper();
                    ebll.Department = cmbDepartment.Text.ToUpper();
                    ebll.EmployeeID = txtEmployeeID.Text.ToUpper();
                    ebll.Gender = RdbMale.Checked ? "Male" : "Female";
                    ebll.Picture = File.ReadAllBytes(a.FileName);
                    ebll.Email = txtEmailID.Text;
                    bool IsSuccess = edal.Insert(ebll);
                    if (IsSuccess)
                    {
                        MessageBox.Show("Successfully created","New Employee",
                            MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                        Reset();
                        dt = new DataTable();
                        dt = edal.Select();
                        dataGridView1.DataSource = dt;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to initiate a record", "New Employee",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Reset();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"UI error",
                        MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid parameters","Parameters",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                return;
            }
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
                dt = edal.Search(txtSearch.Text);
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

        private void label3_Click(object sender, EventArgs e)
        {
            string piclocation =null;
            a.Filter = null;
            piclocation = a.FileName;
            a.ShowDialog();
            try
            {
                ProfilePhoto.Image = Image.FromFile(a.FileName);
            }
            catch (Exception ex)
            {

            }


        }

        private void UserNewEmployee_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = edal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}
