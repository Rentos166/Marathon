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
    public partial class FormWhitchRunner : Form
    {
        public FormWhitchRunner()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormWhitchRunner_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void buttonNewRunner_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }

        private void buttonRunnerBefore_Click(object sender, EventArgs e)
        {
            FormAuthorization authorization = new FormAuthorization();
            authorization.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormAuthorization authorization = new FormAuthorization();
            authorization.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
