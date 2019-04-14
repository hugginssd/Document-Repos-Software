using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliamero_Document_Repository_System.BLL;
using Aliamero_Document_Repository_System.DAL;

namespace Aliamero_Document_Repository_Software.UI
{
    public partial class UserDesignation : UserControl
    {
        public UserDesignation()
        {
            InitializeComponent();
        }
        DesignationBLL dbll = new DesignationBLL();
        DesignationDAL ddal = new DesignationDAL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "Description" && txtDesignation.Text != "Designation")
            {
                try
                {
                    dbll.Designation = txtDesignation.Text.ToUpper();
                    dbll.Description = txtDescription.Text.ToUpper();
                    bool IsSuccess = ddal.Insert(dbll);
                    if (IsSuccess)
                    {
                        MessageBox.Show("Successfully created","Designation",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                        Reset();
                        DataTable dt = new DataTable();
                        dt = ddal.Select();
                        dataGridView1.DataSource = dt;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to initiate a record", "Designation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"UI error");
                }
            }
            else
            {
                    MessageBox.Show("Invalid parameters", "Designation parameters", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            txtDescription.Clear();
            txtDesignation.Clear();
            txtID.Text = "";
            txtDesignation.Focus();
        }
        private void UserDesignation_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ddal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}
