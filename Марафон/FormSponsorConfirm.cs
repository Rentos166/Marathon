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
    public partial class FormSponsorConfirm : Form
    {
        public string runnerId;
        public string sponsorshipTarget;
        public string charityName;
        public FormSponsorConfirm(string runnerId, string charityName, string sponsorshipTarget)
        {
            InitializeComponent();
            this.runnerId = runnerId;
            this.sponsorshipTarget = sponsorshipTarget;
            this.charityName = charityName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSponsor formSponsor = new FormSponsor();
            formSponsor.Show();
            this.Hide();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;

            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormSponsorConfirm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Users.FirstName, Users.LastName, Country.CountryName, RegistrationEvent.BibNumber FROM Users, Runner, Country, Registration, RegistrationEvent WHERE Country.CountryCode = Runner.CountryCode AND Runner.Email = Users.Email AND Runner.RunnerId = '" + runnerId + "' AND Registration.RunnerId = Runner.RunnerId AND Registration.RegistrationId = RegistrationEvent.RegistrationId", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBoxRunner.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + " (" + reader["BibNumber"].ToString() + ") " + "из " + reader["CountryName"].ToString();
                    textBoxFond.Text = charityName;
                    labelSum.Text = "$" + sponsorshipTarget;
                }
            }
            timerMarathon.Start();
        }

        private void labelSum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
