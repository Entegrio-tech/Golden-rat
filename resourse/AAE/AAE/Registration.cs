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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AddPlaceholder("Введите логин");
            textBox2.AddPlaceholder("Введите E-MAIL");
            textBox3.AddPlaceholder("Введите пароль");
            textBox4.AddPlaceholder("Введите ещё раз пароль");
        }

        private void button3_Click(object sender, EventArgs e)
        {
         

        }
    }
}
