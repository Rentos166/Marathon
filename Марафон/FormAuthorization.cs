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

    public struct Users
    {
        public string email;
        public string password;
        public string type;
        public string fn;
        public string ln;
    }
    public partial class FormAuthorization : Form
    {
        public static string email;
        public static Users users = new Users();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {

        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn = new SqlConnection(Connection.GetString());
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Email = '" + textBoxEmail.Text + "' AND Password = '" + textBoxPassword.Text + "'", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Пользователь с таким email и паролем не найден!. Удостоверьтесь в корректности введенных данных.", "Оповещение системы");
                    }
                    else
                    {
                        email = textBoxEmail.Text;
                        while (reader.Read())
                        {                           
                            if (reader["RoleId"].ToString() == "R")
                            {
                                MessageBox.Show("Вы вошли в систему, как бегун!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormRunnerMenu fm = new FormRunnerMenu(reader["Email"].ToString());
                                fm.Show();
                                this.Hide();
                            }
                            if (reader["RoleId"].ToString() == "A")
                            {
                                MessageBox.Show("Вы вошли в систему, как администратор!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormMenuAdmin fm = new FormMenuAdmin(reader["Email"].ToString());
                                fm.Show();
                                this.Hide();
                            }
                            if (reader["RoleId"].ToString() == "C")
                            {
                                MessageBox.Show("Вы вошли в систему, как координаторы!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormCoordinator fm = new FormCoordinator(reader["Email"].ToString());
                                fm.Show();
                                this.Hide();
                            }

                        }
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
