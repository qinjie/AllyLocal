namespace Ally_Local
{
    partial class FormSetup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSetName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSetName
            // 
            this.btSetName.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSetName.Enabled = false;
            this.btSetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetName.Location = new System.Drawing.Point(310, 126);
            this.btSetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetName.Name = "btSetName";
            this.btSetName.Size = new System.Drawing.Size(154, 45);
            this.btSetName.TabIndex = 0;
            this.btSetName.Text = "Set Name";
            this.btSetName.UseVisualStyleBackColor = true;
            this.btSetName.Click += new System.EventHandler(this.btSetName_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(24, 62);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(501, 41);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name:";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(102, 126);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(154, 45);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(198, 14);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(166, 25);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "(case-insensitive)";
            // 
            // btExport
            // 
            this.btExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.Location = new System.Drawing.Point(102, 197);
            this.btExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 45);
            this.btExport.TabIndex = 11;
            this.btExport.Text = "Export Profile";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.BtExport_Click);
            // 
            // btImport
            // 
            this.btImport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.Location = new System.Drawing.Point(310, 197);
            this.btImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(154, 45);
            this.btImport.TabIndex = 12;
            this.btImport.Text = "Import Profile";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.BtImport_Click);
            // 
            // FormSetup
            // 
            this.AcceptButton = this.btSetName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(555, 266);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btSetName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormSetup";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSetName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btImport;
    }
}