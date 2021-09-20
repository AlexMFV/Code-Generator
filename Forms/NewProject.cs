using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
