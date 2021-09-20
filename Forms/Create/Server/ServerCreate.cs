using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gen.GenEnums;

namespace Gen.GenForms
{
    public partial class ServerCreate : Form
    {
        public ServerCreate()
        {
            InitializeComponent();
        }

        private void ServerCreate_Load(object sender, EventArgs e)
        {
            FillComboFromClassEnum(cbbServerLanguage, "ServerType");
        }

        private void FillComboFromClassEnum(ComboBox combo, string enumClass)
        {
            try
            {
                Type klass = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                            from types in assembly.GetTypes()
                            where types.Name == enumClass
                            select types).FirstOrDefault();

                FieldInfo[] classFields = klass.GetFields();

                Dictionary<string, string> values = new Dictionary<string, string>();

                foreach (FieldInfo info in classFields)
                    values.Add(((Tuple<string, string>)info.GetValue(klass)).Item1, ((Tuple<string, string>)info.GetValue(klass)).Item2);

                combo.DataSource = new BindingSource(values, null);
                combo.DisplayMember = "Key";
                combo.ValueMember = "Value";
                combo.SelectedIndex = combo.Items.Count > 0 ? 0 : -1;
            }
            catch(Exception ex)
            {
                GlobalFunctions.SendException(ex);
            }
        }

        private void cbbServerLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiletype.Text = ((KeyValuePair<string, string>)cbbServerLanguage.SelectedItem).Value;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}