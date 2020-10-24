using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Validation()
        {
            labelError.Text = "";
            if ((textBoxLogin.TextLength >= 4) && (textBoxPassword.TextLength >= 8))
                buttonLogin.Enabled = true;
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxLogin.TextLength < 4)
            {
                labelError.Text = "Логин должен содержать не менее 4 символов";
            }
            else 
            {
                Validation();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPassword.TextLength < 8)
            {
                labelError.Text = "Пароль должен содержать не менее 8 символов";
            }
            else
            {
                Validation();
            }
        }
    }
}
