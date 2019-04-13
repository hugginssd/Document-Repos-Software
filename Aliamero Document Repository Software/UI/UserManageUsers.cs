using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliamero_Document_Repository_Software.UI
{
    public partial class UserManageUsers : UserControl
    {
        public UserManageUsers()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        void Reset()
        {
            txtConfirmPassword.Clear();
            txtPassword.Clear();
            txtSearch.Clear();
            txtUserID.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
    }
}
