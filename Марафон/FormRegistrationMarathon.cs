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
    public partial class FormRegistrationMarathon : Form
    {
        public string email;
        public int value;
        public string runnerId;
        public FormRegistrationMarathon(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void FormRegistrationMarathon_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Charity", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.text = reader["CharityName"].ToString();
                    item.value = reader["CharityId"].ToString();
                    comboBoxContrib.Items.Add(item);
                }
            }
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRunnerMenu formRM = new FormRunnerMenu(email);
            formRM.Show();
            this.Hide();
        }

        private void FormRegistrationMarathon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void textBoxConSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormRunnerMenu formRM = new FormRunnerMenu(email);
            formRM.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxConSum.Text == "" || comboBoxContrib.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберете спонсора из числа благотворительных организаций и внесите сумму спонсорского взноса", "Оповещение системы");
            }
            else
            {
                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                {
                    MessageBox.Show("Пожалуйста, выберете, как минимум, один из представленных марафонов");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Connection.GetString());
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Runner WHERE Email = '" + email + "'", conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            runnerId = reader["RunnerId"].ToString();
                        }
                    }
                    string ko = "";
                    if (checkBox1.Checked)
                        ko = "A";
                    if (checkBox2.Checked)
                        ko = "B";
                    if (checkBox3.Checked)
                        ko = "C";
                    SqlCommand command2 = new SqlCommand("INSERT INTO Registration Values (" + runnerId + ",'','" + ko + "','1','" + textBoxConSum.Text + "','" + (comboBoxContrib.SelectedItem as ComboBoxItem).value + "'," + value + ")", conn);
                    command2.ExecuteNonQuery();
                    FormRegistrationMarathonConfirm formRegistrationMarathonConfirm = new FormRegistrationMarathonConfirm(email);
                    formRegistrationMarathonConfirm.Show();
                    this.Hide();
                }
            }
        }

        private void labelMoreInfo_Click(object sender, EventArgs e)
        {
            FormSponsorMoreInfoFond infoFond = new FormSponsorMoreInfoFond(comboBoxContrib.Text);
            infoFond.Show();

        }

        private void textBoxConSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConSum_Leave(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += Convert.ToInt32(textBoxConSum.Text);
            labelSum.Text = value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 0;
            labelSum.Text = value.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 20;
            labelSum.Text = value.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 45;
            labelSum.Text = value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 145;
            labelSum.Text = value.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 75;
            labelSum.Text = value.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(labelSum.Text);
            value += 20;
            labelSum.Text = value.ToString();
        }
    }
}
