using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Программа1;

namespace Регистрация
{
    public partial class ViewRequest : Form
    {
        public ViewRequest()
        {
            InitializeComponent();
        }

        // Перечисление для массива row.
        enum Request : byte
        {
            ID,
            EmployeeID,
            EquipmentID,
            Text,
            Title,
            Date,
            Status
        }

        private void DecisionMaking(bool decision)
        {
            MainMenu mainMenu = this.Owner as MainMenu;
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                string status = "";
                connection.Open();
                string sqlExpression = $@"SELECT Status FROM Requests WHERE ID = '{mainMenu.row[(byte)Request.ID]}'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    status = Convert.ToString(reader["Status"]);
                reader.Close();

                if (status.Length != 0)
                    MessageBox.Show("Заявка уже обработана!");
                else
                {           
                    sqlExpression = $@"UPDATE Requests SET Status = '{decision}', HostID = '{Methods.EmployeeID}' WHERE ID = '{mainMenu.row[(byte)Request.ID]}'";
                    command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteReader();
                }
                connection.Close();
            }
            // Обновляем данные в таблице.
            mainMenu.FillDataGridViev();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRequest_Load(object sender, EventArgs e)
        {
            MainMenu mainMenu = this.Owner as MainMenu;
            labelDate.Text = mainMenu.row[(byte)Request.Date].Substring(0, 10);
            textBoxTitle.Text = mainMenu.row[(byte)Request.Title];
            richTextBoxRequest.Text = mainMenu.row[(byte)Request.Text];
            labelRequestID.Text = mainMenu.row[(byte)Request.ID];
            labelEmployeeID.Text = mainMenu.row[(byte)Request.EmployeeID];
            labelEquipmentID.Text = mainMenu.row[(byte)Request.EquipmentID];
        }

        private void GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.gradientPanelMouseDown(e);
        }

        private void GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            Methods.GradientPanelMouseMove(this, e);
        }

        private void ButtonReject_Click(object sender, EventArgs e)
        {
            DecisionMaking(false);
            this.Close();
        }

        private void ButtonAcсept_Click(object sender, EventArgs e)
        {
            DecisionMaking(true);            
            this.Close();
        }
    }
}
