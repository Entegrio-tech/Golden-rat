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

        private void buttonDelete_Click(object sender, EventArgs e)
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Регистрация.MainMenu mainMenu = new Регистрация.MainMenu();
            mainMenu.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddEquipment add = new AddEquipment();
            add.Show();
        }
    }
}
