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
                buttonLogin.Enabled = false;
            }
            else
                Validation();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPassword.TextLength < 8)
            {
                labelError.Text = "Пароль должен содержать не менее 8 символов";
                buttonLogin.Enabled = false;
            }
            else
                Validation();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
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
