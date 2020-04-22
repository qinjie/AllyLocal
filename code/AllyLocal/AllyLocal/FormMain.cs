using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ally_Local.helpers;
using Ally_Local.my_helpers;
using Microsoft.VisualBasic;

namespace Ally_Local
{
    public partial class FormMain : Form
    {
        private string currentFilePath;
        // private int selectedIndex_Compulsory = -1;
        // private int selectedIndex_Additional = -1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            FormSetup f = new FormSetup();
            f.ShowDialog();
            UpdateWithListItem(null);
        }

        public void SetTitle()
        {
            string strName = ConfigSettings.GetSetting(MyConfig.Key_StudentName).Trim();
            if (string.IsNullOrEmpty(strName))
            {
                this.Text = MyConfig.Key_Title;
            }
            else
            {
                this.Text = MyConfig.Key_Title + " - " + strName;
            }
        }

        // public void ReloadFile()
        // {
        //     // Reload file if selected file is valid
        //     if (!string.IsNullOrEmpty(this.currentFilePath))
        //     {
        //         // Read from file
        //         string content = FileHelper.ReadFile(this.currentFilePath, true,
        //             MyConfig.GetSetting(MyConfig.Key_StudentName));
        //
        //         // Load it to Text
        //         tbCode.Text = content;
        //         lblFileName.Text = Path.GetFileName(this.currentFilePath);
        //     }
        //     else
        //     {
        //         tbCode.Text = "";
        //         lblFileName.Text = "(select a file from exercise list)";
        //     }
        // }

        public void LoadFileLists()
        {
            string[] list = FileHelper.ListFiles(MyFileHelper.GetSubfolderPath(MyFileHelper.FOLDER_COMPULSORY));
            lvCompulsory.View = View.Details;
            lvCompulsory.Columns.Add("FileName", -2);
            lvCompulsory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvCompulsory.Items.Clear();
            foreach (string file in list)
            {
                string name = Path.GetFileName(file);
                ListViewItem item = lvCompulsory.Items.Add(new ListViewItem(new string[] {name}));

                item.Tag = file;
            }

            list = FileHelper.ListFiles(MyFileHelper.GetSubfolderPath(MyFileHelper.FOLDER_ADDITIONAL));
            lvAdditional.View = View.Details;
            lvAdditional.Columns.Add("FileName", -2);
            lvAdditional.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvAdditional.Items.Clear();
            foreach (string file in list)
            {
                string name = Path.GetFileName(file);
                ListViewItem item = lvAdditional.Items.Add(new ListViewItem(new string[] {name}));
                item.Tag = file;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetToolTip();
            btRefresh.PerformClick();

            this.Location = new Point(0, 0);
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.Size = new Size(w/2, h);
        }

        private System.Windows.Forms.ToolTip toolTip1;

        private void SetToolTip()
        {
            toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.InitialDelay = 500;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btCompile, "Compile Code (CTRL+X)");
            toolTip1.SetToolTip(this.btRun, "Run Code (CTRL+R)");
            toolTip1.SetToolTip(this.btSave, "Save Code (CTRL+S)");
            toolTip1.SetToolTip(this.btNewFile, "Create New File (CTRL+N)");
            toolTip1.SetToolTip(this.btLoadFile, "Load Existing File (CTRL+L, or Drag and drop files)");
            toolTip1.SetToolTip(this.tbCode, "(Load files by Drag & Drop)");
            toolTip1.SetToolTip(this.lvAdditional, "(Load files by Drag & Drop)");
        }

        // Shortcut keys for buttons
        private const Keys CompileFileKeys = Keys.Control | Keys.X;
        private const Keys NewFileKeys = Keys.Control | Keys.N;
        private const Keys RunFileKeys = Keys.Control | Keys.R;
        private const Keys LoadFileKeys = Keys.Control | Keys.L;
        private const Keys SaveFileKeys = Keys.Control | Keys.S;

        // Disable paste
        private const Keys PasteKeys = Keys.Control | Keys.V;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == CompileFileKeys)
            {
                btCompile.PerformClick();
                // Compile code

                return true;
            }
            else if (keyData == RunFileKeys)
            {
                btRun.PerformClick();
                // Run code

                return true;
            }
            else if (keyData == NewFileKeys)
            {
                // New file
                btNewFile.PerformClick();
                return true;
            }
            else if (keyData == LoadFileKeys)
            {
                // New file
                btLoadFile.PerformClick();
                return true;
            }
            else if (keyData == SaveFileKeys)
            {
                // New file
                btSave.PerformClick();
                return true;
            }
            else if (keyData == PasteKeys)
            {
                // Allow lecturer to paste
                string name = MyConfig.GetSetting(MyConfig.Key_StudentName);
                string super_user_prefix = MyConfig.GetSetting(MyConfig.Key_SuperUserPrefix);
                if (name.ToLower().StartsWith(super_user_prefix))
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btCompile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCode.Text))
                return;

            btCompile.Enabled = false;
            CompileCode(tbCode.Text);
            splitContainer2.SplitterDistance = (int) (splitContainer2.Height * 4.0 / 5.0);
            btCompile.Enabled = true;
        }

        private bool CompileCode(string code)
        {
            string[] result = TccHelper.CompileByTcc(code);
            if (!String.IsNullOrEmpty(result[0]))
            {
                tbCompiledOutput.BackColor = Color.PeachPuff;
                tbCompiledOutput.Text = result[0];
                return false;
            }

            tbCompiledOutput.BackColor = Color.Gainsboro;
            if (!string.IsNullOrEmpty(result[1]))
            {
                tbCompiledOutput.Text = "Compiled Error: " + Environment.NewLine
                                                           + "---------------" + Environment.NewLine
                                                           + result[1];
            }
            else
            {
                tbCompiledOutput.Text = "Compiled successfully";
            }

            return true;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            btRun.Enabled = false;
            string code = tbCode.Text;
            bool success = CompileCode(code);


            // if (success)
            // {
            //     TccHelper.RunByTcc(code);
            // }
            // else
            // {
            //     splitContainer2.SplitterDistance = (int) (splitContainer2.Height * 4.0 / 5.0);
            // }

            splitContainer2.SplitterDistance = (int) (splitContainer2.Height * 4.0 / 5.0);
            TccHelper.RunByTcc(code);
            btRun.Enabled = true;
        }

        private void LvCompulsory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.currentFilePath) && File.Exists(this.currentFilePath))
            {
                // save all the data for item at index PrevoiusSelectedIndex 
                string content = tbCode.Text;
                FileHelper.WriteFile(this.currentFilePath, content, true,
                    MyConfig.GetSetting(MyConfig.Key_StudentHash));
            }

            if (this.lvCompulsory.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCompulsory.SelectedItems[0];
                UpdateWithListItem(item);
            }
        }

        private void LvAdditional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.currentFilePath) && File.Exists(this.currentFilePath))
            {
                // save all the data for item at index PrevoiusSelectedIndex 
                string content = tbCode.Text;
                FileHelper.WriteFile(this.currentFilePath, content, true,
                    MyConfig.GetSetting(MyConfig.Key_StudentHash));
            }

            if (this.lvAdditional.SelectedItems.Count > 0)
            {
                ListViewItem item = lvAdditional.SelectedItems[0];
                UpdateWithListItem(item);
            }
        }

        // private int SetListItem(ListView.SelectedListViewItemCollection list)
        // {
        //     int selectedIndex = -1;
        //
        //     foreach (ListViewItem item in list)
        //     {
        //         string filePath = (string) item.Tag;
        //         // this.lblFileName.Text = filePath;
        //         this.lblFileName.Text = Path.GetFileName(filePath);
        //         this.currentFilePath = filePath;
        //         selectedIndex = item.Index;
        //
        //         // Read from file
        //         string content = FileHelper.ReadFile(filePath, true, MyConfig.GetSetting(MyConfig.Key_StudentName));
        //
        //         // Load it to Text
        //         tbCode.Text = content;
        //     }
        //
        //     return selectedIndex;
        // }

        private void btSave_Click(object sender, EventArgs e)
        {
            string filePath = this.currentFilePath;

            if (!string.IsNullOrEmpty(filePath))
            {
                string content = tbCode.Text;
                FileHelper.WriteFile(filePath, content, true, MyConfig.GetSetting(MyConfig.Key_StudentHash));
            }
            else
            {
                MessageBox.Show("File path not defined");
            }
        }

        private void tbCode_Leave(object sender, EventArgs e)
        {
            string content = tbCode.Text;
            FileHelper.WriteFile(this.currentFilePath, content, true, MyConfig.GetSetting(MyConfig.Key_StudentHash));
        }

        private void btNewFile_Click(object sender, EventArgs e)
        {
            string filename = Interaction.InputBox("Enter file name", "Create New File", "myfile.c", -1, -1);
            if (string.IsNullOrEmpty(filename.Trim()))
            {
                return;
            }
            if (!filename.EndsWith(".c"))
            {
                filename = filename + ".c";
            }
            filename = FileHelper.SanitizeFileName(filename);
            if (!string.IsNullOrEmpty(filename))
            {
                // Create new file and add to additional_list
                string toFolder = MyFileHelper.GetSubfolderPath(MyFileHelper.FOLDER_ADDITIONAL);
                string filePath = Path.Combine(toFolder, filename);
                if (File.Exists(filePath))
                {
                    MessageBox.Show($"File name already exists: {filename}", "Create File Failed",
                        MessageBoxButtons.OK);
                    return;
                }

                if (!string.IsNullOrEmpty(filePath))
                {
                    FileHelper.WriteFile(filePath, "");
                    tabFileLists.SelectTab(1);
                    ListViewItem item = lvAdditional.Items.Add(new ListViewItem(new string[] {filename}));
                    item.Tag = filePath;
                    lvAdditional.SelectedItems.Clear();
                    lvAdditional.Items[item.Index].Focused = true;
                    lvAdditional.Items[item.Index].Selected = true;
                }
            }
        }

        private void btLoadFile_Click(object sender, EventArgs e)
        {
            var inputFile = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "C files (*.c)|*.c|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    inputFile = openFileDialog.FileName;
                    AddFileToAdditionalListView(inputFile);
                }
            }
        }

        public void AddFileToAdditionalListView(string inputFile)
        {
            // Copy the file into "additional" folder
            string fileName = Path.GetFileName(inputFile);
            string destFile = Path.Combine(MyFileHelper.GetSubfolderPath(MyFileHelper.FOLDER_ADDITIONAL), fileName);

            bool exists = File.Exists(destFile);
            if (exists)
            {
                DialogResult answer = MessageBox.Show($"Overwrite existing file: {fileName}?",
                    "Overwrite File", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    return;
                }
            }

            string content = FileHelper.ReadFile(inputFile);
            FileHelper.WriteFile(destFile, content, true, MyConfig.GetSetting(MyConfig.Key_StudentHash));

            tabFileLists.SelectTab(1);
            ListViewItem item = null;
            if (!exists)
            {
                item = lvAdditional.Items.Add(new ListViewItem(new string[] {fileName}));
                item.Tag = destFile;
            }
            else
            {
                item = lvAdditional.FindItemWithText(fileName);
            }

            if (item != null)
            {
                UpdateWithListItem(item);
                lvAdditional.SelectedItems.Clear();
                lvAdditional.Items[item.Index].Focused = true;
                lvAdditional.Items[item.Index].Selected = true;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            string name = MyConfig.GetSetting(MyConfig.Key_StudentName);
            if (string.IsNullOrEmpty(name))
            {
                FormSetup f = new FormSetup();
                f.ShowDialog();
            }

            if (string.IsNullOrEmpty(MyConfig.GetSetting(MyConfig.Key_StudentName).Trim()))
            {
                MessageBox.Show("Name must be set to use the program", "Empty Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                Environment.Exit(0);
            }

            string hash = MyConfig.GetSetting(MyConfig.Key_StudentHash);
            if (hash != MyConfig.GetHashFromName(name))
            {
                hash = MyConfig.GetHashFromName(name);
                MyConfig.SetSetting(MyConfig.Key_StudentHash, hash);
            }

            MyFileHelper.CopyExerciseFolders();
            MyFileHelper.GenerateEmptyFilesFromList();

            SetTitle();
            LoadFileLists();
            lvCompulsory.SelectedItems.Clear();
            lvAdditional.SelectedItems.Clear();
            UpdateWithListItem();
        }


        private void LvAdditional_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvAdditional.SelectedItems.Count <= 0)
                return;

            if (e.KeyData == Keys.F2)
            {
                lvAdditional.LabelEdit = true;
                lvAdditional.SelectedItems[0].BeginEdit();
            }
            else if (e.KeyData == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show($"Confirm to delete file: {lvAdditional.SelectedItems[0].Text}?",
                    "Delete File",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //delete file
                    ListViewItem item = lvAdditional.SelectedItems[0];
                    string filePath = (string) item.Tag;
                    try
                    {
                        File.Delete(filePath);
                        lvAdditional.Items[item.Index].Remove();
                        UpdateWithListItem(null);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void UpdateWithListItem(ListViewItem item = null)
        {
            if (item != null)
            {
                this.currentFilePath = (string) item.Tag;

                // Read from file
                string content = FileHelper.ReadFile(this.currentFilePath, true,
                    MyConfig.GetSetting(MyConfig.Key_StudentHash));
                tbCode.Text = content;

                lblFileName.Text = Path.GetFileName(this.currentFilePath);
            }
            else
            {
                this.currentFilePath = "";
                tbCode.Text = "";
                lblFileName.Text = "(Select a file from exercise list)";
            }

            tbCompiledOutput.Text = "";
            splitContainer2.SplitterDistance = splitContainer2.Height;
        }

        private void LvAdditional_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Ignore if nothing is changed
            if (e.Label == null)
                return;

            // Sanitize text so that it will be file name
            string newFileName = FileHelper.SanitizeFileName(e.Label.Trim());

            // Cancel edit if such file exists
            string folderPath = Path.GetDirectoryName(this.currentFilePath);
            string newFilePath = Path.Combine(folderPath, newFileName);

            if (File.Exists(newFilePath))
            {
                // Cancel if same filename already exists
                e.CancelEdit = true;
                MessageBox.Show($"File already exists: {newFileName}", "Rename Failed", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    // Rename original file
                    System.IO.File.Move(this.currentFilePath, newFilePath);
                    lvAdditional.SelectedItems[0].Text = newFileName;
                    lvAdditional.SelectedItems[0].Tag = newFilePath;
                    UpdateWithListItem(lvAdditional.SelectedItems[0]);
                }
                catch (Exception ex)
                {
                }
            }
        }


        private void LvAdditional_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                foreach (string file in files)
                {
                    AddFileToAdditionalListView(file);
                }
            }
        }

        private void TbCode_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TbCode_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                foreach (string file in files)
                {
                    AddFileToAdditionalListView(file);
                }
            }
        }

        private void LvAdditional_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}