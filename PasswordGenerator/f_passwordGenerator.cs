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

namespace PasswordGenerator
{
    public partial class f_mainWindow : Form
    {
        Generator generator = new Generator();

        public f_mainWindow()
        {
            InitializeComponent();
            this.tb_appName.DataBindings.Add(new Binding("Text", this.generator, "SoftwareName"));
            this.tb_appName.TextChanged += Tb_appName_TextChanged;
        }

        private void Tb_appName_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_appName.Text.Length >= 3)
                this.btn_generatePassword.Enabled = true;
            else
                this.btn_generatePassword.Enabled = false;
        }

        private void btn_generatePassword_Click(object sender, EventArgs e)
        {
            TypeOfGeneration typeOfGeneration = (TypeOfGeneration)Enum.Parse(typeof(TypeOfGeneration), Properties.Settings.Default.typeOfGeneration);
            Clipboard.SetText(this.generator.GeneratePassword(typeOfGeneration));
            MessageBox.Show("The generated password has been pasted.");
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            f_options f_Options = new f_options();
            f_Options.ShowDialog();
        }
    }
}
