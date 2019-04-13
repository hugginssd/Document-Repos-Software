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
    public partial class UserManageDocuments : UserControl
    {
        public UserManageDocuments()
        {
            InitializeComponent();
        }

        private void BtnBulkActions_Click(object sender, EventArgs e)
        {
            BtnBulkActions.ForeColor = Color.White;
            BtnBulkActions.BackColor = Color.FromArgb(0, 122, 204);
            BtnUndeleted.ForeColor = Color.Gray;
            BtnUndeleted.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnDeleted.ForeColor = Color.Gray;
            BtnDeleted.BackColor = Color.White;
            BtnMissingOwner.ForeColor = Color.Gray;
            BtnMissingOwner.BackColor = Color.White;
        }

        private void BtnUndeleted_Click(object sender, EventArgs e)
        {
            BtnUndeleted.ForeColor = Color.White;
            BtnUndeleted.BackColor = Color.FromArgb(0, 122, 204);
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnDeleted.ForeColor = Color.Gray;
            BtnDeleted.BackColor = Color.White;
            BtnMissingOwner.ForeColor = Color.Gray;
            BtnMissingOwner.BackColor = Color.White;
        }

        private void BtnCheckedOut_Click(object sender, EventArgs e)
        {
            BtnCheckedOut.ForeColor = Color.White;
            BtnCheckedOut.BackColor = Color.FromArgb(0, 122, 204);
            BtnUndeleted.ForeColor = Color.Gray;
            BtnUndeleted.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnDeleted.ForeColor = Color.Gray;
            BtnDeleted.BackColor = Color.White;
            BtnMissingOwner.ForeColor = Color.Gray;
            BtnMissingOwner.BackColor = Color.White;
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            BtnDeleted.ForeColor = Color.White;
            BtnDeleted.BackColor = Color.FromArgb(0, 122, 204);
            BtnUndeleted.ForeColor = Color.Gray;
            BtnUndeleted.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnMissingOwner.ForeColor = Color.Gray;
            BtnMissingOwner.BackColor = Color.White;
        }

        private void BtnMissingOwner_Click(object sender, EventArgs e)
        {
            BtnMissingOwner.ForeColor = Color.White;
            BtnMissingOwner.BackColor = Color.FromArgb(0, 122, 204);
            BtnUndeleted.ForeColor = Color.Gray;
            BtnUndeleted.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnDeleted.ForeColor = Color.Gray;
            BtnDeleted.BackColor = Color.White;
        }
    }
}
