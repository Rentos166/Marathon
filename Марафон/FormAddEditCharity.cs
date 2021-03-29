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
    public partial class FormAddEditCharity : Form
    {
        public string email;
        public string charityId;
        public FormAddEditCharity(string email, string charityId = null)
        {
            this.email = email;
            this.charityId = charityId;
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormAddEditCharity_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            openFileDialogPic.Filter = "Image files | *.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            if (charityId != null)
            {
                SqlConnection conn = new SqlConnection(Connection.GetString());
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Charity WHERE CharityId = '" + charityId + "'", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["CharityLogo"].ToString() != "")
                        {
                            pictureBoxCharity.Image = Image.FromFile("logo/" + reader["CharityLogo"].ToString());
                            textBoxImage.Text = reader["CharityLogo"].ToString();
                        }
                        textBoxName.Text = reader["CharityName"].ToString();
                        richTextBoxOpis.Text = reader["CharityDescription"].ToString();
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdminCharityList charityList = new FormAdminCharityList();
            charityList.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormAdminCharityList charityList = new FormAdminCharityList();
            charityList.Show();
            this.Hide();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                textBoxImage.Text = openFileDialogPic.SafeFileName;
                pictureBoxCharity.Image = Image.FromFile(openFileDialogPic.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Поле 'Наименование' благотворительной организации обязательно для заполнения!", "Оповещение системы");
            }
            else
            {
                if (charityId != null)
                {
                    SqlConnection conn = new SqlConnection(Connection.GetString());
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE Charity Set CharityName = @name, CharityDescription = @desc,  CharityLogo = @logo WHERE CharityId = '" + charityId + "'", conn);
                    command.Parameters.Add("@name", textBoxName.Text);
                    command.Parameters.Add("@desc", richTextBoxOpis.Text);
                    command.Parameters.Add("@logo", textBoxImage.Text);
                    command.ExecuteNonQuery();
                    try
                    {
                        if (textBoxImage.Text != "")
                        {
                            Bitmap bmp = new Bitmap(openFileDialogPic.FileName);
                            bmp.Save("logo/" + openFileDialogPic.SafeFileName);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    MessageBox.Show("Благотворительная организация " + textBoxName.Text + " успешно обновлена!", "Оповещение системы");
                    FormAdminCharityList fm = new FormAdminCharityList();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Connection.GetString());
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Charity Values(@name, @desc, @logo)", conn);
                    command.Parameters.Add("@name", textBoxName.Text);
                    command.Parameters.Add("@desc", richTextBoxOpis.Text);
                    command.Parameters.Add("@logo", textBoxImage.Text);
                    command.ExecuteNonQuery();
                    if (textBoxImage.Text != "")
                    {
                        Bitmap bmp = new Bitmap(openFileDialogPic.FileName);
                        bmp.Save("logo/" + openFileDialogPic.SafeFileName);
                    }
                    MessageBox.Show("Благотворительная организация " + textBoxName.Text + " успешно добавлена!", "Оповещение системы");
                    FormAdminCharityList fm = new FormAdminCharityList();
                    fm.Show();
                    this.Hide();
                }
            }
        }

        private void FormAddEditCharity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
