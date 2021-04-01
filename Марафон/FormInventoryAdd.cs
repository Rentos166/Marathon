using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Марафон
{
    public partial class FormInventoryAdd : Form
    {
        public string email;
        SqlConnection connectionSql;
        SqlCommand command;
        public FormInventoryAdd(string email)
        {
            this.email = email;
            InitializeComponent();
            connectionSql = new SqlConnection(Connection.GetString());
        }

        private void FormInventoryAdd_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void FormInventoryAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory(email);
            inventory.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                if (int.TryParse(idTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(idTextBox.Text)} where IdInventory = 1", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(rfidTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(rfidTextBox.Text)} where IdInventory = 2", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(baseballTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(baseballTextBox.Text)} where IdInventory = 3", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(waterTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(waterTextBox.Text)} where IdInventory = 4", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(tshirtTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(tshirtTextBox.Text)} where IdInventory = 5", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(souvenirTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(souvenirTextBox.Text)} where IdInventory = 6", connectionSql);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно обновлены!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }
    }
}
