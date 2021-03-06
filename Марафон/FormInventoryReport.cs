﻿using System;
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
    public partial class FormInventoryReport : Form
    {
        public string email;
        public FormInventoryReport(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void FormInventoryReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormInventoryReport_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            if (Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text) < 0)
                idOrderLabel.Text = Convert.ToString((Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text))*-1);

            if (Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text) < 0)
                rfidOrderLabel.Text = Convert.ToString((Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text))*-1);

            if (Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text) < 0)
                baseballOrderLabel.Text = Convert.ToString((Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text))*-1);

            if (Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text) < 0)
                waterOrderLabel.Text = Convert.ToString((Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text))*-1);

            if (Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text) < 0)
                tshirtOrderLabel.Text = Convert.ToString((Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text))*-1);

            if (Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text) < 0)
                souvenirOrderLabel.Text = Convert.ToString((Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text))*-1);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файл отправлен на печать!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory(email);
            inventory.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
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
    }
}
