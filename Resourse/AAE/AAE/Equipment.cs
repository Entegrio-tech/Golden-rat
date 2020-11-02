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

namespace AAE
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

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
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                var command = new SqlCommand($@"DELETE FROM Equipment
                                                WHERE ID = '{textBox1.Text}'", connection);
                command.ExecuteNonQuery();
                Equipment_Load(sender, e);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();
            mainMenu.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddEquipment add = new AddEquipment();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
