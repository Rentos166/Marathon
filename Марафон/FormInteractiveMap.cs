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
    public partial class FormInteractiveMap : Form
    {
        public FormInteractiveMap()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMoreInfo formMoreInfo = new FormMoreInfo();
            formMoreInfo.Show();
            this.Hide();
        }

        private void FormInteractiveMap_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void FormInteractiveMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxStart3_Click(object sender, EventArgs e)
        {
            FormCheckPointStart3 fchkps3 = new FormCheckPointStart3();
            fchkps3.Show();
        }

        private void pictureBoxStart1_Click(object sender, EventArgs e)
        {
            FormCheckPointStart2 fchkps2 = new FormCheckPointStart2();
            fchkps2.Show();
        }

        private void pictureBoxStart2_Click(object sender, EventArgs e)
        {
            FormCheckPointStart1 fchkps1 = new FormCheckPointStart1();
            fchkps1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormCheckPoint1 fcp1 = new FormCheckPoint1();
            fcp1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormCheckPoint2 fcp2 = new FormCheckPoint2();
            fcp2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormCheckPoint3 fcp3 = new FormCheckPoint3();
            fcp3.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormCheckPoint4 fcp4 = new FormCheckPoint4();
            fcp4.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormCheckPoint5 fcp5 = new FormCheckPoint5();
            fcp5.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormCheckPoint6 fcp6 = new FormCheckPoint6();
            fcp6.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FormCheckPoint7 fcp7 = new FormCheckPoint7();
            fcp7.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FormCheckPoint8 fcp8 = new FormCheckPoint8();
            fcp8.Show();
        }
    }
}
