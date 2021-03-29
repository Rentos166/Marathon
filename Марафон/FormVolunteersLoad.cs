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
    public partial class FormVolunteersLoad : Form
    {
        public string email;
        public FormVolunteersLoad(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormVolunteersLoad_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            openFileDialogVol.Filter = "CSV files|*.csv;";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormVolunteersList volunteersList = new FormVolunteersList(email);
            volunteersList.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormVolunteersList volunteersList = new FormVolunteersList(email);
            volunteersList.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void FormVolunteersLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialogVol_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            string[] data = File.ReadAllLines(openFileDialogVol.FileName);
            for (int i = 1; i < data.Length; i++)
            {
                String[] word = data[i].Split(new char[] { ',' });
                for (int j = 0; j < word.Length; j++)
                {
                    //MessageBox.Show(word[j]);
                    SqlCommand commanSearchId = new SqlCommand("SELECT * FROM Volunteer WHERE VolunteerId = '" + word[0] + "'", conn);
                    bool t = true;
                    using (SqlDataReader reader = commanSearchId.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            t = false;
                        }

                    }
                    if (!t)
                    {
                        try
                        {
                            if (word[4] == "F")
                                word[4] = "Female";
                            if (word[4] == "M")
                                word[4] = "Male";

                            SqlCommand command1 = new SqlCommand("UPDATE Volunteer Set FirstName = '" + word[2] + "', LastName = '" + word[1] + "', CountryCode = '" + word[3] + "', Gender = '" + word[4] + "' WHERE VolunteerId = '" + word[0] + "'", conn);
                            command1.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    if (t)
                    {
                        try
                        {
                            SqlCommand insert = new SqlCommand("SET IDENTITY_INSERT Volunteer ON", conn);
                            insert.ExecuteNonQuery();
                            SqlCommand command2 = new SqlCommand("SET IDENTITY_INSERT Volunteer ON; INSERT INTO Volunteer(VolunteerId, FirstName, LastName, CountryCode, Gender) Values(@id, @f, @l, @c, @g)", conn);

                            if (word[4] == "F")
                                word[4] = "Female";
                            if (word[4] == "M")
                                word[4] = "Male";
                            command2.Parameters.Add("@id", word[0]);
                            command2.Parameters.Add("@f", word[2]);
                            command2.Parameters.Add("@l", word[1]);
                            command2.Parameters.Add("@c", word[3]);
                            command2.Parameters.Add("@g", word[4]);

                            command2.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
            MessageBox.Show("Данные о волонтерах успешно добавлены!", "Оповещение системы");
            FormVolunteersList fm = new FormVolunteersList(email);
            fm.Show();
            this.Hide();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialogVol.ShowDialog() == DialogResult.OK)
            {
                textBoxCSV.Text = openFileDialogVol.SafeFileName;
                buttonLoad.Enabled = true;
            }
        }
    }
}
