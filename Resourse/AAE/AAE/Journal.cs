using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Программа1;
using System.Drawing.Printing;

namespace AAE
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        private readonly RichTextBox richTextBox1 = new RichTextBox();

        private void ButtonBack_Click(object sender, EventArgs e)
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
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
            }
        }

        private string PrintString()
        {
            string result = "";
            string sqlExpression = $@"SET DATEFORMAT dmy
                                    SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', Text AS 'Текст', Title AS 'Заголовок', HostID AS 'Номер администратора', RequestDate AS 'Дата', Status AS 'Статус' 
                                    FROM Requests
                                    WHERE RequestDate = '{maskedTextBoxDate.Text}'";
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                // если есть данные
                if (reader.HasRows) 
                {
                    string name0 = reader.GetName(0);
                    string name1 = reader.GetName(1);
                    string name2 = reader.GetName(2);
                    string name3 = reader.GetName(3);
                    string name4 = reader.GetName(4);
                    string name5 = reader.GetName(5);
                    string name6 = reader.GetName(6);
                    // построчно считываем данные
                    while (reader.Read()) 
                    {
                        result += $"{name0} - {reader.GetValue(0)}\n{name1} - {reader.GetValue(1)}\n{name2} - {reader.GetValue(2)}\n{name3} - {reader.GetString(3), 78}\n{name4} - {reader.GetValue(4)}\n{name5} - {reader.GetValue(5)}\n{name6} - {reader.GetValue(6)}\n\n";
                    }
                    richTextBox1.Text = result;
                    return result;
                }
                else
                {
                    result = "";
                    return result;
                }
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (PrintString() != "")
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            else
                MessageBox.Show("Записей не найдено");
        }

        // Обработчик события PrintPage - здесь нужно программировать печать
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Methods.Print(e, richTextBox1);
        }

        // Начало печати
        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            // Перед началом печати переменные-счетчики
            // установить в начальные значения
            Methods.counter = 0;
            Methods.curPage = 1;
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            // отобразить окно
            pageSetupDialog1.ShowDialog();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPreview_Click_1(object sender, EventArgs e)
        {
            if (PrintString() != "")
                printPreviewDialog1.ShowDialog();
            else
                MessageBox.Show("Печать пуста");
        }

        private void buttonPreview_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }

}
