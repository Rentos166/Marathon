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
    public partial class FormMenuAdmin : Form
    {
        public string email;
        public FormMenuAdmin(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;

            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormAdminUsersList usersList = new FormAdminUsersList(email);
            usersList.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonBlagoOrganiz_Click(object sender, EventArgs e)
        {

        }
    }
}
