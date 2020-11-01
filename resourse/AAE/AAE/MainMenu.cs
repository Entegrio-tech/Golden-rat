using AAE;
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

namespace Регистрация
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Methods.createRequest.Show();
        }

        private void buttonViewRequest_Click(object sender, EventArgs e)
        {
            this.Close();
            Methods.viewRequest.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Methods.Privilage)
                buttonCreateRequest.Visible = false;
            else
                buttonEquipment.Visible = false;
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                var command = new SqlCommand(@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', 
                    Text AS 'Текст', Title AS 'Заголовок', HostID AS 'Номер администратова', RequestDate AS 'Дата' FROM Requests", connection);
                var dataAdapter = new SqlDataAdapter(command);
                var dataTableRequest = new DataTable();
                dataAdapter.Fill(dataTableRequest);
                dataGridView1.DataSource = dataTableRequest;
                //string sqlExpression = $@"UPDATE Employee SET password = CAST('{password}' AS VARBINARY) WHERE Email = '{userEmail}'";
                //SqlCommand command = new SqlCommand(sqlExpression, connection);
                //SqlDataReader reader = command.ExecuteReader();
            }
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            this.Hide();
            equipment.Show();
        }
    }
}
