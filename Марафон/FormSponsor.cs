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
    public partial class FormSponsor : Form
    {
        void ShowRunners()
        {
            comboBoxRunner.Items.Clear();
            foreach(Runner runners in Program.marDb.Runner)
            {
                string[] item = { runners.User.FirstName + " ", runners.User.LastName, "(" + runners.RunnerId.ToString() + ") из", runners.Country.CountryCode };
                comboBoxRunner.Items.Add(string.Join(" ", item));
            }
        }
        public FormSponsor()
        {
            InitializeComponent();
            ShowRunners();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            FormSponsorMoreInfoFond moreInfoFond = new FormSponsorMoreInfoFond();
            moreInfoFond.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBoxNumCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCardM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCardY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxPrice.Text);
            value -= 10;
            textBoxPrice.Text = value.ToString();

            if (value <= 0)
            {
                labelSum.Text = "$0";
                textBoxPrice.Text = "0".ToString();
            }
            else
                labelSum.Text = "$" + value.ToString();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBoxPrice.Text);
            value += 10;
            textBoxPrice.Text = value.ToString();
            labelSum.Text = "$" + value.ToString();

            if (value <= 0)
            {
                labelSum.Text = "$0";
                textBoxPrice.Text = "0".ToString();
            }
            else
                labelSum.Text = "$" + value.ToString();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                labelSum.Text = "$0";
                textBoxPrice.Text = "0".ToString();
            }
            else
                labelSum.Text = "$" + textBoxPrice.Text.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxNameCard.Text == "" || textBoxNumCard.Text == "" || textBoxCardM.Text == "" || textBoxCardY.Text == "" || textBoxCVC.Text == "" || comboBoxRunner.Text == "")
            {
                MessageBox.Show("Одно или несколько обязательных полей для ввода (отмеченных знаком *) не были заполненны!", "Оповещение системы");
            }
            else
            {
                if (textBoxNumCard.TextLength < 16)
                {
                    MessageBox.Show("Некорретный номер карты! Длина номера банковской карточки должна составлять 16 символов!", "Оповещение системы");
                }
                else
                {
                    DateTime cardTime = new DateTime(Convert.ToInt32(textBoxCardY.Text), Convert.ToInt32(textBoxCardM.Text), DateTime.Now.Day);

                    if (cardTime <= DateTime.Now)
                    {
                        MessageBox.Show("Указанный срок действия карты считается истекшим!", "Оповещение системы");
                    }
                    else
                    {
                        if (textBoxCVC.TextLength < 3)
                        {
                            MessageBox.Show("Некорректный CVC код! Длина кода должна составлять 3 символа!", "Оповещение системы");
                        }
                        else
                        {
                            if (textBoxPrice.Text == "" || textBoxPrice.Text == "0")
                            {
                                MessageBox.Show("Пожалуйста, укажите сумму спонсорского взноса более $0.", "Опомещение системы");
                            }
                            else
                            {
                                Sponsorship sponsorship = new Sponsorship();
                                sponsorship.SponsorName = textBoxName.Text;
                                sponsorship.Amount = Convert.ToDecimal(textBoxPrice.Text);
                                Program.marDb.Sponsorship.Add(sponsorship);
                                Program.marDb.SaveChanges();
                                FormSponsorConfirm formSponsorConfirm = new FormSponsorConfirm();
                                formSponsorConfirm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
