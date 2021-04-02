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
    public partial class FormCoordinatorSponsors : Form
    {
        public string email;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public FormCoordinatorSponsors(string email)
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

        private void FormCoordinatorSponsors_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            try
            {
                int fullCost = 0;
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT Charity.CharityLogo, Charity.CharityName, SUM(Registration.SponsorshipTarget) as Amount FROM Charity, Registration WHERE Charity.CharityId = Registration.CharityId GROUP BY Charity.CharityName, Charity.CharityLogo", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                SponsorSort[] control = new SponsorSort[dataSet.Tables[0].Rows.Count];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new SponsorSort();
                    control[i].Image = Bitmap.FromFile(@"C:\Users\Ренат\Desktop\Дистант 3 курс\2 семестр\УП 1\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][0].ToString());
                    control[i].Organization = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Amount = dataSet.Tables[0].Rows[i][2].ToString();
                    flowLayoutPanel.Controls.Add(control[i]);
                    fullCost += Convert.ToInt32(dataSet.Tables[0].Rows[i][2]);
                }
                organizationNummberLabel.Text = control.Count().ToString();
                moneyNumberLabel.Text = "$" + fullCost;
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
 
        private void FormCoordinatorSponsors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCoordinator coordinator = new FormCoordinator(email);
            coordinator.Show();
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string orderBy = "";
            if (statusComboBox.SelectedIndex == 0) orderBy = "CharityName";
            else orderBy = "Amount";

            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT Charity.CharityLogo, Charity.CharityName, SUM(Registration.SponsorshipTarget) as Amount FROM Charity, Registration WHERE Charity.CharityId = Registration.CharityId GROUP BY Charity.CharityName, Charity.CharityLogo order by {orderBy} desc", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                SponsorSort[] control = new SponsorSort[dataSet.Tables[0].Rows.Count];
                flowLayoutPanel.Controls.Clear();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new SponsorSort();
                    control[i].Image = Bitmap.FromFile(@"C:\Users\Ренат\Desktop\Дистант 3 курс\2 семестр\УП 1\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][0].ToString());
                    control[i].Organization = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Amount = dataSet.Tables[0].Rows[i][2].ToString();
                    flowLayoutPanel.Controls.Add(control[i]);
                }
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
    }
}
