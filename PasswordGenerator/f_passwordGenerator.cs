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
        public f_mainWindow()
        {
            InitializeComponent();
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
            string thirdLetter = "";
            if (this.tb_appName.Text.Length >= 4)
                thirdLetter = this.tb_appName.Text[3].ToString().ToUpper();
            else
                thirdLetter = "X";
            string generatedPassword = Properties.Settings.Default.firstpartofpwd + TransferLettersToNumbers(this.tb_appName.Text.Substring(0, 3));
            generatedPassword += thirdLetter + Properties.Settings.Default.otherchar;
            Clipboard.SetText(generatedPassword);
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            f_options f_Options = new f_options();
            f_Options.ShowDialog();
        }

        private string TransferLettersToNumbers(string letters)
        {
            string numbers = "";
            foreach (char letter in letters.ToUpper())
            {
                switch (letter)
                {
                    case 'A':
                        numbers += "1";
                        break;
                    case 'B':
                        numbers += "2";
                        break;
                    case 'C':
                        numbers += "3";
                        break;
                    case 'D':
                        numbers += "4";
                        break;
                    case 'E':
                        numbers += "5";
                        break;
                    case 'F':
                        numbers += "6";
                        break;
                    case 'G':
                        numbers += "7";
                        break;
                    case 'H':
                        numbers += "8";
                        break;
                    case 'I':
                        numbers += "9";
                        break;
                    case 'J':
                        numbers += "10";
                        break;
                    case 'K':
                        numbers += "11";
                        break;
                    case 'L':
                        numbers += "12";
                        break;
                    case 'M':
                        numbers += "13";
                        break;
                    case 'N':
                        numbers += "14";
                        break;
                    case 'O':
                        numbers += "15";
                        break;
                    case 'P':
                        numbers += "16";
                        break;
                    case 'Q':
                        numbers += "17";
                        break;
                    case 'R':
                        numbers += "18";
                        break;
                    case 'S':
                        numbers += "19";
                        break;
                    case 'T':
                        numbers += "20";
                        break;
                    case 'U':
                        numbers += "21";
                        break;
                    case 'V':
                        numbers += "22";
                        break;
                    case 'W':
                        numbers += "23";
                        break;
                    case 'X':
                        numbers += "24";
                        break;
                    case 'Y':
                        numbers += "25";
                        break;
                    case 'Z':
                        numbers += "26";
                        break;
                }
            }
            return numbers;
        }
    }
}
