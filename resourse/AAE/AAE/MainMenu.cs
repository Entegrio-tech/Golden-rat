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
        public string[] row;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void FillingTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                var dataAdapter = new SqlDataAdapter(command);
                var dataTableRequest = new DataTable();
                dataAdapter.Fill(dataTableRequest);
                dataGridView1.DataSource = dataTableRequest;
                connection.Close();
            }
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
            {
                buttonCreateRequest.Visible = false;
                FillingTable(@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', 
                    Text AS 'Текст', Title AS 'Заголовок', HostID AS 'Номер администратора', RequestDate AS 'Дата'
                    FROM Requests WHERE Status IS Null");
            }
            else
            {
                buttonEquipment.Visible = false;
                FillingTable($@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', 
                    Text AS 'Текст', Title AS 'Заголовок', HostID AS 'Номер администратора', RequestDate AS 'Дата', Status AS 'Статус'
                    FROM Requests WHERE EmployeeId='{Methods.EmployeeID}'");
            }
            
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            this.Hide();
            equipment.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            
            MessageBox.Show($"строка: {e.RowIndex}, столбец: {e.ColumnIndex}");
            row = new string[dataGridView.Columns.Count];
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                row[i] = dataGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
            }          
            var viewRequest = new ViewRequest();
            viewRequest.Owner = this;
            viewRequest.Show();
        }

        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void gradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void buttonJournal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Journal journal = new Journal();
            journal.Show();
        }
    }
}
