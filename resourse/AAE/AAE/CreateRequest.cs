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
    public partial class CreateRequest : Form
    {
        public int EmployeeID;
        public CreateRequest()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression1 = $@"SELECT * FROM Equipment
                                          WHERE Name = N'{comboBox1.Text}'";
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string sqlExpression = $@"INSERT INTO Requests (EmployeeID, EquipmentID, Text, Title, RequestDate, Status) 
                                            VALUES ({EmployeeID}, {reader.GetInt32(0)}, N'{textBox3.Text}', N'{richTextBox1.Text}', GETDATE(), 0)";
                    command.CommandText = sqlExpression;
                    reader.Close();
                    command.ExecuteNonQuery();
                    textBox3.Clear();
                    richTextBox1.Clear();
                    MessageBox.Show("Заявка отправлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Выберите оборудование!", "Ошибка 000000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression = $@"SELECT Name FROM Equipment";
                string sqlExpression1 = "SELECT COUNT(*) FROM Equipment";
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                int N = Convert.ToInt32(command.ExecuteScalar());
                command.CommandText = sqlExpression;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
