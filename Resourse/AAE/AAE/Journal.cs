using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Программа1;
using Регистрация;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace AAE
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }


        RichTextBox richTextBox1 = new RichTextBox();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();
            this.Close();          
            mainMenu.Show();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                var command1 = new SqlCommand($@"SELECT Requests.ID AS 'Код', Employee.ID AS 'Код сотрудника', Employee.FirstName + ' ' + Employee.LastName AS 'Отправитель', Equipment.ID AS 'Код оборудование', Equipment.Name AS 'Оборудование', Title AS 'Тема', Text AS 'Текст', HostID AS 'Код админа', RequestDate AS 'Дата', Status AS 'Статус'
                                               FROM Equipment, Employee, Requests
                                               WHERE Equipment.EmployeeID = Employee.ID AND Requests.EquipmentID = Equipment.ID", connection);
                var dataAdapter = new SqlDataAdapter(command1);
                var dataTableRequest = new DataTable();
                dataAdapter.Fill(dataTableRequest);
                dataGridView1.DataSource = dataTableRequest;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
            }
        }

        public static string SplitToLines(string str, int n)
        {
            return Regex.Replace(str, ".{" + n + "}(?!$)", "$0\n");
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            string result = "";
            string sqlExpression = $@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', Text AS 'Текст', Title AS 'Заголовок', HostID AS 'Номер администратора', RequestDate AS 'Дата', Status AS 'Статус' FROM Requests
                                   WHERE RequestDate = '{textBox2.Text}'";
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    string name0 = reader.GetName(0);
                    string name1 = reader.GetName(1);
                    string name2 = reader.GetName(2);
                    string name3 = reader.GetName(3);
                    string name4 = reader.GetName(4);
                    string name5 = reader.GetName(5);
                    string name6 = reader.GetName(6);

                    while (reader.Read()) // построчно считываем данные
                    {
                        result += $"{name0} - {reader.GetValue(0)}\n{name1} - {reader.GetValue(1)}\n{name2} - {reader.GetValue(2)}\n{name3} - {SplitToLines(reader.GetString(3), 78)}\n{name4} - {reader.GetValue(4)}\n{name5} - {reader.GetValue(5)}\n{name6} - {reader.GetValue(6)}\n\n";
                    }
                    richTextBox1.Text = result;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                }
                else
                    MessageBox.Show("Записей не найдено");

                reader.Close();
            }
        }
        // Количество выделенных строк:
        // 0 <= counter <= richTextBox1.Lines.Length
        int counter = 0; // сквозной номер строки в массиве строк, которые выводятся
        int curPage; // текущая страница

        // Обработчик события PrintPage - здесь нужно программировать печать
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
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

        // Начало печати
        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            // Перед началом печати переменные-счетчики
            // установить в начальные значения
            counter = 0;
            curPage = 1;
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); // отобразить окно
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
