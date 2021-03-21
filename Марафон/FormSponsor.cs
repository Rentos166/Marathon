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
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            FormSponsorMoreInfoFond moreInfoFond = new FormSponsorMoreInfoFond(textBoxFond.Text);
            moreInfoFond.Show();
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
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 32)
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
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "Ваше имя";
            textBoxName.ForeColor = Color.Gray;

            comboBoxRunner.Text = "Иван Прудов - 204 (Russia)";
            comboBoxRunner.ForeColor = Color.Gray;

            textBoxNameCard.Text = "Владелец карты";
            textBoxNameCard.ForeColor = Color.Gray;

            textBoxNumCard.Text = "1234 1234 1234 1234";
            textBoxNumCard.ForeColor = Color.Gray;

            textBoxCardM.Text = "01";
            textBoxCardM.ForeColor = Color.Gray;

            textBoxCardY.Text = "2024";
            textBoxCardY.ForeColor = Color.Gray;

            textBoxCVC.Text = "123";
            textBoxCVC.ForeColor = Color.Gray;
            timerMarathon.Start();
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT RegistrationEvent.BibNumber, Runner.RunnerId, Users.FirstName, Users.LastName, Country.CountryName FROM Users,Runner, Country, RegistrationEvent, Registration WHERE Country.CountryCode = Runner.CountryCode AND Users.RoleId = 'R' AND Users.Email = Runner.Email AND Registration.RunnerId = Runner.RunnerId AND Registration.RegistrationId = RegistrationEvent.RegistrationId ORDER BY Users.FirstName", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + " - " + reader["BibNumber"].ToString() + " (" + reader["CountryName"].ToString() + ")";
                    item.value = reader["RunnerId"].ToString();
                    comboBoxRunner.Items.Add(item);
                }
            }

            conn.Close();
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
                                SqlConnection conn = new SqlConnection(Connection.GetString());
                                conn.Open();
                                SqlCommand command = new SqlCommand("UPDATE Registration Set SponsorshipTarget = SponsorshipTarget + " + textBoxPrice.Text + " WHERE RunnerId = '" + (comboBoxRunner.SelectedItem as ComboBoxItem).value + "'", conn);

                                command.ExecuteNonQuery();
                                FormSponsorConfirm formSponsorConfirm = new FormSponsorConfirm((comboBoxRunner.SelectedItem as ComboBoxItem).value, textBoxFond.Text, textBoxPrice.Text);
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

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Ваше имя")
            {
                textBoxName.Clear();
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxNameCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNameCard_Enter(object sender, EventArgs e)
        {
            if (textBoxNameCard.Text == "Владелец карты")
            {
                textBoxNameCard.Clear();
                textBoxNameCard.ForeColor = Color.Black;
            }
        }

        private void textBoxNumCard_Enter(object sender, EventArgs e)
        {
            if (textBoxNumCard.Text == "1234 1234 1234 1234")
            {
                textBoxNumCard.Clear();
                textBoxNumCard.ForeColor = Color.Black;
            }
        }

        private void textBoxCardM_Enter(object sender, EventArgs e)
        {
            if (textBoxCardM.Text == "01")
            {
                textBoxCardM.Clear();
                textBoxCardM.ForeColor = Color.Black;
            }
        }

        private void textBoxCardY_Enter(object sender, EventArgs e)
        {
            if (textBoxCardY.Text == "2024")
            {
                textBoxCardY.Clear();
                textBoxCardY.ForeColor = Color.Black;
            }
        }

        private void textBoxCVC_Enter(object sender, EventArgs e)
        {
            if (textBoxCVC.Text == "123")
            {
                textBoxCVC.Clear();
                textBoxCVC.ForeColor = Color.Black;
            }
        }

        private void labelFond_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == null)
            {
                textBoxName.Text = "Ваше имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void comboBoxRunner_Enter(object sender, EventArgs e)
        {
            if (comboBoxRunner.Text == "Иван Прудов - 204 (Russia)")
            {
                comboBoxRunner.Text = null;
                comboBoxRunner.ForeColor = Color.Black;
            }
        }

        private void comboBoxRunner_Leave(object sender, EventArgs e)
        {
            if (comboBoxRunner.Text == null)
            {
                comboBoxRunner.Text = "Иван Прудов - 204 (Russia)";
                comboBoxRunner.ForeColor = Color.Gray;
            }
        }

        private void textBoxNameCard_Leave(object sender, EventArgs e)
        {
            if (textBoxNameCard.Text == null)
            {
                textBoxNameCard.Text = "Владелец карты";
                textBoxNameCard.ForeColor = Color.Gray;
            }
        }

        private void textBoxNumCard_Leave(object sender, EventArgs e)
        {
            if (textBoxNumCard.Text == null)
            {
                textBoxNumCard.Text = "1234 1234 1234 1234";
                textBoxNumCard.ForeColor = Color.Gray;
            }
        }

        private void textBoxCardM_Leave(object sender, EventArgs e)
        {
            if (textBoxCardM.Text == null)
            {
                textBoxCardM.Text = "01";
                textBoxCardM.ForeColor = Color.Gray;
            }
        }

        private void textBoxCardY_Leave(object sender, EventArgs e)
        {
            if (textBoxCardY.Text == null)
            {
                textBoxCardY.Text = "2024";
                textBoxCardY.ForeColor = Color.Gray;
            }
        }

        private void textBoxCVC_Leave(object sender, EventArgs e)
        {
            if (textBoxCVC.Text == null)
            {
                textBoxCVC.Text = "123";
                textBoxCVC.ForeColor = Color.Gray;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRunner_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxRunner_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxRunner_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT TOP(1) Charity.CharityName, Charity.CharityId FROM Charity, Registration WHERE Charity.CharityId = Registration.CharityId AND Registration.RunnerId = " + (comboBoxRunner.SelectedItem as ComboBoxItem).value + "", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBoxFond.Text = reader["CharityName"].ToString();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
