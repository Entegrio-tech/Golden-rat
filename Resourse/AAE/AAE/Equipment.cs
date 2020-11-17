﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Программа1;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace AAE
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        readonly RichTextBox richTextBox1 = new RichTextBox();

        private void Equipment_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                var command = new SqlCommand(@"SELECT Equipment.ID AS 'Код', Equipment.Name AS 'Название', Equipment.Type AS 'Тип', Employee.FirstName + ' ' + Employee.LastName AS 'Заведующий', Equipment.Location AS 'Место', Equipment.Components AS 'Компонент'
                                               FROM Equipment, Employee
                                               WHERE Equipment.EmployeeID = Employee.ID", connection);
                var dataAdapter = new SqlDataAdapter(command);
                var dataTableRequest = new DataTable();
                dataAdapter.Fill(dataTableRequest);
                dataGridView1.DataSource = dataTableRequest;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();
            mainMenu.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            EquipmentAdd add = new EquipmentAdd();
            this.Close();
            add.Show();
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Methods.Print(e, richTextBox1);
        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Перед началом печати переменные-счетчики
            // установить в начальные значения
            Methods.counter = 0;
            Methods.curPage = 1;
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonSetting_Click_1(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); // отобразить окно
        }

        private void ButtonPrint_Click_1(object sender, EventArgs e)
        {
            if (PrintString() != "")
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            else
                MessageBox.Show("Записей не найдено");
        }

        private void ButtonPreview_Click_1(object sender, EventArgs e)
        {
            if (PrintString() != "")
                printPreviewDialog1.ShowDialog();
            else
                MessageBox.Show("Печать пуста");
        }

        private string PrintString()
        {
            string result = "";
            string sqlExpression = $@"SELECT * FROM Equipment";
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

                    while (reader.Read()) // построчно считываем данные
                    {
                        result += $"{name0} - {reader.GetValue(0)}\n{name1} - {reader.GetValue(1)}\n{name2} - {reader.GetValue(2)}\n{name3} - {reader.GetValue(3),78}\n{name4} - {reader.GetValue(4)}\n{name5} - {reader.GetValue(5)}\n\n";
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

        Excel.Application ex;
        public BindingSource binding = new BindingSource();

        private void Button1_Click(object sender, EventArgs e)
        {
            //пытаемся подключиться к запущенному Excel
            try
            {
                ex = Marshal.GetActiveObject("Excel.Application")
                as Excel.Application;
            }
            //если Excel на запущен, запускаем его
            catch (COMException)
            {
                ex = new Excel.Application();
            }
            //создаем новую книгу на основе шаблона
            object fileName = @"E:\GitHub\Golden-rat\Resourse\AAE\anketa.xltx";
            ex.Workbooks.Add(fileName);
            //во вторую колонку листа напротив введенных названий отобразим значения полей таблицы
            //в первую колонку первой строки листа отображаем второе поле таблицы
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[1, 2] =
            (binding.Current as DataRowView)["fam"].ToString();
            //во вторую колонку второй строки листа отображаем третье поле поле таблицы и т.д.
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            2, 2] =
            (binding.Current as DataRowView)["imya"].ToString()
            ;
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            3, 2] =
            (binding.Current as DataRowView)["otch"].ToString()
            ;
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            4, 2] =
            (binding.Current as DataRowView)["grup"].ToString()
            ;
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            5, 2] =

            (binding.Current as DataRowView)["finance"].ToString();
            //поле типа Дата/Время выводится по шаблону, чтобы не выводилось время
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            6, 2] =
            Convert.ToDateTime((binding.Current as DataRowView)
            ["datar"]).ToString("dd/MM/yyyy");
            (ex.ActiveWorkbook.Sheets[1] as Excel.Worksheet).Cells[
            7, 2] =
            (binding.Current as DataRowView)["srbal"].ToString(
            );
            //делаем окно Excel видимым
            ex.Visible = true;
        }
    }
    
}

