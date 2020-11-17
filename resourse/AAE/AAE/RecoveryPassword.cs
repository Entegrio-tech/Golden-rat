using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Программа1;

namespace Регистрация
{
    public partial class RecoveryPassword : Form
    {
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        short? code;

        string userEmail;

        private void PasswordEntryStates(bool status)
        {
            if (status)
            {
                textBoxNewPassword1.Enabled = true;
                textBoxNewPassword2.Enabled = true;
                buttonRecovery.Enabled = true;
            }
            else
            {
                textBoxNewPassword1.Enabled = false;
                textBoxNewPassword2.Enabled = false;
                buttonRecovery.Enabled = false;
            }
        }

        private short? GeneratingCode()
        {
            Random rnd = new Random();
            return (short?)rnd.Next(1111, 9999);
        }

        private void SendMail(short? code)
        {
            string mail = "aae.manager@outlook.com";
            MailAddress from = new MailAddress(mail, "AAE");
            // кому отправляем
            MailAddress to = new MailAddress($"{userEmail}");
            MailMessage m = new MailMessage(from, to)
            {
                // тема письма
                Subject = "Восстановление пароля",
                // текст письма
                Body = $"<h3>Здравствуйте, вы отправили запрос на восстановление пароля, если это были не вы - проигнорируйте это письмо.</h3>\n<h1>Ваш код: {code}</h1>",
                IsBodyHtml = true
            };
            // SMTP outlook
            SmtpClient smtp = new SmtpClient("SMTP.Office365.com", 587)
            {
                // логин и пароль
                Credentials = new NetworkCredential(mail, "EntegrioAdmin2"),
                EnableSsl = true
            };
            smtp.Send(m);
        }

        private bool PasswordMatches()
        {            
            return textBoxNewPassword1.Text.Equals(textBoxNewPassword2.Text);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxLogin.AddPlaceholder("Введите вашу почту");
            textBoxCode.AddPlaceholder("Код");
            textBoxNewPassword1.AddPlaceholder("Введите новый пароль");
            textBoxNewPassword2.AddPlaceholder("Повторно введите пароль");
            
        }

        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            code = GeneratingCode();
            userEmail = textBoxLogin.Text;
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression = $"SELECT Login FROM Employee WHERE Email = '{userEmail}'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    SendMail(code);
                    labelNotification.Text = "Введите присланный вам на почту код";
                    textBoxCode.Enabled = true;
                    buttonAcceptCode.Enabled = true;
                    PasswordEntryStates(false);
                }
                else
                {
                    labelNotification.Text = "Аккаунт не найден";
                    textBoxCode.Enabled = false;
                    buttonAcceptCode.Enabled = false;
                    PasswordEntryStates(false);
                }
                connection.Close();
            }
        }

        private void ButtonAcceptCode_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == code.ToString())
            {
                PasswordEntryStates(true);
                code = null;
                labelNotification.Text = "Введите новый пароль";
            }
            else 
            {
                PasswordEntryStates(false);
                code = GeneratingCode();
                SendMail(code);
                labelNotification.Text = "Неверный код!\nНа вашу почту отправлен новый код";
            }
        }

        private void ButtonRecovery_Click(object sender, EventArgs e)
        {
            if (PasswordMatches())
            {
                labelNotification.Text = "";
                string password = textBoxNewPassword1.Text;
                using (SqlConnection connection = new SqlConnection(Methods.connectionString))
                {
                    connection.Open();
                    string sqlExpression = $@"UPDATE Employee SET password = CAST('{password}' AS VARBINARY) WHERE Email = '{userEmail}'";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
                buttonRecovery.Enabled = false;
                labelNotification.Text = "Пароль установлен!\nИспользуйте новые данные для входа";
            }
            else
                labelNotification.Text = "Пароли не совпадают";
        }

        private void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void TextBoxNewPassword1_TextChanged(object sender, EventArgs e)
        {
            Methods.HidePassword((TextBox)sender, "Введите новый пароль");
        }

        private void TextBoxNewPassword2_TextChanged(object sender, EventArgs e)
        {
            Methods.HidePassword((TextBox)sender, "Повторно введите пароль");
        }
    }
}
