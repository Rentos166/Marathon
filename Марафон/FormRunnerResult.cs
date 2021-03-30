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
    public partial class FormRunnerResult : Form
    {
        public string registrationId;
        bool checkCancelButton = false;
        SqlConnection connection = new SqlConnection(Connection.GetString());
        public FormRunnerResult()
        {
            int ageUser = Program.userInfo.DateOfBirth.Year;
            //labelGender.Text += Program.userInfo.Gender == "Male" ? "мужской" : "женский";
            //labelAge.Text += Program.userInfo.AgeGroup == 1 ? "до 18" : Program.userInfo.AgeGroup == 2 ? "18-29" : Program.userInfo.AgeGroup == 3 ? "30-39" : Program.userInfo.AgeGroup == 4 ? "40-55" : Program.userInfo.AgeGroup == 5 ? "56-70" : "от 70";
            List<string> eventId = new List<string>();
            List<string> raceTime = new List<string>();
            //listViewResults.Items.Clear();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT EventId, RaceTime, RegistrationId FROM RegistrationEvent WHERE RegistrationId = (SELECT RegistrationId FROM Registration WHERE RunnerId = Program.userInfo.RunnerId)", connection);
            ListViewItem item;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventId.Add(reader["EventId"].ToString());
                raceTime.Add(reader["RaceTime"].ToString());
                registrationId = reader["RegistrationId"].ToString();
            }
            reader.Close();
            for (int i = 0; i < eventId.Count; i++)
            {
                int position = CheckNumRunner(eventId[i]);
                int groupPosition = CheckGroupNum(eventId[i]);
                sqlCommand = new SqlCommand("SELECT YearHeld, CountryCode FROM Marаthоn WHERE MarathonId = (SELECT MarathonId FROM Evеnt WHERE EventId = eventId[i])", connection);
                SqlDataReader newReader = sqlCommand.ExecuteReader();
                newReader.Read();
                string lengthRun = eventId[i].ToString().Contains("FM") ? "42 км. Полный марафон" : eventId[i].ToString().Contains("FR") ? "5 км. Мини-марафон" : "21 км. Полу-марафон";
                item = new ListViewItem(new string[] { $"{newReader["YearHeld"].ToString()} {newReader["CountryCode"].ToString()}", lengthRun, $"{raceTime[i]} секунд", $"{position}", $"{groupPosition}" });
                listViewResults.Items.Add(item);
                newReader.Close();
            }
            connection.Close();
            InitializeComponent();
        }
        private int CheckNumRunner(string Id)
        {
            int counter = 1;
            SqlCommand sqlCommand = new SqlCommand("SELECT RegistrationId FROM RegistrationEvent WHERE EventId = Id ORDER BY RaceTime", connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read() && (dataReader["RegistrationId"].ToString() != registrationId))
            {
                counter++;
            }
            dataReader.Close();
            return counter;
        }
        private int CheckGroupNum(string Id)
        {
            int counter = 1;
            SqlCommand sqlCommand = new SqlCommand("SELECT RegistrationEvent.RegistrationId FROM RegistrationEvent, Registration WHERE Registration.AgeId = Program.userInfo.AgeGroup AND RegistrationEvent.EventId = '11_1FM' AND Registration.RegistrationId = RegistrationEvent.RegistrationId ORDER BY RegistrationEvent.RaceTime", connection);
            SqlDataReader newDataReader = sqlCommand.ExecuteReader();
            while (newDataReader.Read() && (newDataReader["RegistrationId"].ToString() != registrationId))
            {
                counter++;
            }
            newDataReader.Close();
            return counter;
        }

        private void FormRunnerResult_Load(object sender, EventArgs e)
        {

        }
    }
}
