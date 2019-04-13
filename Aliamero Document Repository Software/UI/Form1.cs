using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliamero_Document_Repository_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 97);
            sidePanel.BringToFront();
            userDashboard.Visible = true;
            userDashboard.BringToFront();
            BtnNew.Visible = false;
            BtnDesignation.Visible = false;
            BtnNew.Visible = false;
            BtnDepartment.Visible = false;
            BtnClientDocuments.Visible = false;
            BtnVendorDocuments.Visible = false;
            BtnDocumentTypes.Visible = false;
            BtnManageDocuments.Visible = false;
            BtnNewSystemUsers.Visible = false;
            BtnManageUsers.Visible = false;
            BtnDocuments.Visible = true;
            btnEmployees.Visible = true;
            BtnDocuments.Visible = true;
            BtnSystemUsers.Visible = true;
            BtnSecuritySettings.Visible = true;
            BtnEmailSettings.Visible = true;
            userAboutBox.Visible = false;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 148);
            sidePanel.BringToFront();
            i = i + 1;
            if (i%2==0)
            {
                BtnNew.Visible = true;
                BtnDocuments.Visible = false;
                BtnDesignation.Visible = true;
                BtnSystemUsers.Visible = false;
                BtnDepartment.Visible = true;
                BtnClientDocuments.Visible = false;
                BtnVendorDocuments.Visible = false;
                BtnManageDocuments.Visible = false;
                BtnDocumentTypes.Visible = false;
                BtnSecuritySettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageUsers.Visible = false;
                userAboutBox.Visible = false;
            }
            else
            {
                BtnNew.Visible = false;
                BtnDocuments.Visible = true;
                BtnDesignation.Visible = false;
                BtnSystemUsers.Visible = true;
                BtnDepartment.Visible = false;
                BtnClientDocuments.Visible = false;
                BtnVendorDocuments.Visible = false;
                BtnManageDocuments.Visible = false;
                BtnDocumentTypes.Visible = false;
                BtnSecuritySettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageUsers.Visible = false;
                BtnEmailSettings.Visible = true;
                userAboutBox.Visible = false;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            userNewEmployee.Visible = true;
            userNewEmployee.BringToFront();
            userAboutBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnNew.Visible = false;
            BtnDocuments.Visible = true;
            btnEmployees.Visible = true;
            btnDashboard.Visible = true;
            BtnEmailSettings.Visible = true;
            BtnSecuritySettings.Visible = true;
            BtnSystemUsers.Visible = true;
            userNewEmployee.Visible = false;
            userDashboard.Visible = true;
            userDesignation.Visible = false;
            userClientDocuments.Visible = false;
            userVendorDocuments.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userManageUsers.Visible = false;
            userNewSystemUsers.Visible = false;
            userNewDepartment.Visible = false;
            BtnDesignation.Visible = false;
            BtnClientDocuments.Visible = false;
            BtnVendorDocuments.Visible = false;
            BtnDocumentTypes.Visible = false;
            BtnManageDocuments.Visible = false;
            BtnNewSystemUsers.Visible = false;
            BtnManageUsers.Visible = false;
            BtnNewSystemUsers.Visible = false;
            BtnManageUsers.Visible = false;
            BtnDepartment.Visible = false;
            userAboutBox.Visible = false;
        }

        private void BtnDesignation_Click(object sender, EventArgs e)
        {
            userDesignation.Visible = true;
            userDesignation.BringToFront();
            userDashboard.Visible = false;
            userNewEmployee.Visible = false;
            userManageUsers.Visible = false;
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userNewDepartment.Visible = false;
            userVendorDocuments.Visible = false;
            userAboutBox.Visible = false;
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 198);
            sidePanel.BringToFront();
            i = i + 1;
            if (i%2==0)
            {
                BtnSystemUsers.Visible = false;
                BtnSecuritySettings.Visible = false;
                BtnClientDocuments.Visible = true;
                BtnVendorDocuments.Visible = true;
                BtnDocumentTypes.Visible = true;
                BtnManageDocuments.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageUsers.Visible = false;
                userAboutBox.Visible = false;
            }
            else
            {
                BtnSystemUsers.Visible = true;
                BtnSecuritySettings.Visible = true;
                BtnClientDocuments.Visible = false;
                BtnVendorDocuments.Visible = false;
                BtnDocumentTypes.Visible = false;
                BtnManageDocuments.Visible = false;
                BtnNewSystemUsers.Visible = false;
                BtnManageUsers.Visible = false;
                BtnEmailSettings.Visible = true;
                userAboutBox.Visible = false;
            }
        }

        private void BtnClientDocuments_Click(object sender, EventArgs e)
        {
            userClientDocuments.Visible = true;
            userClientDocuments.BringToFront();
        }

        private void BtnVendorDocuments_Click(object sender, EventArgs e)
        {
            userVendorDocuments.Visible = true;
            userVendorDocuments.BringToFront();
        }

        private void BtnManageDocuments_Click(object sender, EventArgs e)
        {
            userManageDocuments.Visible = true;
            userManageDocuments.BringToFront();
        }

        private void BtnDocumentTypes_Click(object sender, EventArgs e)
        {
            userDocumentTypes.Visible = true;
            userDocumentTypes.BringToFront();
            userDashboard.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userClientDocuments.Visible = false;
            userManageDocuments.Visible = false;
            userDashboard.Visible = false;
            userClientDocuments.Visible = false;
            userVendorDocuments.Visible = false;
            userNewEmployee.Visible = false;
            userDesignation.Visible = false;
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDesignation.Visible = false;
            userManageDocuments.Visible = false;
            userNewDepartment.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userAboutBox.Visible = false;
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        { 
            userManageUsers.Visible = true;
            userManageUsers.BringToFront();
            userDashboard.Visible = false;
            userClientDocuments.Visible = false;
            userVendorDocuments.Visible = false;
            userNewEmployee.Visible = false;
            userDocumentTypes.Visible = false;
            userDesignation.Visible = false;
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDesignation.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userNewDepartment.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userAboutBox.Visible = false;
            userNewSystemUsers.Visible = false;
        }

        private void BtnSystemUsers_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 247);
            sidePanel.BringToFront();
            i = i + 1;
            if (i%2==0)
            {
                BtnSecuritySettings.Visible = false;
                BtnEmailSettings.Visible = true;
                BtnNewSystemUsers.Visible = true;
                BtnManageUsers.Visible = true;
                userAboutBox.Visible = false;
            }
            else
            {
                BtnSecuritySettings.Visible = true;
                BtnEmailSettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageUsers.Visible = false;
                userAboutBox.Visible = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 395);
            sidePanel.BringToFront();
            if (MessageBox.Show("Are you sure you want to quit?", "Exiting", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            sidePanel.Location = new Point(0, 97);
            sidePanel.BringToFront();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            userNewDepartment.Visible = true;
            userNewDepartment.BringToFront();
            userDesignation.Visible = false;
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDesignation.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userManageUsers.Visible = false;
            userAboutBox.Visible = false;
        }

        private void BtnNewSystemUsers_Click(object sender, EventArgs e)
        {
            userNewSystemUsers.Visible = true;
            userNewSystemUsers.BringToFront();
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDesignation.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userNewDepartment.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userManageUsers.Visible = false;
            userAboutBox.Visible = false;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 396);
            sidePanel.BringToFront();
            userAboutBox.Visible = true;
            userAboutBox.BringToFront();
            userClientDocuments.Visible = false;
            userDashboard.Visible = false;
            userDesignation.Visible = false;
            userDocumentTypes.Visible = false;
            userManageDocuments.Visible = false;
            userNewDepartment.Visible = false;
            userNewEmployee.Visible = false;
            userVendorDocuments.Visible = false;
            userManageUsers.Visible = false;
        }
    }
}
