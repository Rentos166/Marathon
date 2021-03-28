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
using System.Text.RegularExpressions;
namespace Марафон
{
    public partial class FormAddUser : Form
    {
        public string email;
        public FormAddUser(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand commandRole = new SqlCommand("SELECT * FROM Role", conn);
            using (SqlDataReader reader = commandRole.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.text = reader["RoleName"].ToString();
                    item.value = reader["RoleId"].ToString();
                    comboBoxRole.Items.Add(item);
                }
            }
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdminUsersList usersList = new FormAdminUsersList(email);
            usersList.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormAdminUsersList usersList = new FormAdminUsersList(email);
            usersList.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxRepPas.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || comboBoxRole.Text == "")
            {
                MessageBox.Show("Одно или несколько обязательных полей для ввода (отмеченных знаком *) не были заполнены!", "Оповещение системы");
            }
            else
            {
                Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                Match emailMatch = emailRegex.Match(textBoxEmail.Text);
                if (emailMatch.Value == "")
                    MessageBox.Show("Некорректный формат email!", "Оповещение системы");
                else
                {
                    bool digit = false;
                    bool spec = false;
                    bool lowChar = false;
                    bool pass = false;
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (Char.IsDigit(textBoxPassword.Text[i]))
                        {
                            digit = true;
                            break;
                        }
                    }
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (Char.IsLower(textBoxPassword.Text[i]))
                        {
                            lowChar = true;
                            break;
                        }
                    }
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (textBoxPassword.Text[i] == '#' || textBoxPassword.Text[i] == '!' || textBoxPassword.Text[i] == '@' || textBoxPassword.Text[i] == '$' || textBoxPassword.Text[i] == '%' || textBoxPassword.Text[i] == '^')
                        {
                            spec = true;
                            break;
                        }
                    }
                    if (textBoxPassword.TextLength < 6 || !spec || !digit || !lowChar)
                        MessageBox.Show("Некорректный формат пароля! Длина пароля должна быть не менее шести символов, из которых должна быть, как минимум, одна буква нижнего регистра, одна цифра и один из следующих символов: !,#,%,^,@", "Оповещение системы");
                    else
                    {
                        pass = true;
                    }

                    if (pass)
                    {
                        if (textBoxPassword.Text != textBoxRepPas.Text)
                        {
                            MessageBox.Show("Пароли не совпадают!", "Оповещение системы");
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection(Connection.GetString());
                            conn.Open();
                            SqlCommand command = new SqlCommand("INSERT INTO Users (Email, Password, FirstName, LastName, RoleId) Values (@e, @p, @f, @l, @r)", conn);
                            command.Parameters.Add("@e", textBoxEmail.Text);
                            command.Parameters.Add("@p", textBoxPassword.Text);
                            command.Parameters.Add("@f", textBoxFirstName.Text);
                            command.Parameters.Add("@l", textBoxLastName.Text);
                            command.Parameters.Add("@r", (comboBoxRole.SelectedItem as ComboBoxItem).value);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Пользователь успешно добавлен в Систему!", "Оповещение системы");
                            FormAdminUsersList fm = new FormAdminUsersList(email);
                            fm.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}
