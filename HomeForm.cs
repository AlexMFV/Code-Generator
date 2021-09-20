using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            //CheckForProject();
        }

        #region Main Methods

        public void CheckForProject()
        {
            //Checks if a project is opened (Save on a cache file)
            //If there is no project loaded, open the NewProject window
            //If there is a project cache file try to load the project
            //If the project fails to load ask the user to try again or delete
            //If the user deletes the project or presses the create new button, open the NewProject window

            //If there is no project to load on the AfterLoaded event load the window
            OpenFormAsDialog(new GenForms.NewProject(true));
        }

        public void OpenFormAsDialog(Form form)
        {
            form.ShowDialog();
        }

        public DialogResult ReturnFormAsDialog(Form form)
        {
            DialogResult result = form.ShowDialog();
            return result;
        }

        #endregion

        #region Open Forms

        private void btnServer_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new GenForms.ServerCreate());
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new GenForms.BuildGeneration());
        }

        #endregion

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFormAsDialog(new GenForms.SettingsPath());
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            CheckForProject();
        }
    }
}
