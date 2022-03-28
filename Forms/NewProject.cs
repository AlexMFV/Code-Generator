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

            //TODO: Should load all values from cache regarding global variables, etc (MAYBE SHOULD BE PUT INSIDE APPLICATION.RUN)

            if(GlobalFunctions.USE_MAIN_DISK)
                txtLocation.Text = Path.Combine(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86)), GlobalFunctions.PROJECTS_FOLDER_NAME);
            else
                txtLocation.Text = Path.Combine(GlobalFunctions.PROJECTS_FOLDER_LOCATION, GlobalFunctions.PROJECTS_FOLDER_NAME);
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

            //When creating a new project, if accepted add it to the database (path, names, properties, etc)
            //Have a column on the DB that sets the project as the default.
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
