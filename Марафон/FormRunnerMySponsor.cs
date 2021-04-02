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
    public partial class FormRunnerMySponsor : Form
    {
        public string email;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public FormRunnerMySponsor(string email)
        {
            this.email = email;
            InitializeComponent(); 
            connectionSql = new SqlConnection(Connection.GetString());
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormRunnerMySponsor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormRunnerMySponsor_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            loadCharity();
            loadSponsors();
        }
        private void loadCharity() //загрузка организации
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [CharityName], [CharityDescription], [CharityLogo] from Registration " +
                    "inner join Charity on[Registration].[CharityId] = [Charity].[CharityId] " +
                    $"where RunnerId = (select RunnerId from Runner where Email = '{FormAuthorization.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                infoLabel.Text = (string)dataSet.Tables[0].Rows[0][0];
                descriptionTextBox.Text = (string)dataSet.Tables[0].Rows[0][1];
                organizationPictureBox.Image = Bitmap.FromFile(@"C:\Users\Ренат\Desktop\Дистант 3 курс\2 семестр\УП 1\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + (string)dataSet.Tables[0].Rows[0][2]);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }
        private void loadSponsors() //загрузка всех людей, которые проспонсировали бегуна
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [SponsorName], [Amount] from [Sponsorship] where RegistrationId = (select RegistrationId from Registration where RunnerId = (select RunnerId from Runner where Email = '{FormAuthorization.email}'))", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int total = 0;
                SponsorMoney[] Control = new SponsorMoney[dataSet.Tables[0].Rows.Count];
                DataTable Table = new DataTable();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Control[i] = new SponsorMoney();
                    Control[i].NameLabel = dataSet.Tables[0].Rows[i][0].ToString();
                    Control[i].Amount = '$' + dataSet.Tables[0].Rows[i][1].ToString();
                    total += Convert.ToInt32(dataSet.Tables[0].Rows[i][1]);
                    if (flowLayoutPanel.Controls.Count < 0)
                    {
                        flowLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel.Controls.Add(Control[i]);
                    }
                }
                totalLabel.Text = "Всего $" + total.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRunnerMenu runnerMenu = new FormRunnerMenu(email);
            runnerMenu.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
