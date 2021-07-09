using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class f_options : Form
    {
        public f_options()
        {
            InitializeComponent();
            this.tb_partOfPassword.Text = Properties.Settings.Default.firstpartofpwd;
            this.tb_specialChar.Text = Convert.ToString(Properties.Settings.Default.otherchar);
            this.tb_partOfPassword.TextChanged += Tb_partOfPassword_TextChanged;
            this.tb_specialChar.TextChanged += Tb_specialChar_TextChanged;
        }

        private void Tb_specialChar_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_partOfPassword.Text.Length == 0)
            {
                this.btn_save.Enabled = false;
            }
            else
            {
                if (this.tb_specialChar.Text.Length == 0)
                {
                    this.btn_save.Enabled = false;
                }
                else
                {
                    this.btn_save.Enabled = true;
                }
            }
        }

        private void Tb_partOfPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_specialChar.Text.Length == 0)
            {
                this.btn_save.Enabled = false;
            }
            else
            {
                if (this.tb_partOfPassword.Text.Length == 0)
                {
                    this.btn_save.Enabled = false;
                }
                else
                {
                    this.btn_save.Enabled = true;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.tb_partOfPassword.Text.Trim() != "")
                Properties.Settings.Default.firstpartofpwd = this.tb_partOfPassword.Text;
            if (this.tb_specialChar.Text.Trim() != "")
                Properties.Settings.Default.otherchar = this.tb_specialChar.Text[0];
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
