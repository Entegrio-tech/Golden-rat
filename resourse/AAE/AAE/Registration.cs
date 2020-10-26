using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Программа1;

namespace Регистрация
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLogin.AddPlaceholder("Введите логин");
            textBoxEmail.AddPlaceholder("Введите E-MAIL");
            textBoxPassword1.AddPlaceholder("Введите пароль");
            textBoxPassword2.AddPlaceholder("Введите ещё раз пароль");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Methods.authorization.Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Methods.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $@"INSERT INTO Employee (FirstName, LastName, Login, Email, Password) 
                                          VALUES ('{textBoxName.Text}', '{textBoxSurname.Text}', '{textBoxLogin.Text}', '{textBoxEmail.Text}', CAST('{textBoxPassword1.Text}' AS VARBINARY))";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    if (textBoxPassword1.Text == textBoxPassword2.Text)
                    {
                        command.ExecuteNonQuery();
                        this.Hide();
                        Methods.authorization.Show();
                    }
                    else
                        labelError.Text = "Пароли не совпадают";
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                labelError.Text = "Пользователь с таким логином уже существует";
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку регистрации, когда в TextBoxLogin введено меньше 4 символов.
            Methods.LockButtonLogin(sender, Methods.minimumLoginLength, "Логин", labelError, buttonRegistration, textBoxLogin, textBoxPassword1);
        }

        private void textBoxPassword1_TextChanged(object sender, EventArgs e)
        {
            // Метод выключает кнопку регистрации, когда в TextBoxPassword введено меньше 8 символов.
            Methods.LockButtonLogin(sender, Methods.minimumPasswordLength, "Пароль", labelError, buttonRegistration, textBoxLogin, textBoxPassword1);
        }

        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
