namespace Ally_Local
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabFileLists = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvCompulsory = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvAdditional = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btNewFile = new System.Windows.Forms.Button();
            this.btLoadFile = new System.Windows.Forms.Button();
            this.btProfile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btCompile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btRun = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.tabOutput = new System.Windows.Forms.TabControl();
            this.tpCompiledOutput = new System.Windows.Forms.TabPage();
            this.tbCompiledOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabFileLists.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tpCompiledOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tabFileLists);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.btNewFile);
            this.splitContainer1.Panel1.Controls.Add(this.btLoadFile);
            this.splitContainer1.Panel1.Controls.Add(this.btProfile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(856, 456);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabFileLists
            // 
            this.tabFileLists.Controls.Add(this.tabPage1);
            this.tabFileLists.Controls.Add(this.tabPage2);
            this.tabFileLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFileLists.Location = new System.Drawing.Point(0, 25);
            this.tabFileLists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFileLists.Name = "tabFileLists";
            this.tabFileLists.SelectedIndex = 0;
            this.tabFileLists.Size = new System.Drawing.Size(126, 317);
            this.tabFileLists.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvCompulsory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(118, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compulsory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvCompulsory
            // 
            this.lvCompulsory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCompulsory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCompulsory.FullRowSelect = true;
            this.lvCompulsory.GridLines = true;
            this.lvCompulsory.HideSelection = false;
            this.lvCompulsory.Location = new System.Drawing.Point(2, 2);
            this.lvCompulsory.Name = "lvCompulsory";
            this.lvCompulsory.Size = new System.Drawing.Size(114, 287);
            this.lvCompulsory.TabIndex = 8;
            this.lvCompulsory.UseCompatibleStateImageBehavior = false;
            this.lvCompulsory.View = System.Windows.Forms.View.Details;
            this.lvCompulsory.SelectedIndexChanged += new System.EventHandler(this.LvCompulsory_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvAdditional);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(147, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Additional";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvAdditional
            // 
            this.lvAdditional.AllowDrop = true;
            this.lvAdditional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAdditional.FullRowSelect = true;
            this.lvAdditional.GridLines = true;
            this.lvAdditional.HideSelection = false;
            this.lvAdditional.Location = new System.Drawing.Point(2, 2);
            this.lvAdditional.Name = "lvAdditional";
            this.lvAdditional.Size = new System.Drawing.Size(143, 354);
            this.lvAdditional.TabIndex = 9;
            this.lvAdditional.UseCompatibleStateImageBehavior = false;
            this.lvAdditional.View = System.Windows.Forms.View.Details;
            this.lvAdditional.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.LvAdditional_AfterLabelEdit);
            this.lvAdditional.SelectedIndexChanged += new System.EventHandler(this.LvAdditional_SelectedIndexChanged);
            this.lvAdditional.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvAdditional_DragDrop);
            this.lvAdditional.DragOver += new System.Windows.Forms.DragEventHandler(this.LvAdditional_DragOver);
            this.lvAdditional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvAdditional_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 25);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercises";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRefresh
            // 
            this.btRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(72, 2);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(52, 20);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btNewFile
            // 
            this.btNewFile.AutoSize = true;
            this.btNewFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewFile.Location = new System.Drawing.Point(0, 342);
            this.btNewFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNewFile.Name = "btNewFile";
            this.btNewFile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btNewFile.Size = new System.Drawing.Size(126, 38);
            this.btNewFile.TabIndex = 6;
            this.btNewFile.Text = "New File";
            this.btNewFile.UseVisualStyleBackColor = true;
            this.btNewFile.Click += new System.EventHandler(this.btNewFile_Click);
            // 
            // btLoadFile
            // 
            this.btLoadFile.AutoSize = true;
            this.btLoadFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadFile.Location = new System.Drawing.Point(0, 380);
            this.btLoadFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLoadFile.Name = "btLoadFile";
            this.btLoadFile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btLoadFile.Size = new System.Drawing.Size(126, 38);
            this.btLoadFile.TabIndex = 3;
            this.btLoadFile.Text = "Load File";
            this.btLoadFile.UseVisualStyleBackColor = true;
            this.btLoadFile.Click += new System.EventHandler(this.btLoadFile_Click);
            // 
            // btProfile
            // 
            this.btProfile.AutoSize = true;
            this.btProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProfile.Location = new System.Drawing.Point(0, 418);
            this.btProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btProfile.Name = "btProfile";
            this.btProfile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btProfile.Size = new System.Drawing.Size(126, 38);
            this.btProfile.TabIndex = 1;
            this.btProfile.Text = "Student Profile";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.tbCode);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel2.Controls.Add(this.tabOutput);
            this.splitContainer2.Size = new System.Drawing.Size(726, 456);
            this.splitContainer2.SplitterDistance = 337;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbCode
            // 
            this.tbCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.tbCode.AutoScrollMinSize = new System.Drawing.Size(351, 144);
            this.tbCode.BackBrush = null;
            this.tbCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.tbCode.CharHeight = 18;
            this.tbCode.CharWidth = 10;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Courier New", 12F);
            this.tbCode.IsReplaceMode = false;
            this.tbCode.Language = FastColoredTextBoxNS.Language.CSharp;
            this.tbCode.LeftBracket = '(';
            this.tbCode.LeftBracket2 = '{';
            this.tbCode.Location = new System.Drawing.Point(0, 33);
            this.tbCode.Name = "tbCode";
            this.tbCode.Paddings = new System.Windows.Forms.Padding(0);
            this.tbCode.RightBracket = ')';
            this.tbCode.RightBracket2 = '}';
            this.tbCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbCode.ServiceColors")));
            this.tbCode.Size = new System.Drawing.Size(726, 304);
            this.tbCode.TabIndex = 1;
            this.tbCode.Text = "// Type your code here\r\n#include <stdio.h>\r\nint main() {\r\n   printf(\"Enter name: " +
    "\");\r\n   scanf(\"%s\", strName);\r\n   printf(\"Hello %s!\", strName);\r\n   return 1;\r\n}" +
    "";
            this.tbCode.Zoom = 100;
            this.tbCode.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbCode_DragDrop);
            this.tbCode.DragOver += new System.Windows.Forms.DragEventHandler(this.TbCode_DragOver);
            this.tbCode.Leave += new System.EventHandler(this.tbCode_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btCompile);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.btRun);
            this.panel1.Controls.Add(this.btTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 33);
            this.panel1.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(482, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(61, 33);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCompile
            // 
            this.btCompile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompile.Location = new System.Drawing.Point(543, 0);
            this.btCompile.Name = "btCompile";
            this.btCompile.Size = new System.Drawing.Size(61, 33);
            this.btCompile.TabIndex = 4;
            this.btCompile.Text = "Compile";
            this.btCompile.UseVisualStyleBackColor = true;
            this.btCompile.Click += new System.EventHandler(this.btCompile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(0, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblFileName.Size = new System.Drawing.Size(604, 33);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "(select a file from exercise list)";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRun
            // 
            this.btRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(604, 0);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(61, 33);
            this.btRun.TabIndex = 2;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btTest
            // 
            this.btTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTest.Location = new System.Drawing.Point(665, 0);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(61, 33);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Visible = false;
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.tpCompiledOutput);
            this.tabOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOutput.Location = new System.Drawing.Point(0, 0);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.SelectedIndex = 0;
            this.tabOutput.Size = new System.Drawing.Size(726, 115);
            this.tabOutput.TabIndex = 0;
            // 
            // tpCompiledOutput
            // 
            this.tpCompiledOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.tpCompiledOutput.Controls.Add(this.tbCompiledOutput);
            this.tpCompiledOutput.Location = new System.Drawing.Point(4, 22);
            this.tpCompiledOutput.Name = "tpCompiledOutput";
            this.tpCompiledOutput.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpCompiledOutput.Size = new System.Drawing.Size(718, 89);
            this.tpCompiledOutput.TabIndex = 0;
            this.tpCompiledOutput.Text = "Compiled Output";
            // 
            // tbCompiledOutput
            // 
            this.tbCompiledOutput.BackColor = System.Drawing.SystemColors.Control;
            this.tbCompiledOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCompiledOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompiledOutput.Location = new System.Drawing.Point(3, 3);
            this.tbCompiledOutput.Multiline = true;
            this.tbCompiledOutput.Name = "tbCompiledOutput";
            this.tbCompiledOutput.Size = new System.Drawing.Size(712, 83);
            this.tbCompiledOutput.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Programming (38PROG)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabFileLists.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tpCompiledOutput.ResumeLayout(false);
            this.tpCompiledOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabOutput;
        private System.Windows.Forms.TabPage tpCompiledOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTest;
        private FastColoredTextBoxNS.FastColoredTextBox tbCode;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btLoadFile;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.TextBox tbCompiledOutput;
        private System.Windows.Forms.Button btNewFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btCompile;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TabControl tabFileLists;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvCompulsory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvAdditional;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefresh;
    }
}

