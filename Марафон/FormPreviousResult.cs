﻿using System;
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
    public partial class FormPreviousResult : Form
    {
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public FormPreviousResult()
        {
            connectionSql = new SqlConnection(Connection.GetString());
            InitializeComponent();
        }
        private void loadMarathon() //Загружаем все виды марафонов в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT MarathonId, CONVERT(NVARCHAR, YearHeld) + ' - ' + CityName AS 'Город', CityName as 'Hoho' From Marathon", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                marathonComboBox.DataSource = dataSet.Tables[0];
                marathonComboBox.DisplayMember = "Город";
                marathonComboBox.ValueMember = "Hoho";
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
        private void loadDistance() //Загружаем список дистанций в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT EventTypeId, EventTypeName FROM EventType", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                distanceComboBox.DataSource = dataSet.Tables[0];
                distanceComboBox.DisplayMember = "EventTypeName";
                distanceComboBox.ValueMember = "EventTypeName";
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

        private void loadGender() //Загружаем пол в список
        {
            connectionSql = new SqlConnection(Connection.GetString());
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT Gender FROM Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                sexComboBox.DataSource = dataSet.Tables[0];
                sexComboBox.DisplayMember = "Gender";
                sexComboBox.ValueMember = "Gender";
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
        private void loadData() //Выгружаем дану в dataGrid
        {
            connectionSql = new SqlConnection(Connection.GetString());
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email WHERE RaceTime IS NOT NULL and RaceTime != 0 ORDER BY RaceTime ASC", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                raceDataGrid.DataSource = dataSet.Tables[0];
            }
            catch (Exception exceptionn)
            {
                MessageBox.Show(exceptionn.Message);
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

        private void FormPreviousResult_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadMarathon();
            loadDistance();
            loadGender();
            loadData();
            ageComboBox.Items.Add("18-29");
            ageComboBox.Items.Add("30-59");
            ageComboBox.Items.Add("60-89");
            ageComboBox.Items.Add("90-110");
            connectionSql = new SqlConnection(Connection.GetString());
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"select top 1 * from dbo.[Runner] order by RunnerId desc", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                runnerNumberLabel.Text = dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }

            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"select top 1 RegistrationEventId AS 'ID' from dbo.[RegistrationEvent] WHERE RaceTime IS NOT NULL order by RegistrationEventId desc", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                finishNumberLabel.Text = dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT AVG(RaceTime) AS RaceAvg FROM RegistrationEvent;", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                string a = dataSet.Tables[0].Rows[0][0].ToString();
                double unixTimeStamp = Double.Parse(a);
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
                dtDateTime = dtDateTime.Subtract(new TimeSpan(3, 0, 0));
                timeNumberLabel.Text = $"{dtDateTime.Hour}h {dtDateTime.Minute}m {dtDateTime.Second}s";
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
            FormMoreInfo moreInfo = new FormMoreInfo();
            moreInfo.Show();
            this.Hide();
        }

        private void FormPreviousResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connectionSql = new SqlConnection(Connection.GetString());
            try
            {
                connectionSql.Open();
                if (ageComboBox.Text == "18-29")
                {
                    dataAdapter = new SqlDataAdapter($"SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email where RaceTime is not null and RaceTime != 0 and CityName like '%{marathonComboBox.SelectedValue}%' and Runner.Gender like '%{sexComboBox.Text}%' and EventTypeName like '%{distanceComboBox.Text}%' and YEAR(GETDATE()) - YEAR([DateOfBirth])<29 and YEAR(GETDATE()) - YEAR([DateOfBirth]) >19 order by[RaceTime] asc", connectionSql);
                }
                else if (ageComboBox.Text == "30-59")
                {
                    dataAdapter = new SqlDataAdapter($"SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email where RaceTime is not null and RaceTime != 0 and CityName like '%{marathonComboBox.SelectedValue}%' and Runner.Gender like '%{sexComboBox.Text}%' and EventTypeName like '%{distanceComboBox.Text}%' and YEAR(GETDATE()) - YEAR([DateOfBirth]) < 59  and YEAR(GETDATE()) - YEAR([DateOfBirth])>30 order by[RaceTime] asc", connectionSql);
                }
                else if (ageComboBox.Text == "60-89")
                {
                    dataAdapter = new SqlDataAdapter($"SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email where RaceTime is not null and RaceTime != 0 and CityName like '%{marathonComboBox.SelectedValue}%' and Runner.Gender like '%{sexComboBox.Text}%' and EventTypeName like '%{distanceComboBox.Text}%' and YEAR(GETDATE()) - YEAR([DateOfBirth]) > 60 and YEAR(GETDATE()) - YEAR([DateOfBirth])<89 order by[RaceTime] asc", connectionSql);
                }
                else if (ageComboBox.Text == "90-110")
                {
                    dataAdapter = new SqlDataAdapter($"SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email where RaceTime is not null and RaceTime != 0 and CityName like '%{marathonComboBox.SelectedValue}%' and Runner.Gender like '%{sexComboBox.Text}%' and EventTypeName like '%{distanceComboBox.Text}%' and  YEAR(GETDATE()) - YEAR([DateOfBirth]) > 90 and YEAR(GETDATE()) - YEAR([DateOfBirth])<110 order by[RaceTime] asc", connectionSql);
                }
                else
                {
                    dataAdapter = new SqlDataAdapter($"SELECT  CONVERT(nvarchar, CONVERT(datetime, dbo.RegistrationEvent.RaceTime/100000.0), 8) as 'Время', dbo.[Users].FirstName as 'Имя', dbo.Runner.CountryCode as 'Код страны' FROM dbo.[Users] INNER JOIN dbo.Registration INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.EventType INNER JOIN dbo.Event ON dbo.EventType.EventTypeId = dbo.Event.EventTypeId INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.Gender ON dbo.Runner.Gender = dbo.Gender.Gender AND dbo.Runner.Gender = dbo.Gender.Gender ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email where RaceTime is not null and RaceTime != 0 and CityName like '%{marathonComboBox.SelectedValue}%' and Runner.Gender like '%{sexComboBox.Text}%' and EventTypeName like '%{distanceComboBox.Text}%' order by[RaceTime] asc", connectionSql);
                }
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                raceDataGrid.DataSource = dataSet.Tables[0];
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
