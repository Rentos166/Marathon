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
using System.IO;
namespace Марафон
{
    public partial class FormCertificate : Form
    {
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        public string emailInfo, nameInfo, lastNameInfo;
        public FormCertificate()
        {
            connectionSql = new SqlConnection(Connection.GetString());
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormCertificate_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadRace();
        }
        private void loadRace() //Загрузка всех дистанций в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select * from EventType", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                connectionSql.Close();


                raceComboBox.DataSource = dataSet.Tables[0];
                raceComboBox.DisplayMember = "EventTypeName";
                raceComboBox.ValueMember = "EventTypeId";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void createCertificate() //Запрос для создания сертификата и выгрузка текста
        {
            try
            {
                notOkPanel.Visible = true;
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [MarathonName] as 'Марафон', [CityName] +', '+ [CountryCode] as 'Place', [EventTypeName]," +
                    " CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    " (select SUM(Amount) from Sponsorship where RegistrationId = [Registration].[RegistrationId]) as 'Amount' FROM[RegistrationEvent]" +
                    " inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "inner join[Registration] on RegistrationEvent.RegistrationId = Registration.RegistrationId" +
                    " inner join Charity on Registration.CharityId = Charity.CharityId " +
                    " where[RegistrationEvent].[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{emailInfo}')) and[EventTypeName] = '{raceComboBox.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    DataRow dataRow = dataSet.Tables[0].Rows[0];
                    if (dataRow[3].ToString() != "" && dataRow[3].ToString() != "00:00:00")
                    {
                        notOkPanel.Visible = false;
                        congratulationsLabel.Text = $"Поздравляем {nameInfo} {lastNameInfo} с участием в {dataRow[2]}. Ваши результаты время {dataRow[3]} и занятое место - {dataRow[4]}-ое!";
                        marathonLabel.Text = dataRow[0].ToString();
                        cityLabel.Text = dataRow[1].ToString();
                        moneyLabel.Text = $"Вы также заработали ${dataRow[6]} для вашей благотворительной организации!";
                        logoPictureBox.Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataRow[5].ToString());
                    }
                    else
                    {
                        errorLabel.Text = "Бегун не финишировал вовремя";
                    }
                }
                else
                {
                    errorLabel.Text = "Бегун не принимал участия в марафоне такого типа";
                }
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

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createCertificate();
        }

        private void FormCertificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCoordinatorRunnerEdit runnerEdit = new FormCoordinatorRunnerEdit();
            runnerEdit.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
