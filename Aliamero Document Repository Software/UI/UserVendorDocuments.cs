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
    public partial class UserVendorDocuments : UserControl
    {
        public UserVendorDocuments()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
        void Reset()
        {
            txtDescription.Clear();
            txtDocumentName.Clear();
            txtDocumentNumber.Clear();
            txtUploadedPath.Clear();
            lblSelectDocumentType.Text = "Select vendor";
            lblSelectVendor.Text = "Select Document Type";
            lblSubmittIssuedDate.Text = "Submitt / Issued Date";
            txtDocumentName.Focus();
        }
    }
}
