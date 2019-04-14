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
    public partial class UserDocumentTypes : UserControl
    {
        public UserDocumentTypes()
        {
            InitializeComponent();
        }
        DocumentTypesDAL dtdal = new DocumentTypesDAL();
        DocumentTypesBLL dtbll = new DocumentTypesBLL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (TxtDocumentType.Text != "Document Type" && TxtDocumentID.Text != "Document ID")
            {
                try
                {
                    dtbll.DocumentType = TxtDocumentType.Text.ToUpper();
                    dtbll.SubmittedByEmployee = RdbSubmitt.Checked ? 1 : 0;
                    bool IsSuccess = dtdal.Insert(dtbll);
                    if (IsSuccess)
                    {
                        MessageBox.Show("Successfully created","Document Types",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                        Reset();
                        DataTable dt = new DataTable();
                        dt = dtdal.Select();
                        dataGridView1.DataSource = dt;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to initiate a record","Document Types",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "UI error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }

            }
        }

        void Reset()
        {
            TxtDocumentType.Clear();
            RdbIssue.Checked = false;
            RdbSubmitt.Checked = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UserDocumentTypes_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dtdal.Select();
            dataGridView1.DataSource = dt;
        }
    }
}
