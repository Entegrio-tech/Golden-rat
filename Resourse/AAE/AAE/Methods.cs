using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
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

        public static int counter = 0;
        public static int curPage;

        public static void Print(PrintPageEventArgs e, RichTextBox richTextBox1)
        {
            // Создать шрифт myFont
            Font myFont = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);

            string curLine; // текущая выводимая строка

            // Отступы внутри страницы
            float leftMargin = e.MarginBounds.Left; // отступы слева в документе
            float topMargin = e.MarginBounds.Top; // отступы сверху в документе
            float yPos = 0; // текущая позиция Y для вывода строки

            int nPages; // количество страниц
            int nLines; // максимально-возможное количество строк на странице
            int i; // номер текущей строки для вывода на странице

            // Вычислить максимально возможное количество строк на странице
            nLines = (int)(e.MarginBounds.Height / myFont.GetHeight(e.Graphics));

            // Вычислить количество страниц для печати
            nPages = (richTextBox1.Lines.Length - 1) / nLines + 1;

            // Цикл печати/вывода одной страницы
            i = 0;
            while ((i < nLines) && (counter < richTextBox1.Lines.Length))
            {
                // Взять строку для вывода из richTextBox1
                curLine = richTextBox1.Lines[counter];

                // Вычислить текущую позицию по оси Y
                yPos = topMargin + i * myFont.GetHeight(e.Graphics);

                // Вывести строку в документ
                e.Graphics.DrawString(curLine, myFont, Brushes.Blue,
                  leftMargin, yPos, new StringFormat());

                counter++;
                i++;
            }

            // Если весь текст не помещается на 1 страницу, то
            // нужно добавить дополнительную страницу для печати
            e.HasMorePages = false;

            if (curPage < nPages)
            {
                curPage++;
                e.HasMorePages = true;
            }
        }
        public static void HidePassword(TextBox sender, string textPassword)
        {
            sender.PasswordChar = '*';
            if (sender.Text.Equals(textPassword))
                sender.PasswordChar = '\0';
        }
    }
}
