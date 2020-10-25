using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Регистрация
{
    public partial class RecoveryPassword : Form
    {
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.AddPlaceholder("Введите новый пароль");
            textBox3.AddPlaceholder("Код");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
