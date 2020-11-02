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
                string sqlExpression1 = $@"SELECT Status FROM Requests";
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string stat;
                if (reader.GetBoolean(0))
                    stat = "Принята";
                else
                    stat = "Отклоненна";
                var command1 = new SqlCommand($@"SELECT Requests.ID AS 'Код', Employee.FirstName + ' ' + Employee.LastName AS 'Отправитель', Equipment.Name AS 'Оборудование', Title AS 'Тема', Text AS 'Текст', HostID AS 'Код админа', RequestDate AS 'Дата', Status AS 'Статус'
                                               FROM Equipment, Employee, Requests
                                               WHERE Equipment.EmployeeID = Employee.ID AND Requests.EquipmentID = Equipment.ID", connection);
                var dataAdapter = new SqlDataAdapter(command1);
                var dataTableRequest = new DataTable();
                reader.Close();
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string sqlExpression = $@"SELECT * FROM Requests
                                   WHERE RequestDate = '{textBox2.Text}'";
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    result = $"{reader.GetName(0)}\t{reader.GetName(1)}\t{reader.GetName(2)}\t{reader.GetName(3)}\t{reader.GetName(4)}\t{reader.GetName(5)}\t{reader.GetName(6)}\t{reader.GetName(7)}\n";

                    while (reader.Read()) // построчно считываем данные
                    {
                        result += $"{reader.GetValue(0)}\t{reader.GetValue(1)}\t{reader.GetValue(2)}\t{reader.GetValue(3)}\t{reader.GetValue(4)}\t{reader.GetValue(5)}\t{reader.GetValue(6)}\t{reader.GetValue(7)}\n";
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
