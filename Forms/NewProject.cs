using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen.GenForms
{
    public partial class NewProject : Form
    {
        bool _isNew;

        public NewProject(bool isNew = false)
        {
            InitializeComponent();
            _isNew = isNew;
            this.FormClosing += NewProject_FormClosing;
            txtLocation.Text = Path.Combine(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86)), "Projects");
        }

        private void NewProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isNew)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Revert changes if any
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _isNew = false;


        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdPath.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
                txtLocation.Text = fbdPath.SelectedPath;
        }

        private void txtFolderName_TextChanged(object sender, EventArgs e)
        {
            if (!txtFolderName.Text.StartsWith("GEN"))
                txtFolderNameFinal.Text = $"GEN{txtFolderName.Text}";
            else
                txtFolderNameFinal.Text = $"{txtFolderName.Text}";
        }
    }
}
