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
    public partial class FormInventoryReport : Form
    {
        public string email;
        public FormInventoryReport()
        {
            InitializeComponent();
        }

        private void FormInventoryReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormInventoryReport_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text) < 0)
                idOrderLabel.Text = (Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text)).ToString();

            if (Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text) < 0)
                rfidOrderLabel.Text = (Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text)).ToString();

            if (Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text) < 0)
                baseballOrderLabel.Text = (Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text)).ToString();

            if (Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text) < 0)
                waterOrderLabel.Text = (Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text)).ToString();

            if (Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text) < 0)
                tshirtOrderLabel.Text = (Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text)).ToString();

            if (Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text) < 0)
                souvenirOrderLabel.Text = (Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text)).ToString();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Файл отправлен на печать!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormInventory inventory = new FormInventory(email);
            inventory.Show();
            this.Hide();
        }
    }
}
