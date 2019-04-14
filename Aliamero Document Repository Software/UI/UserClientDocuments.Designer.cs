namespace Aliamero_Document_Repository_Software.UI
{
    partial class UserClientDocuments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelectAttachment = new Windows.Forms.HintTextBox(this.components);
            this.txtUploadedPath = new Windows.Forms.HintTextBox(this.components);
            this.txtDescription = new Windows.Forms.HintTextBox(this.components);
            this.txtDocumentNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtDocumentname = new Windows.Forms.HintTextBox(this.components);
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.lblSubmittIssuedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpSubmittDate = new System.Windows.Forms.DateTimePicker();
            this.CmbSelectDocumentType = new System.Windows.Forms.ComboBox();
            this.CmbSelectClient = new System.Windows.Forms.ComboBox();
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
            this.panel2.Location = new System.Drawing.Point(279, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 483);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Client Documents List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtSelectAttachment);
            this.panel1.Controls.Add(this.txtUploadedPath);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtDocumentNumber);
            this.panel1.Controls.Add(this.txtDocumentname);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.lblSubmittIssuedDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSelectClient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DtpSubmittDate);
            this.panel1.Controls.Add(this.CmbSelectDocumentType);
            this.panel1.Controls.Add(this.CmbSelectClient);
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 483);
            this.panel1.TabIndex = 4;
            // 
            // txtSelectAttachment
            // 
            this.txtSelectAttachment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSelectAttachment.EnterToTab = false;
            this.txtSelectAttachment.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectAttachment.ForeColor = System.Drawing.Color.Gray;
            this.txtSelectAttachment.HintColor = System.Drawing.Color.Gray;
            this.txtSelectAttachment.HintValue = "Please select attachment";
            this.txtSelectAttachment.Location = new System.Drawing.Point(8, 392);
            this.txtSelectAttachment.Name = "txtSelectAttachment";
            this.txtSelectAttachment.Size = new System.Drawing.Size(237, 23);
            this.txtSelectAttachment.TabIndex = 45;
            this.txtSelectAttachment.Text = "Please select attachment";
            this.txtSelectAttachment.TextForeColor = System.Drawing.Color.Black;
            this.txtSelectAttachment.Value = "";
            // 
            // txtUploadedPath
            // 
            this.txtUploadedPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUploadedPath.EnterToTab = false;
            this.txtUploadedPath.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadedPath.ForeColor = System.Drawing.Color.Gray;
            this.txtUploadedPath.HintColor = System.Drawing.Color.Gray;
            this.txtUploadedPath.HintValue = "Upload path";
            this.txtUploadedPath.Location = new System.Drawing.Point(9, 352);
            this.txtUploadedPath.Name = "txtUploadedPath";
            this.txtUploadedPath.Size = new System.Drawing.Size(237, 23);
            this.txtUploadedPath.TabIndex = 44;
            this.txtUploadedPath.Text = "Upload path";
            this.txtUploadedPath.TextForeColor = System.Drawing.Color.Black;
            this.txtUploadedPath.Value = "";
            // 
            // txtDescription
            // 
            this.txtDescription.EnterToTab = false;
            this.txtDescription.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.HintColor = System.Drawing.Color.Gray;
            this.txtDescription.HintValue = "Description";
            this.txtDescription.Location = new System.Drawing.Point(9, 263);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 72);
            this.txtDescription.TabIndex = 43;
            this.txtDescription.Text = "Description";
            this.txtDescription.TextForeColor = System.Drawing.Color.Black;
            this.txtDescription.Value = "";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.EnterToTab = false;
            this.txtDocumentNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentNumber.HintColor = System.Drawing.Color.Gray;
            this.txtDocumentNumber.HintValue = "Document number";
            this.txtDocumentNumber.Location = new System.Drawing.Point(12, 185);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(235, 23);
            this.txtDocumentNumber.TabIndex = 42;
            this.txtDocumentNumber.Text = "Document number";
            this.txtDocumentNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtDocumentNumber.Value = "";
            // 
            // txtDocumentname
            // 
            this.txtDocumentname.EnterToTab = false;
            this.txtDocumentname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentname.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumentname.HintColor = System.Drawing.Color.Gray;
            this.txtDocumentname.HintValue = "Document name";
            this.txtDocumentname.Location = new System.Drawing.Point(12, 132);
            this.txtDocumentname.Name = "txtDocumentname";
            this.txtDocumentname.Size = new System.Drawing.Size(235, 23);
            this.txtDocumentname.TabIndex = 41;
            this.txtDocumentname.Text = "Document name";
            this.txtDocumentname.TextForeColor = System.Drawing.Color.Black;
            this.txtDocumentname.Value = "";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(137, 441);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(110, 33);
            this.BtnReset.TabIndex = 40;
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
            this.BtnCreate.Location = new System.Drawing.Point(11, 441);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(110, 33);
            this.BtnCreate.TabIndex = 34;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblSubmittIssuedDate
            // 
            this.lblSubmittIssuedDate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittIssuedDate.ForeColor = System.Drawing.Color.Gray;
            this.lblSubmittIssuedDate.Location = new System.Drawing.Point(11, 232);
            this.lblSubmittIssuedDate.Name = "lblSubmittIssuedDate";
            this.lblSubmittIssuedDate.Size = new System.Drawing.Size(224, 17);
            this.lblSubmittIssuedDate.TabIndex = 37;
            this.lblSubmittIssuedDate.Text = "Submitt / Issued Date";
            this.lblSubmittIssuedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Select Document Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectClient
            // 
            this.lblSelectClient.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClient.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectClient.Location = new System.Drawing.Point(11, 52);
            this.lblSelectClient.Name = "lblSelectClient";
            this.lblSelectClient.Size = new System.Drawing.Size(224, 17);
            this.lblSelectClient.TabIndex = 34;
            this.lblSelectClient.Text = "Select client";
            this.lblSelectClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Client Documents";
            // 
            // DtpSubmittDate
            // 
            this.DtpSubmittDate.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpSubmittDate.Location = new System.Drawing.Point(9, 230);
            this.DtpSubmittDate.Name = "DtpSubmittDate";
            this.DtpSubmittDate.Size = new System.Drawing.Size(241, 22);
            this.DtpSubmittDate.TabIndex = 25;
            // 
            // CmbSelectDocumentType
            // 
            this.CmbSelectDocumentType.FormattingEnabled = true;
            this.CmbSelectDocumentType.Items.AddRange(new object[] {
            "PROOF ID\'s",
            "QUOTATION",
            "INVOICE"});
            this.CmbSelectDocumentType.Location = new System.Drawing.Point(11, 94);
            this.CmbSelectDocumentType.Name = "CmbSelectDocumentType";
            this.CmbSelectDocumentType.Size = new System.Drawing.Size(236, 21);
            this.CmbSelectDocumentType.TabIndex = 6;
            // 
            // CmbSelectClient
            // 
            this.CmbSelectClient.FormattingEnabled = true;
            this.CmbSelectClient.Location = new System.Drawing.Point(11, 50);
            this.CmbSelectClient.Name = "CmbSelectClient";
            this.CmbSelectClient.Size = new System.Drawing.Size(236, 21);
            this.CmbSelectClient.TabIndex = 4;
            // 
            // UserClientDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserClientDocuments";
            this.Size = new System.Drawing.Size(1004, 490);
            this.Load += new System.EventHandler(this.UserClientDocuments_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label lblSubmittIssuedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpSubmittDate;
        private System.Windows.Forms.ComboBox CmbSelectDocumentType;
        private System.Windows.Forms.ComboBox CmbSelectClient;
        private Windows.Forms.HintTextBox txtDocumentNumber;
        private Windows.Forms.HintTextBox txtDocumentname;
        private Windows.Forms.HintTextBox txtSelectAttachment;
        private Windows.Forms.HintTextBox txtUploadedPath;
        private Windows.Forms.HintTextBox txtDescription;
    }
}
