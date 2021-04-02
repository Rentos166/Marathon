using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон
{
    public partial class FormRunnerMenu : Form
    {
        public string email;
        public FormRunnerMenu(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            FormContacts formContacts = new FormContacts();
            formContacts.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;

            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormRunnerMenu_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void buttonRegforMar_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
            this.Hide();
        }

        private void buttonRedProfile_Click(object sender, EventArgs e)
        {
            FormRunnerEditProfile runnerEditProfile = new FormRunnerEditProfile(email);
            runnerEditProfile.Show();
            this.Hide();
        }

        private void buttonMyResult_Click(object sender, EventArgs e)
        {
            FormRunnerMyResults myResults = new FormRunnerMyResults();
            myResults.Show();
            this.Hide();
        }

        private void buttonMySpon_Click(object sender, EventArgs e)
        {
            FormRunnerMySponsor mySponsor = new FormRunnerMySponsor(email);
            mySponsor.Show();
            this.Hide();
        }
    }
}
