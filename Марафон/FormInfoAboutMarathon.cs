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
    public partial class FormInfoAboutMarathon : Form
    {
        public FormInfoAboutMarathon()
        {
            InitializeComponent();
        }

        private void FormInfoAboutMarathon_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormInfoAboutMarathon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMoreInfo moreInfo = new FormMoreInfo();
            moreInfo.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormInteractiveMap formMap = new FormInteractiveMap();
            formMap.Show();
            this.Hide();
        }
    }
}
