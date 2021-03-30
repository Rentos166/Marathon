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
    public partial class FormBMRCalculator : Form
    {
        public FormBMRCalculator()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormBMRCalculator_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void FormBMRCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMoreInfo moreInfo = new FormMoreInfo();
            moreInfo.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMoreInfo moreInfo = new FormMoreInfo();
            moreInfo.Show();
            this.Hide();
        }

        private void pictureBoxMale_Click(object sender, EventArgs e)
        {
            pictureBoxMale.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxFemale.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBoxFemale_Click(object sender, EventArgs e)
        {
            pictureBoxMale.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFemale.BorderStyle = BorderStyle.Fixed3D;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMale.BorderStyle == BorderStyle.Fixed3D)
                {
                    double bmr = 66 + (13.7 * Convert.ToDouble(numericUpDownWeight.Value)) + (5 * Convert.ToDouble(numericUpDownHeight.Value)) - (6.8 * Convert.ToDouble(numericUpDownOld.Value));

                    bmr = bmr / 1000;
                    bmr = Math.Round(bmr, 3);
                    label14.Text = bmr.ToString();

                    panel1.Visible = true;

                    label22.Text = " " + (Math.Round(bmr * 1.2, 2)).ToString();
                    label23.Text = " " + (Math.Round(bmr * 1.375, 2)).ToString();
                    label24.Text = " " + (Math.Round(bmr * 1.55, 2)).ToString();
                    label25.Text = " " + (Math.Round(bmr * 1.725, 2)).ToString();
                    label26.Text = " " + (Math.Round(bmr * 1.9, 2)).ToString();

                }

                if (pictureBoxFemale.BorderStyle == BorderStyle.Fixed3D)
                {
                    double bmr = 655 + (9.6 * Convert.ToDouble(numericUpDownWeight.Value)) + (1.8 * Convert.ToDouble(numericUpDownHeight.Value)) - (4.7 * Convert.ToDouble(numericUpDownOld.Value));

                    bmr = bmr / 1000;
                    bmr = Math.Round(bmr, 3);
                    label14.Text = bmr.ToString();

                    panel1.Visible = true;

                    label22.Text = " " + (Math.Round(bmr * 1.2, 2)).ToString();
                    label23.Text = " " + (Math.Round(bmr * 1.375, 2)).ToString();
                    label24.Text = " " + (Math.Round(bmr * 1.55, 2)).ToString();
                    label25.Text = " " + (Math.Round(bmr * 1.725, 2)).ToString();
                    label26.Text = " " + (Math.Round(bmr * 1.9, 2)).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Деление значений на ноль невозможно!", "Опомещение системы");
            }
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {
            FormBMRCalculatorInfo bmrInfo = new FormBMRCalculatorInfo();
            bmrInfo.Show();
        }
    }
}

