using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Save name to configSetting
            MyConfig.SetSetting(MyConfig.Key_StudentName, strNewName);

            // Reset all exercises
            MyFileHelper.DeleteExerciseFolder();
            MyFileHelper.CopyExerciseFolders();
            MyFileHelper.GenerateEmptyFilesFromList();

            btSetName.Enabled = false;
            // So that form will stay
//            this.DialogResult = DialogResult.None;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            strName = MyConfig.GetSetting(MyConfig.Key_StudentName).Trim();
            string strNewName = tbName.Text.Trim();
            if (strName != strNewName && MyConfig.GetSetting(MyConfig.Key_DisableProfileRename) != "true")
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
            else if (MyConfig.GetSetting(MyConfig.Key_DisableProfileRename) == "true" &&
                     !string.IsNullOrEmpty(strName))
            {
                lblNote.Text = "Chaning name are NOT allowed";
                btSetName.Enabled = false;
            }
            else
                btSetName.Enabled = true;
        }
    }
}