namespace Aliamero_Document_Repository_Software.UI
{
    partial class UserVendorDocuments
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVersionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.hintTextBox4 = new Windows.Forms.HintTextBox(this.components);
            this.txtUploadedPath = new Windows.Forms.HintTextBox(this.components);
            this.lblSubmittIssuedDate = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtDocumentName = new Windows.Forms.HintTextBox(this.components);
            this.lblSelectDocumentType = new System.Windows.Forms.Label();
            this.lblSelectVendor = new System.Windows.Forms.Label();
            this.txtDescription = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DtpSubmittIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(278, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 477);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vender Documents List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocumentName,
            this.colDocumentID,
            this.colDocumentDate,
            this.colVersionNumber,
            this.colExpiryDate});
            this.dataGridView1.Location = new System.Drawing.Point(2, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // colDocumentName
            // 
            this.colDocumentName.HeaderText = "DOCUMENT NAME";
            this.colDocumentName.Name = "colDocumentName";
            this.colDocumentName.Width = 150;
            // 
            // colDocumentID
            // 
            this.colDocumentID.HeaderText = "DOCUMENT ID";
            this.colDocumentID.Name = "colDocumentID";
            this.colDocumentID.Width = 120;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.HeaderText = "DOCUMENT DATE";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.Width = 150;
            // 
            // colVersionNumber
            // 
            this.colVersionNumber.HeaderText = "VERSION NUMBER";
            this.colVersionNumber.Name = "colVersionNumber";
            this.colVersionNumber.Width = 140;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.HeaderText = "EXPIRY DATE";
            this.colExpiryDate.Name = "colExpiryDate";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.hintTextBox4);
            this.panel1.Controls.Add(this.txtUploadedPath);
            this.panel1.Controls.Add(this.lblSubmittIssuedDate);
            this.panel1.Controls.Add(this.txtDocumentNumber);
            this.panel1.Controls.Add(this.txtDocumentName);
            this.panel1.Controls.Add(this.lblSelectDocumentType);
            this.panel1.Controls.Add(this.lblSelectVendor);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DtpSubmittIssuedDate);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 477);
            this.panel1.TabIndex = 2;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(158, 435);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(89, 30);
            this.BtnReset.TabIndex = 42;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(11, 435);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(89, 30);
            this.BtnCreate.TabIndex = 41;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // hintTextBox4
            // 
            this.hintTextBox4.EnterToTab = false;
            this.hintTextBox4.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox4.HintValue = "Please Select Attachment";
            this.hintTextBox4.Location = new System.Drawing.Point(11, 392);
            this.hintTextBox4.Name = "hintTextBox4";
            this.hintTextBox4.Size = new System.Drawing.Size(236, 23);
            this.hintTextBox4.TabIndex = 40;
            this.hintTextBox4.Text = "Please Select Attachment";
            this.hintTextBox4.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox4.Value = "";
            // 
            // txtUploadedPath
            // 
            this.txtUploadedPath.EnterToTab = false;
            this.txtUploadedPath.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadedPath.ForeColor = System.Drawing.Color.Gray;
            this.txtUploadedPath.HintColor = System.Drawing.Color.Gray;
            this.txtUploadedPath.HintValue = "Uploaded Document Path";
            this.txtUploadedPath.Location = new System.Drawing.Point(11, 349);
            this.txtUploadedPath.Name = "txtUploadedPath";
            this.txtUploadedPath.Size = new System.Drawing.Size(236, 23);
            this.txtUploadedPath.TabIndex = 39;
            this.txtUploadedPath.Text = "Uploaded Document Path";
            this.txtUploadedPath.TextForeColor = System.Drawing.Color.Black;
            this.txtUploadedPath.Value = "";
            // 
            // lblSubmittIssuedDate
            // 
            this.lblSubmittIssuedDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubmittIssuedDate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittIssuedDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSubmittIssuedDate.Location = new System.Drawing.Point(10, 216);
            this.lblSubmittIssuedDate.Name = "lblSubmittIssuedDate";
            this.lblSubmittIssuedDate.Size = new System.Drawing.Size(224, 17);
            this.lblSubmittIssuedDate.TabIndex = 38;
            this.lblSubmittIssuedDate.Text = "Submitt / Issued Date";
            this.lblSubmittIssuedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.EnterToTab = false;
            this.txtDocumentNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentNumber.HintColor = System.Drawing.Color.Gray;
            this.txtDocumentNumber.HintValue = "Document number";
            this.txtDocumentNumber.Location = new System.Drawing.Point(11, 171);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(236, 23);
            this.txtDocumentNumber.TabIndex = 37;
            this.txtDocumentNumber.Text = "Document number";
            this.txtDocumentNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtDocumentNumber.Value = "";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.EnterToTab = false;
            this.txtDocumentName.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentName.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentName.HintColor = System.Drawing.Color.Gray;
            this.txtDocumentName.HintValue = "Document name";
            this.txtDocumentName.Location = new System.Drawing.Point(11, 130);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(236, 23);
            this.txtDocumentName.TabIndex = 36;
            this.txtDocumentName.Text = "Document name";
            this.txtDocumentName.TextForeColor = System.Drawing.Color.Black;
            this.txtDocumentName.Value = "";
            // 
            // lblSelectDocumentType
            // 
            this.lblSelectDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectDocumentType.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDocumentType.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectDocumentType.Location = new System.Drawing.Point(12, 92);
            this.lblSelectDocumentType.Name = "lblSelectDocumentType";
            this.lblSelectDocumentType.Size = new System.Drawing.Size(221, 17);
            this.lblSelectDocumentType.TabIndex = 35;
            this.lblSelectDocumentType.Text = "Select Document Type";
            this.lblSelectDocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectVendor
            // 
            this.lblSelectVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectVendor.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVendor.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectVendor.Location = new System.Drawing.Point(13, 52);
            this.lblSelectVendor.Name = "lblSelectVendor";
            this.lblSelectVendor.Size = new System.Drawing.Size(221, 17);
            this.lblSelectVendor.TabIndex = 34;
            this.lblSelectVendor.Text = "Select vendor";
            this.lblSelectVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterToTab = false;
            this.txtDescription.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HintColor = System.Drawing.Color.Gray;
            this.txtDescription.HintValue = "Description";
            this.txtDescription.Location = new System.Drawing.Point(11, 255);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 78);
            this.txtDescription.TabIndex = 33;
            this.txtDescription.Text = "Description";
            this.txtDescription.TextForeColor = System.Drawing.Color.Black;
            this.txtDescription.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vender Documents";
            // 
            // DtpSubmittIssuedDate
            // 
            this.DtpSubmittIssuedDate.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpSubmittIssuedDate.Location = new System.Drawing.Point(9, 214);
            this.DtpSubmittIssuedDate.Name = "DtpSubmittIssuedDate";
            this.DtpSubmittIssuedDate.Size = new System.Drawing.Size(241, 22);
            this.DtpSubmittIssuedDate.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // UserVendorDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserVendorDocuments";
            this.Size = new System.Drawing.Size(996, 493);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVersionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiryDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private Windows.Forms.HintTextBox hintTextBox4;
        private Windows.Forms.HintTextBox txtUploadedPath;
        private System.Windows.Forms.Label lblSubmittIssuedDate;
        private Windows.Forms.HintTextBox txtDocumentNumber;
        private Windows.Forms.HintTextBox txtDocumentName;
        private System.Windows.Forms.Label lblSelectDocumentType;
        private System.Windows.Forms.Label lblSelectVendor;
        private Windows.Forms.HintTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpSubmittIssuedDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
