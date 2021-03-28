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
    public partial class FormEditUser : Form
    {
        public string email;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        public FormEditUser()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(Connection.GetString());
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadRoles();
        }
        private void loadRoles() //Загрузка ролей
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * From Role", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                comboBoxRole.DataSource = dataSet.Tables[0];
                comboBoxRole.DisplayMember = "RoleName";
                comboBoxRole.ValueMember = "RoleId";
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

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
        private string checkToAdd() //Все проверки для текста
        {
            if ((textBoxFirstName.Text == "" || textBoxLastName.Text == "") && textBoxPassword.Text == "")
                return "Не все поля заполнены";
            return "ОК";
        }
        private string changePassword() //Все проверки для паролей
        {
            if (textBoxPassword.Text.Length < 6 || !Regex.IsMatch(textBoxPassword.Text, @"[0-9]") || !Regex.IsMatch(textBoxPassword.Text, @"[A-Z]") || !Regex.IsMatch(textBoxPassword.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^. Изменение пароля будет пропущено";

            if (textBoxPassword.Text != textBoxRepPas.Text)
                return "Пароли не совпадают. Изменение пароля будет пропущено";

            return "ОК";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    string password = "";
                    if (textBoxPassword.Text != "" || textBoxRepPas.Text != "")
                    {
                        string resultPassword = changePassword();
                        if (resultPassword == "ОК")
                        {
                            password = $", Password = '{textBoxPassword.Text}'";
                        }
                        else
                        {
                            MessageBox.Show(resultPassword);
                        }
                    }
                    connectionSql.Open();
                    DataRowView rowRunner = (DataRowView)comboBoxRole.SelectedItem;
                    string roleId = rowRunner[0].ToString();
                    command = new SqlCommand($"UPDATE dbo.[Users] SET FirstName='{textBoxFirstName.Text}', LastName='{textBoxLastName.Text}', RoleID = '{roleId}'  {password} WHERE Email='{labelEmail.Text}'", connectionSql);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Успешно обновлено!");
                    FormEditUser.ActiveForm.Hide();
                    FormAdminUsersList form = new FormAdminUsersList(email);
                    form.Show();
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
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
