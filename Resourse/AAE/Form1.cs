using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace AAE
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        const byte minimumLoginLength = 4; 
        const byte minimumPasswordLength = 8;
        private byte counter; // Переменная счетчик, необходимая для работы метода LoginAttemptsLimit.

        //
        // Проверяет заполненность textBoxLogin и textBoxPassword.
        //
        private void Validation()
        {
            labelError.Text = "";
            if ((textBoxLogin.TextLength >= minimumLoginLength) && (textBoxPassword.TextLength >= minimumPasswordLength))
                buttonLogin.Enabled = true;
        }

        //
        // Выключает кнопку buttonLogin, если символов меньше чем minimumNumberCharacters.
        //
        private void LockButtonLogin(object sender, byte minimumNumberCharacters, string fieldName)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength < minimumNumberCharacters)
            {
                labelError.Text = $"{fieldName} должен содержать не менее {minimumNumberCharacters} символов";
                buttonLogin.Enabled = false;
            }
            else
                Validation();
        }

        //
        // Событие ввода символа в textBoxLogin.
        //
        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockButtonLogin(sender, minimumLoginLength, "Логин");  // Выключает кнопку входа, когда в TextBoxLogin введено меньше 4 символов. 
        }

        //
        // Событие ввода символа в textBoxPassword. 
        //
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e) 
        {
            LockButtonLogin(sender, minimumPasswordLength, "Пароль");  // Выключает кнопку входа, когда в TextBoxPassword введено меньше 8 символов. 
        }

        //
        // Выключает кнопку входа на 5 секунд, если она нажата 5 раз.
        //
        private void LoginAttemptsLimit() 
        {
            if (counter++ == 5)  
            {
                MessageBox.Show("Слишком много попыток входа, попробуйте снова через 5 секунд!");
                buttonLogin.Enabled = false;
                Thread.Sleep(5000);
                counter = 0;
                buttonLogin.Enabled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginAttemptsLimit();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $@"SELECT * FROM Employee
                                          WHERE Login = '{textBoxLogin.Text}' AND Password = CAST('{textBoxPassword.Text}' AS varbinary)";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    labelError.Text = "Успех";
                else
                {
                    reader.Close();
                    string sqlExpression1 = $@"SELECT * FROM Employee
                                               WHERE Login = '{textBoxLogin.Text}'";
                    command.CommandText = sqlExpression1;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                        labelError.Text = "Неверный пароль";
                    else
                        labelError.Text = "Такого пользователя не существует";
                }
            }
        }
    }
}
