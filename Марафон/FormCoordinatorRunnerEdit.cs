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
using System.IO;

namespace Марафон
{
    public partial class FormCoordinatorRunnerEdit : Form
    {
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter; 
        DataRow row;
        public string email;
        public FormCoordinatorRunnerEdit()
        {
            connectionSql = new SqlConnection(Connection.GetString());
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormCoordinatorRunnerEdit_Load(object sender, EventArgs e)
        {
            timerMarathon.Start(); try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.[Users].FirstName, dbo.[Users].LastName, dbo.Runner.Gender,FORMAT([DateOfBirth], '%d.%M.%y') as 'DateOfBirth', " +
                    "dbo.Country.CountryName, dbo.Charity.CharityName, (select SUM(Amount) " +
                    "from Sponsorship where RegistrationId = [Registration].[RegistrationId]) as 'Amount',dbo.Registration.RaceKitOptionId, [RegistrationStatusId], dbo.Users.Picture " +
                    "FROM dbo.Registration INNER JOIN dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId " +
                    "INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId " +
                    "INNER JOIN dbo.[Users] ON dbo.Runner.Email = dbo.[Users].Email " +
                    $"INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode where [Runner].Email = '{emailUserLabel.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                row = dataSet.Tables[0].Rows[0];

                nameUserLabel.Text = row[0].ToString();
                lastNameUserLabel.Text = row[1].ToString();
                genderUserLabel.Text = row[2].ToString();
                dateUserLabel.Text = row[3].ToString();
                countryUserLabel.Text = row[4].ToString();
                orgUserLabel.Text = row[5].ToString();
                moneyUserLabel.Text = "$" + row[6].ToString();
                packageUserLabel.Text = row[7].ToString();
                setPictures(Convert.ToInt32(row[8]));

                if (row[9]!=null)
                {
                    userPictureBox.Image = Image.FromFile("picture/" + row[9]);
                }
                else
                {
                    userPictureBox.Image = null;
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
        private void setPictures(int index) //Устанавливаем картинку галочки на пунктах регистрации
        {
            PictureBox[] pictureBoxes = new PictureBox[] { regPictureBox, payPictureBox, packagePictureBox, startPictureBox };
            for (int i = 0; i < index; i++)
            {
                pictureBoxes[i].Image = Bitmap.FromFile(@"C:\Users\Ренат\Desktop\Дистант 3 курс\2 семестр\УП 1\WSR 2017Программные решения для бизнеса\TP09_resources\WSR2016_TP09_ресурсы_сессия_5\marathon-skills-2016-status-icons\tick-icon.png"); //иконка галочки из 5 сессии
            }
        }
        private void FormCoordinatorRunnerEdit_FormClosing(object sender, FormClosingEventArgs e)
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
            FormCoordinatorRunner coordinatorRunner = new FormCoordinatorRunner(email);
            coordinatorRunner.Show();
            this.Hide();
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            FormRunnerEditProfile runnerEditProfile = new FormRunnerEditProfile(email);
            runnerEditProfile.labelEmail.Text = emailUserLabel.Text;
            runnerEditProfile.Show();
            this.Hide();
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void certificateButton_Click(object sender, EventArgs e)
        {
            FormCoordinatorRunnerEdit.ActiveForm.Hide();
            FormCertificate form = new FormCertificate(email);
            form.emailInfo = emailUserLabel.Text;
            form.nameInfo = nameUserLabel.Text;
            form.lastNameInfo = lastNameUserLabel.Text;
            form.Show();
        }
    }
}
