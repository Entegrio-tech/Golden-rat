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
            textBoxName.AddPlaceholder("Введите имя");
            textBoxSurname.AddPlaceholder("Введите фамилию");
            textBoxLogin.AddPlaceholder("Введите логин");
            textBoxEmail.AddPlaceholder("Введите E-MAIL");
            textBoxPassword1.AddPlaceholder("Введите пароль");
            textBoxPassword2.AddPlaceholder("Введите ещё раз пароль");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Methods.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $@"INSERT INTO Employee (FirstName, LastName, Login, Email, Password, Privilage) 
                                          VALUES (N'{textBoxName.Text}', N'{textBoxSurname.Text}', N'{textBoxLogin.Text}', N'{textBoxEmail.Text}', CAST('{textBoxPassword1.Text}' AS VARBINARY), 0)";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    if (textBoxPassword1.Text == textBoxPassword2.Text)
                    {
                        if (textBoxSurname.Text != "Введите имя" && textBoxName.Text != "Введите фамилию" && textBoxEmail.Text != "Введите E-MAIL" && textBoxLogin.Text != "Введите логин")
                        {
                            if (textBoxSurname.Text.IndexOf(' ') < 0)
                            {
                                if (textBoxName.Text.IndexOf(' ') < 0)
                                {
                                    if (textBoxEmail.Text.IndexOf(' ') < 0)
                                    {
                                        if (textBoxLogin.Text.IndexOf(' ') < 0)
                                        {
                                            command.ExecuteNonQuery();
                                            Authorization authorization = new Authorization();
                                            this.Close();
                                            authorization.Show();
                                        }
                                        else
                                            labelError.Text = "Логин не может содержать пробелы";
                                    }
                                    else
                                        labelError.Text = "E-MAIL не может содержать пробелы";
                                }
                                else
                                    labelError.Text = "Имя не может содержать пробелы";
                            }
                            else
                                labelError.Text = "Фамилия не может содержать пробелы";
                        }
                        else
                            labelError.Text = "Заполните поля!";
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

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
