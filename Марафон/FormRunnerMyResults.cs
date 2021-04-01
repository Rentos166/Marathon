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
using System.Data;

namespace Марафон
{
    public partial class FormRunnerMyResults : Form
    {
        int minAge, maxAge = 0;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public FormRunnerMyResults()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(Connection.GetString());
        }

        private void FormRunnerMyResults_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            try
            {
                takeAgesAndGender();
                connectionSql.Open();

                string query = "SELECT [RegistrationId], [MarathonName] as 'Марафон', [EventTypeName] as 'Дистанция', CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    "(select[PlaceId] from[Place]([MarathonName], [EventTypeName]) where[RegId] = [RegistrationId]) as 'Общее место'," +
                    $"(select[PlaceId] from[PlaceYear]([MarathonName], [EventTypeName], {minAge}, {maxAge}) where[RegId] = [RegistrationId]) as 'Место по категории'" +
                    "FROM[RegistrationEvent] " +
                    "inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "where[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{FormAuthorization.email}'))";

                dataAdapter = new SqlDataAdapter(query, connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                resultDataGrid.DataSource = table;
                resultDataGrid.Columns[0].Visible = false;
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

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormRunnerMyResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //FormRunnerMenu runnerMenu = new FormRunnerMenu();
        }

        private void takeAgesAndGender()//Выставляем диапазон возраста в зависимости от возраста нашего пользователя
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select YEAR(GETDATE())-YEAR([DateOfBirth]), [Gender] from [Runner] where  Email = '{FormAuthorization.email}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int age = (int)dataSet.Tables[0].Rows[0][0];
                sexLoadLabel.Text = (string)dataSet.Tables[0].Rows[0][1];

                if (age < 18)
                {
                    minAge = 0;
                    maxAge = 17;
                }
                if (age >= 18 && age <= 29)
                {
                    minAge = 18;
                    maxAge = 29;
                }
                if (age >= 30 && age <= 39)
                {
                    minAge = 30;
                    maxAge = 39;
                }
                if (age >= 40 && age <= 55)
                {
                    minAge = 40;
                    maxAge = 55;
                }
                if (age >= 56 && age <= 70)
                {
                    minAge = 56;
                    maxAge = 70;
                }
                if (age > 70)
                {
                    minAge = 71;
                    maxAge = 120;
                }
                ageLoadLabel.Text = $"{minAge}-{maxAge}";
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
