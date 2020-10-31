using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Программа1;

namespace Регистрация
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private byte counter;

        internal static void Open()
        {
            throw new NotImplementedException();
        }       

        private void LoginAttemptsLimit()
        {
            // Выключает кнопку входа на 5 секунд, если она нажата 5 раз.
            if (counter++ == 5)
            {
                MessageBox.Show("Слишком много попыток входа, попробуйте снова через 5 секунд!");
                buttonLogin.Enabled = false;
                Thread.Sleep(5000);
                counter = 0;
                buttonLogin.Enabled = true;
            }
        }

        private void Authentication()
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression = $@"SELECT * FROM Employee
                                          WHERE Login = '{textBoxLogin.Text}' AND Password = CAST('{textBoxPassword.Text}' AS varbinary)";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Methods.EmployeeID = reader.GetInt16(0);
                    Methods.Privilage = reader.GetBoolean(6);
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
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

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxLogin.AddPlaceholder("Введите логин");
            textBoxPassword.AddPlaceholder("Введите пароль");
        }
        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin.PerformClick();
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку входа, когда в TextBoxLogin введено меньше 4 символов.
            Methods.LockButtonLogin(sender, Methods.minimumLoginLength, "Логин", labelError, buttonLogin, textBoxLogin, textBoxPassword);
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку входа, когда в TextBoxPassword введено меньше 8 символов.
            Methods.LockButtonLogin(sender, Methods.minimumPasswordLength, "Пароль", labelError, buttonLogin, textBoxLogin, textBoxPassword);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginAttemptsLimit();
            Authentication();
        }

        public void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void ButtonForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecoveryPassword recoveryPassword = new RecoveryPassword();
            recoveryPassword.Show();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

