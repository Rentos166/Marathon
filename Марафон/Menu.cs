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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;

            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            FormSponsor formSponsor = new FormSponsor();
            formSponsor.Show();
            this.Hide();
        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            FormWhitchRunner formWhitchRunner = new FormWhitchRunner();
            formWhitchRunner.Show();
            this.Hide();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            FormMoreInfo formMoreInfo = new FormMoreInfo();
            formMoreInfo.Show();
            this.Hide();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
