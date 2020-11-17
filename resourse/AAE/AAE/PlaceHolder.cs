using System.Drawing;
using System.Windows.Forms;

namespace Регистрация
{
    public static class PlaceHolder
    {
        public static void AddPlaceholder(this TextBox tb, string placeholderText)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholderText)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };
            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholderText;
                }
            };
        }
    }
}
