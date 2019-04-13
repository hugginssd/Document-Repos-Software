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
    public partial class UserClientDocuments : UserControl
    {
        public UserClientDocuments()
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
        void Reset()
        {
            txtDescription.Clear();
            txtDocumentname.Clear();
            txtDocumentNumber.Clear();
            txtSelectAttachment.Clear();
            txtUploadedPath.Clear();
            txtDocumentname.Focus();

        }
    }
}
