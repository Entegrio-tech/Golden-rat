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

        private string result = "";

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();
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

        private void buttonSearch_Click(object sender, EventArgs e)
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
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
                    // объект для печати
                    PrintDocument printDocument = new PrintDocument();

                    // обработчик события печати
                    printDocument.PrintPage += PrintPageHandler;

                    // диалог настройки печати
                    PrintDialog printDialog = new PrintDialog();

                    // установка объекта печати для его настройки
                    printDialog.Document = printDocument;

                    // если в диалоге было нажато ОК
                    if (printDialog.ShowDialog() == DialogResult.OK)
                        printDialog.Document.Print(); // печатаем
                }
                else
                    MessageBox.Show("Записей не найдено");

                reader.Close();
            }

        }
    }
}
