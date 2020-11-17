using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Программа1;
using System.Text.RegularExpressions;

namespace Регистрация
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void InputValidationEmail()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (!Regex.IsMatch(textBoxEmail.Text, pattern, RegexOptions.IgnoreCase))
            { 
                labelError.Text = "Некорректный email";
                buttonRegistration.Enabled = false;
            }
            else
            {
                labelError.Text = "";
                buttonRegistration.Enabled = true;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
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

        private void Button3_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
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

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку регистрации, когда в TextBoxLogin введено меньше 4 символов.
            Methods.LockButtonLogin(sender, Methods.minimumLoginLength, "Логин", labelError, buttonRegistration, textBoxLogin, textBoxPassword1);
        }

        private void TextBoxPassword1_TextChanged(object sender, EventArgs e)
        {
            // Метод выключает кнопку регистрации, когда в TextBoxPassword введено меньше 8 символов.
            Methods.LockButtonLogin(sender, Methods.minimumPasswordLength, "Пароль", labelError, buttonRegistration, textBoxLogin, textBoxPassword1);
        }

        private void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            InputValidationEmail();
        }
    }
}
