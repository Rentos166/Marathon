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
    public partial class FormAdminUsersList : Form
    {
        public string email, nameInfo, lastNameInfo, roleInfo;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public FormAdminUsersList(string email)
        {
            this.email = email;
            InitializeComponent();
            connectionSql = new SqlConnection(Connection.GetString());
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
        private void loadRole() //Загрузка ролей и выгрузка их в список
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
        public void loadUsers() //Загрузка пользователей и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT FirstName AS 'Имя', LastName AS 'Фамилия', Email AS 'Email', RoleName AS 'Роль' FROM [Role] inner join [Users] ON [Users].RoleId = [Role].RoleId", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                usersDataGrid.DataSource = dataSet.Tables[0];
                allNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();
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
        private void FormAdminUsersList_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadRole();
            loadUsers();
        }

        private void FormAdminUsersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void usersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (usersDataGrid.SelectedRows[0].Index != -2)
            {
                email = usersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                nameInfo = usersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                lastNameInfo = usersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                roleInfo = usersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (email != "" && nameInfo != "" && lastNameInfo != "")
            {
                this.Hide();
                FormEditUser form = new FormEditUser();
                form.labelEmail.Text = email;
                form.textBoxFirstName.Text = lastNameInfo;
                form.textBoxLastName.Text = nameInfo;
                if(roleInfo == "Runner")
                { form.comboBoxRole.SelectedIndex = 2; }
                else if(roleInfo == "Administrator")
                { form.comboBoxRole.SelectedIndex = 0; }
                else if(roleInfo == "Coordinator")
                { form.comboBoxRole.SelectedIndex = 1; }
                form.Show();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = new FormAddUser(email);
            addUser.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin(email);
            formMenuAdmin.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT FirstName AS 'Имя', LastName AS 'Фамилия', Email AS 'Email', RoleName AS 'Роль' FROM [Role] inner join [Users] ON [Users].RoleId = [Role].RoleId WHERE (FirstName like '%{textBoxFind.Text}%' or LastName like '%{textBoxFind.Text}%' or Email like '%{textBoxFind.Text}%') and RoleName like '%{comboBoxRole.Text}%'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                usersDataGrid.DataSource = dataSet.Tables[0];
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
