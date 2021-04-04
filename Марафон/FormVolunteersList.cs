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
    public partial class FormVolunteersList : Form
    {
        public string email;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public FormVolunteersList(string email)
        {
            this.email = email;
            connectionSql = new SqlConnection(Connection.GetString());
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
        public void loadVolunters() //Выгрузка из бд всех волонтеров
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Volunteer.VolunteerId, dbo.Country.CountryCode, dbo.Volunteer.LastName AS 'Фамилия', dbo.Volunteer.FirstName AS 'Имя', dbo.Country.CountryName AS 'Страна', dbo.Volunteer.Gender AS 'Пол' FROM    dbo.Volunteer INNER JOIN dbo.Country ON dbo.Volunteer.CountryCode = dbo.Country.CountryCode", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                volunterDataGrid.DataSource = dataSet.Tables[0];
                volunterDataGrid.Columns[0].Visible = false;
                volunterDataGrid.Columns[1].Visible = false;
                labelNum.Text = dataSet.Tables[0].Rows.Count.ToString();

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
        private void FormVolunteersList_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadVolunters();
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin(email);
            menuAdmin.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonVolunteers_Click(object sender, EventArgs e)
        {
            FormVolunteersLoad volunteersLoad = new FormVolunteersLoad(email);
            volunteersLoad.Show();
            this.Hide();
        }

        private void FormVolunteersList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string orderBy = "";
            if (comboBoxSort.SelectedIndex == 0)
            {
                orderBy = "FirstName";
            }
            else if (comboBoxSort.SelectedIndex == 1)
            {
                orderBy = "LastName";
            }
            else if (comboBoxSort.SelectedIndex == 2)
            {
                orderBy = "CountryName";
            }
            else
            {
                orderBy = "Gender";
            }
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT dbo.Volunteer.VolunteerId, dbo.Country.CountryCode, dbo.Volunteer.LastName AS 'Фамилия', dbo.Volunteer.FirstName AS 'Имя', dbo.Country.CountryName AS 'Страна', dbo.Volunteer.Gender AS 'Пол' FROM    dbo.Volunteer INNER JOIN dbo.Country ON dbo.Volunteer.CountryCode = dbo.Country.CountryCode ORDER BY {orderBy} desc", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                volunterDataGrid.DataSource = dataSet.Tables[0];
                volunterDataGrid.Columns[0].Visible = false;
                volunterDataGrid.Columns[1].Visible = false;
                labelNum.Text = dataSet.Tables[0].Rows.Count.ToString();
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
