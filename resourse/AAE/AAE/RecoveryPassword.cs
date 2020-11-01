﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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

        short code;

        string userEmail;

        private void PasswordEntryStates(bool status)
        {
            if (status == true)
            {
                textBoxNewPassword.Enabled = true;
                buttonRecovery.Enabled = true;
            }
            else
            {
                textBoxNewPassword.Enabled = false;
                buttonRecovery.Enabled = false;
            }
        }

        private short GeneratingCode()
        {
            Random rnd = new Random();
            return (short)rnd.Next(1111, 9999);
        }

        private void SendMail(short code)
        {
            string mail = "aae.manager@outlook.com";
            MailAddress from = new MailAddress(mail, "AAE");
            // кому отправляем
            MailAddress to = new MailAddress($"{userEmail}");
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = $"<h2>Ваш код: {code}</h2>";
            m.IsBodyHtml = true;
            // SMTP outlook
            SmtpClient smtp = new SmtpClient("SMTP.Office365.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(mail, "EntegrioAdmin2");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxLogin.AddPlaceholder("Введите вашу почту");
            textBoxCode.AddPlaceholder("Код");
            textBoxNewPassword.AddPlaceholder("Введите новый пароль");
            
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
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
                    labelNotification.Text = "Введите присланый вам на почту код";
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

        private void buttonAcceptCode_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == code.ToString())
            {
                PasswordEntryStates(true);
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

        private void buttonRecovery_Click(object sender, EventArgs e)
        {
            string password = textBoxNewPassword.Text;
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

        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void labelNotification_Click(object sender, EventArgs e)
        {

        }
    }
}