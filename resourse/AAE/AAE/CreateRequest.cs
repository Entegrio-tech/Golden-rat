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
                    if (textBox3.Text != "" || richTextBox1.Text != "")
                    {
                        reader.Read();
                        string sqlExpression = $@"INSERT INTO Requests (EmployeeID, EquipmentID, Text, Title, RequestDate, Status) 
                                                  VALUES ({Methods.EmployeeID}, {reader.GetString(0)}, N'{textBox3.Text}', N'{richTextBox1.Text}', GETDATE(), 0)";
                        command.CommandText = sqlExpression;
                        reader.Close();
                        command.ExecuteNonQuery();
                        textBox3.Clear();
                        richTextBox1.Clear();
                        MessageBox.Show("Заявка отправлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Заполните поля!", "Ошибка 000001", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sqlExpression = $@"SELECT Name FROM Equipment
                                          WHERE EmployeeID = {Methods.EmployeeID}";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
