using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliamero_Document_Repository_System.DAL;
using Aliamero_Document_Repository_System.BLL;

namespace Aliamero_Document_Repository_Software.UI
{
    public partial class UserClientDocuments : UserControl
    {
        public UserClientDocuments()
        {
            InitializeComponent();
        }

        private ClientDocumentDAL cdal = new ClientDocumentDAL();
        private ClientDocumentBLL cbll = new ClientDocumentBLL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtDocumentNumber.Text != "Document number" && txtDocumentname.Text != "Document name")
            {
                if (txtUploadedPath.Text != "Upload path" && txtSelectAttachment.Text != "Please select attachment")
                {
                    try
                    {
                        cbll.ClientName = CmbSelectClient.Text.ToUpper();
                        cbll.Description = txtDescription.Text.ToUpper();
                        cbll.DocumentName = txtDocumentname.Text.ToUpper();
                        cbll.SubmittDate = DtpSubmittDate.Value.Date;
                        cbll.DocumentPath = txtUploadedPath.Text;
                        cbll.DocumentType = CmbSelectDocumentType.Text.ToUpper();
                        cbll.DocumentNumber = txtDocumentNumber.Text.ToUpper();

                        bool IsSuccess = cdal.Insert(cbll);
                        if (IsSuccess)
                        {
                            MessageBox.Show("Successfully uploaded", "Document upload", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Reset();
                            DataTable dt = new DataTable();
                            dt = cdal.Select();
                            dataGridView1.DataSource = dt;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to initiate document upload", "Document upload",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "UI error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                MessageBox.Show("Invalid parameters", "Document parameters",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;

            }
            MessageBox.Show("Invalid parameters", "Document parameters",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
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

        private void UserClientDocuments_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cdal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}
