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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox4.AddPlaceholder("Введите логин");
            textBox3.AddPlaceholder("Введите пароль");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
