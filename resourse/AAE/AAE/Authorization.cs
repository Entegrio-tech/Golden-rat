using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Регистрация
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        const byte minimumLoginLength = 4;

        const byte minimumPasswordLength = 8;

        private byte counter;

        bool mouseDown;

        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        internal static void Open()
        {
            throw new NotImplementedException();
        }       

        private void Validation()
        {
            labelError.Text = "";
            // Ограничивает ввод символов.
            if ((textBoxLogin.TextLength >= minimumLoginLength) && (textBoxPassword.TextLength >= minimumPasswordLength))
                buttonLogin.Enabled = true;
        }

        private void LockButtonLogin(object sender, byte minimumNumberCharacters, string fieldName)
        {
            TextBox textBox = (TextBox)sender;
            // Выключает кнопку buttonLogin, если символов меньше чем minimumNumberCharacters.
            if (textBox.TextLength < minimumNumberCharacters)
            {
                labelError.Text = $"{fieldName} должен содержать не менее {minimumNumberCharacters} символов";
                buttonLogin.Enabled = false;
            }
            else
                Validation();
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

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxLogin.AddPlaceholder("Введите логин");
        }
        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку входа, когда в TextBoxLogin введено меньше 4 символов.
            LockButtonLogin(sender, minimumLoginLength, "Логин");
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Метод выключает кнопку входа, когда в TextBoxPassword введено меньше 8 символов.
            LockButtonLogin(sender, minimumPasswordLength, "Пароль");
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

        public void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
            }
            
        }

        public void GradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }        
        }

        public void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Left = Cursor.Position.X;
                this.Top = Cursor.Position.Y;
            }
        }
    }
}

