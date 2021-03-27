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
    public partial class FormMoreInfo : Form
    {
        public FormMoreInfo()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;

            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormMoreInfo_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();

        }

        private void FormMoreInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonBlagoFond_Click(object sender, EventArgs e)
        {
            FormListBlago formListBlago = new FormListBlago();
            formListBlago.Show();
            this.Hide();
        }

        private void buttonMarathon_Click(object sender, EventArgs e)
        {
            FormInfoAboutMarathon formInfo = new FormInfoAboutMarathon();
            formInfo.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonTimeMar_Click(object sender, EventArgs e)
        {
            FormHowLongMarathon howLongMarathon = new FormHowLongMarathon();
            howLongMarathon.Show();
            this.Hide();
        }
    }
}
