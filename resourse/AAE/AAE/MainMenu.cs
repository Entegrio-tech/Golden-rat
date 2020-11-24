using AAE;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Программа1;

namespace Регистрация
{
    public partial class MainMenu : Form
    {
        public string[] row;

        #region Method
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

        private void OpenVievRequest(DataGridView dataGridView, int rowIndex)
        {
            row = new string[dataGridView.Columns.Count];
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                row[i] = dataGridView.Rows[rowIndex].Cells[i].Value.ToString();
            }
            var viewRequest = new ViewRequest
            {
                Owner = this
            };
            viewRequest.Show();
        }

        public void FillDataGridViev()
        {
            if (Methods.Privilage)
            {
                buttonCreateRequest.Visible = false;
                FillingTable(@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', 
                    Text AS 'Текст', Title AS 'Заголовок', RequestDate AS 'Дата'
                    FROM Requests WHERE Status IS Null");
            }
            else
            {
                buttonCreateRequest.Visible = true;
                buttonViewRequest.Visible = false;
                buttonJournal.Visible = false;
                buttonEquipment.Visible = false;
                FillingTable($@"SELECT ID AS '№', EmployeeID AS 'Номер сотрудника', EquipmentID AS 'Номер оборудования', 
                    Text AS 'Текст', Title AS 'Заголовок', RequestDate AS 'Дата', Status AS 'Статус'
                    FROM Requests WHERE EmployeeId='{Methods.EmployeeID}'");
            }
        }
        #endregion

        #region Event
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CreateRequest createRequest = new CreateRequest();
            this.Close();
            createRequest.Show();
        }

        private void ButtonViewRequest_Click(object sender, EventArgs e)
        {
            OpenVievRequest(dataGridView1, dataGridView1.CurrentCell.RowIndex);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Заполняет DataGriedViev данными с БД.
            FillDataGridViev();
        }

        private void ButtonEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            this.Close();
            equipment.Show();
        }

        private void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void ButtonJournal_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            this.Close();
            journal.Show();
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Methods.Privilage)
            {
                OpenVievRequest((DataGridView)sender, e.RowIndex);
            }
            
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonViewRequest.Enabled = true;
        }
        #endregion

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Заполняет DataGriedViev данными с БД.
            FillDataGridViev();
        }
    }
}
