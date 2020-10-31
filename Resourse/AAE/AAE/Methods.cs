using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Регистрация;

namespace Программа1
{
    public static class Methods
    {
        public static Int16 EmployeeID;

        public static bool Privilage;

        public const byte minimumLoginLength = 4;

        public const byte minimumPasswordLength = 8;

        public static Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();

        public static Authorization authorization = new Authorization();

        public static Registration registration = new Registration();

        public static RecoveryPassword recoveryPassword = new RecoveryPassword();

        public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private static Point lastPoint;

        public static CreateRequest createRequest = new CreateRequest();

        public static ViewRequest viewRequest = new ViewRequest();

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

        public static void gradientPanelMouseDown(MouseEventArgs e)
        {
            Methods.lastPoint = new Point(e.X, e.Y);
        }
        public static void GradientPanelMouseMove(Form thisForm ,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                thisForm.Left = Cursor.Position.X - Methods.lastPoint.X;
                thisForm.Top = Cursor.Position.Y - Methods.lastPoint.Y;
            }
        }

    }
}
