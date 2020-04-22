using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ally_Local.helpers;
using Ally_Local.my_helpers;

namespace Ally_Local
{
    public partial class FormSetup : Form
    {
        public FormSetup()
        {
            InitializeComponent();
        }

        private string strName;

        private void FormSignup_Load(object sender, EventArgs e)
        {
            strName = ConfigSettings.GetSetting(MyConfig.Key_StudentName).Trim();
            tbName.Text = strName;

            bool invalidName = string.IsNullOrEmpty(strName);
            btExport.Enabled = !invalidName;
            btImport.Enabled = !invalidName;
        }

        private void btSetName_Click(object sender, EventArgs e)
        {
            string strNewName = tbName.Text.Trim();
            if (strNewName.ToLower() != strName.ToLower() && !string.IsNullOrEmpty(strName))
            {
                DialogResult dialogResult =
                    MessageBox.Show("Updating name will reset all completed exercises. Continue?",
                        "Update Name", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;
            }

            // Save name and hash to configSetting
            MyConfig.SetSetting(MyConfig.Key_StudentName, strNewName);
            MyConfig.SetSetting(MyConfig.Key_StudentHash, MyConfig.GetHashFromName(strNewName.ToLower()));

            // Copy all exercises
            MyFileHelper.CopyExerciseFolders();
            MyFileHelper.GenerateEmptyFilesFromList();

            btSetName.Enabled = false;

            Application.Restart();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            strName = MyConfig.GetSetting(MyConfig.Key_StudentName).Trim();
            string strNewName = tbName.Text.Trim();
            if (strName != strNewName)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Discard change in name?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }

            this.Close();
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            strName = MyConfig.GetSetting(MyConfig.Key_StudentName).Trim();
            string strNewName = tbName.Text.Trim();

            if (strNewName == strName || string.IsNullOrWhiteSpace(strNewName))
                btSetName.Enabled = false;
            else
                btSetName.Enabled = true;
        }

        private void BtExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".zip"; // Default file extension
            dialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
            string hash = MyConfig.GetSetting(MyConfig.Key_StudentHash);
            dialog.FileName = hash + ".zip";
            DialogResult result = dialog.ShowDialog(this);
            if (result != DialogResult.OK || string.IsNullOrEmpty(dialog.FileName))
            {
                return;
            }

            try
            {
                if (File.Exists(dialog.FileName))
                    File.Delete(dialog.FileName);

                string zipPath = dialog.FileName;
                string userFolder = MyFileHelper.GetSubfolderPath();
                ZipFile.CreateFromDirectory(userFolder, zipPath);

                MessageBox.Show("Exported: " + dialog.FileName, "Export Profile Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Export Profile Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".zip"; // Default file extension
            dialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
            dialog.FileName = MyConfig.GetSetting(MyConfig.Key_StudentHash) + ".zip";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show(fileName, "File NOT Found");
                    return;
                }

                string userFolder = MyFileHelper.GetUserfolderPath();

                DialogResult dialogResult =
                    MessageBox.Show("This will overwrite existing exercise files. Continue?",
                        "Import Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;

                ZipArchiveExtensions.ExtractZipFileToDirectory(fileName, userFolder, true);

                Application.Restart();
            }
        }
    }
}