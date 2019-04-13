using Aliamero_Document_Repository_System.BLL;
using Aliamero_Document_Repository_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliamero_Document_Repository_Software.UI
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" && txtUsername.Text!= "Username")
            {
                if (txtPassword.Text != "" && txtUsername.Text != "")
                {
                    ubll.Username = txtUsername.Text.Trim();
                    ubll.Password = txtPassword.Text.Trim();
                    bool IssSuccess = udal.SignIn(ubll);
                    if (IssSuccess)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {   
                        MessageBox.Show("Invalid login attempts","Login status",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid parameters","Login",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid parameters", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
