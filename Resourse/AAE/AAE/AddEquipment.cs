﻿using System;
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
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression1 = $@"SELECT * FROM Employee
                                           WHERE FirstName + ' ' + LastName = N'{comboBox1.Text}'";
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Int16 ID = reader.GetInt16(0);
                    string sqlExpression = $@"INSERT INTO Equipment  
                                          VALUES (N'{textBoxInventoryID.Text}', N'{textBoxName.Text}', N'{textBoxType.Text}', {ID}, N'{textBoxLocation.Text}', N'{textBoxComponent.Text}')";
                    if (textBoxInventoryID.Text != "" || textBoxInventoryID.Text.IndexOf(' ') < 0)
                    {
                        if (textBoxName.Text != "")
                        {
                            if (textBoxType.Text != "")
                            {
                                if (textBoxLocation.Text != "")
                                {
                                    if (textBoxComponent.Text != "")
                                    {
                                        reader.Close();
                                        command.CommandText = sqlExpression;
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Успех");
                                        textBoxInventoryID.Clear();
                                        textBoxName.Clear();
                                        textBoxType.Clear();
                                        comboBox1.Text = "";
                                        textBoxLocation.Clear();
                                        textBoxComponent.Clear();
                                    }
                                    else
                                        MessageBox.Show("Компонент не должен быть пустым!", "Ошибка 000002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("Место не должно быть пустым!", "Ошибка 000005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Тип не должен быть пустым!", "Ошибка 000003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Название не должно быть пустым!", "Ошибка 000002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Некорректный инвентарный номер!", "Ошибка 000001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Выберите код сотрудника!", "Ошибка 00000-1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Equipment equipment = new Equipment();
            equipment.Show();
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Methods.connectionString))
            {
                connection.Open();
                string sqlExpression = $@"SELECT FirstName + ' ' + LastName FROM Employee";
                string sqlExpression1 = "SELECT COUNT(*) FROM Employee";
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
    }
}
