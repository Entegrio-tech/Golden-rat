using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Регистрация;

namespace Программа1
{
    public static class Methods
    {

        public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public const byte minimumLoginLength = 4;

        public const byte minimumPasswordLength = 8;

        public static CreateRequest createRequest = new CreateRequest();

        private static void Validation(Label labelError, Button buttonLogin, TextBox textBoxLogin, TextBox textBoxPassword)
        {
            labelError.Text = "";
            // Ограничивает ввод символов.
            if ((textBoxLogin.TextLength >= minimumLoginLength) && (textBoxPassword.TextLength >= minimumPasswordLength))
                buttonLogin.Enabled = true;
        }

        public static void LockButtonLogin(object sender, byte minimumNumberCharacters, string fieldName, Label labelError, Button buttonLogin, TextBox textBoxLogin, TextBox textBoxPassword)
        {
            TextBox textBox = (TextBox)sender;
            // Выключает кнопку buttonLogin, если символов меньше чем minimumNumberCharacters.
            if (textBox.TextLength < minimumNumberCharacters)
            {
                labelError.Text = $"{fieldName} должен содержать не менее {minimumNumberCharacters} символов";
                buttonLogin.Enabled = false;
            }
            else
                Validation(labelError, buttonLogin, textBoxLogin, textBoxPassword);
        }
    }
}
