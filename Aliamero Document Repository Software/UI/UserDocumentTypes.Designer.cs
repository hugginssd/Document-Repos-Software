namespace Aliamero_Document_Repository_Software.UI
{
    partial class UserDocumentTypes
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RdbSubmitt = new System.Windows.Forms.RadioButton();
            this.RdbIssue = new System.Windows.Forms.RadioButton();
            this.TxtDocumentType = new Windows.Forms.HintTextBox(this.components);
            this.TxtDocumentID = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(203, 258);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(105, 30);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(16, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // RdbSubmitt
            // 
            this.RdbSubmitt.AutoSize = true;
            this.RdbSubmitt.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSubmitt.Location = new System.Drawing.Point(16, 214);
            this.RdbSubmitt.Name = "RdbSubmitt";
            this.RdbSubmitt.Size = new System.Drawing.Size(150, 19);
            this.RdbSubmitt.TabIndex = 19;
            this.RdbSubmitt.TabStop = true;
            this.RdbSubmitt.Text = "Submitted By Employee";
            this.RdbSubmitt.UseVisualStyleBackColor = true;
            // 
            // RdbIssue
            // 
            this.RdbIssue.AutoSize = true;
            this.RdbIssue.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbIssue.Location = new System.Drawing.Point(16, 170);
            this.RdbIssue.Name = "RdbIssue";
            this.RdbIssue.Size = new System.Drawing.Size(130, 19);
            this.RdbIssue.TabIndex = 18;
            this.RdbIssue.TabStop = true;
            this.RdbIssue.Text = "Issued To Employee";
            this.RdbIssue.UseVisualStyleBackColor = true;
            // 
            // TxtDocumentType
            // 
            this.TxtDocumentType.EnterToTab = false;
            this.TxtDocumentType.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumentType.ForeColor = System.Drawing.Color.Gray;
            this.TxtDocumentType.HintColor = System.Drawing.Color.Gray;
            this.TxtDocumentType.HintValue = "Document Type";
            this.TxtDocumentType.Location = new System.Drawing.Point(16, 124);
            this.TxtDocumentType.Name = "TxtDocumentType";
            this.TxtDocumentType.Size = new System.Drawing.Size(292, 23);
            this.TxtDocumentType.TabIndex = 17;
            this.TxtDocumentType.Text = "Document Type";
            this.TxtDocumentType.TextForeColor = System.Drawing.Color.Black;
            this.TxtDocumentType.Value = "";
            // 
            // TxtDocumentID
            // 
            this.TxtDocumentID.Enabled = false;
            this.TxtDocumentID.EnterToTab = false;
            this.TxtDocumentID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumentID.ForeColor = System.Drawing.Color.Gray;
            this.TxtDocumentID.HintColor = System.Drawing.Color.Gray;
            this.TxtDocumentID.HintValue = "Document ID";
            this.TxtDocumentID.Location = new System.Drawing.Point(16, 81);
            this.TxtDocumentID.Name = "TxtDocumentID";
            this.TxtDocumentID.Size = new System.Drawing.Size(292, 23);
            this.TxtDocumentID.TabIndex = 16;
            this.TxtDocumentID.Text = "Document ID";
            this.TxtDocumentID.TextForeColor = System.Drawing.Color.Black;
            this.TxtDocumentID.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Document Types";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDocumentType});
            this.dataGridView1.Location = new System.Drawing.Point(381, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 207);
            this.dataGridView1.TabIndex = 14;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colDocumentType
            // 
            this.colDocumentType.HeaderText = "DOCUMENT TYPE";
            this.colDocumentType.Name = "colDocumentType";
            this.colDocumentType.Width = 250;
            // 
            // UserDocumentTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RdbSubmitt);
            this.Controls.Add(this.RdbIssue);
            this.Controls.Add(this.TxtDocumentType);
            this.Controls.Add(this.TxtDocumentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserDocumentTypes";
            this.Size = new System.Drawing.Size(767, 319);
            this.Load += new System.EventHandler(this.UserDocumentTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RdbSubmitt;
        private System.Windows.Forms.RadioButton RdbIssue;
        private Windows.Forms.HintTextBox TxtDocumentType;
        private Windows.Forms.HintTextBox TxtDocumentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentType;
    }
}
