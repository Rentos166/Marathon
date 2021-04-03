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
    public partial class FormRunnerEditProfile : Form
    {
        public string email;
        public FormRunnerEditProfile(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Введите фамилию")
            {
                textBoxFirstName.Clear();
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == null)
            {
                textBoxFirstName.Text = "Введите фамилию";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void FormRunnerEditProfile_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            openFileDialogPic.Filter = "Image Files |*.jpg;*.png;*gif;";
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand commandGender = new SqlCommand("SELECT * FROM Gender", conn);
            using (SqlDataReader reader = commandGender.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.text = reader["Gender"].ToString();
                    item.value = reader["Gender"].ToString();
                    comboBoxGender.Items.Add(item);
                }
            }
            SqlCommand commandCountry = new SqlCommand("SELECT * FROM Country ORDER BY CountryName", conn);
            using (SqlDataReader reader = commandCountry.ExecuteReader())
            {
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.text = reader["CountryName"].ToString();
                    item.value = reader["CountryCode"].ToString();
                    comboBoxCountry.Items.Add(item);
                }
            }
            SqlCommand command = new SqlCommand("SELECT Users.FirstName, Users.LastName, Country.CountryName, Runner.Gender, Runner.DateOfBirth, Users.Picture FROM Users, Country, Runner WHERE Users.Email = Runner.Email AND Runner.CountryCode = Country.CountryCode AND Users.Email = '" + email + "'", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    labelEmail.Text = email;
                    textBoxLastName.Text = reader["LastName"].ToString();
                    textBoxFirstName.Text = reader["FirstName"].ToString();
                    comboBoxGender.Text = reader["Gender"].ToString();
                    comboBoxCountry.Text = reader["CountryName"].ToString();
                    dateTimePickerBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    textBoxPicture.Text = reader["Picture"].ToString();
                    try
                    {
                        pictureBoxImage.Image = Image.FromFile("picture/" + reader["Picture"]);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormRunnerEditProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRunnerMenu formRunner = new FormRunnerMenu(email);
            formRunner.Show();
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
            FormRunnerMenu formRunner = new FormRunnerMenu(email);
            formRunner.Show();
            this.Hide();
        }

        private void buttonShowImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                textBoxPicture.Text = openFileDialogPic.SafeFileName;
                pictureBoxImage.Image = Image.FromFile(openFileDialogPic.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool changePass = false;
            if (textBoxPassword.Text != "" || textBoxConPas.Text != "")
            {
                changePass = true;
            }
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || comboBoxGender.Text == "" || comboBoxCountry.Text == "")
            {
                MessageBox.Show("Одно или несколько обязательных полей для ввода (отмеченных знаком *) не были заполнены!", "Оповещение системы");
            }
            else
            {
                bool digit = false;
                bool spec = false;
                bool lowChar = false;
                bool pass = false;
                bool cpass = false;
                if (changePass)
                {
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (Char.IsDigit(textBoxPassword.Text[i]))
                        {
                            digit = true;
                            break;
                        }
                    }
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (Char.IsLower(textBoxPassword.Text[i]))
                        {
                            lowChar = true;
                            break;
                        }
                    }
                    for (int i = 0; i < textBoxPassword.TextLength; i++)
                    {
                        if (textBoxPassword.Text[i] == '#' || textBoxPassword.Text[i] == '!' || textBoxPassword.Text[i] == '@' || textBoxPassword.Text[i] == '$' || textBoxPassword.Text[i] == '%' || textBoxPassword.Text[i] == '^')
                        {
                            spec = true;
                            break;
                        }
                    }
                    if (textBoxPassword.TextLength < 6 || !spec || !digit || !lowChar)
                        MessageBox.Show("Некорректный формат пароля! Длина пароля должна быть не менее шести символов, из которых должна быть, как минимум, одна буква нижнего регистра, одна цифра и один из следующих символов: !,#,%,^,@", "Оповещение системы");
                    else
                    {
                        pass = true;
                    }
                    if (pass)
                    {
                        if (textBoxPassword.Text != textBoxConPas.Text)
                        {
                            MessageBox.Show("Пароли не совпадают!", "Оповещение системы");
                        }
                        else
                        {
                            changePass = false;
                            cpass = true;
                        }
                    }
                }
                if (changePass == false)
                {
                    DateTime dateOfBirth = Convert.ToDateTime(dateTimePickerBirth.Value);
                    if (DateTime.Now.Year - dateOfBirth.Year < 10)
                    {
                        MessageBox.Show("Возраст бегуна на момент регистрации должен быть не менее 10ти лет!", "Оповещение системы");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(Connection.GetString());
                        conn.Open();
                        SqlCommand command = new SqlCommand("UPDATE Users Set FirstName = '" + textBoxLastName.Text + "', LastName = '" + textBoxFirstName.Text + "', Picture = '" + textBoxPicture.Text + "' WHERE Email = '" + email + "'", conn);
                        command.ExecuteNonQuery();
                        SqlCommand command2 = new SqlCommand("UPDATE Runner Set Gender = '" + (comboBoxGender.SelectedItem as ComboBoxItem).value + "', DateOfBirth = '" + dateTimePickerBirth.Value + "', CountryCode = '" + (comboBoxCountry.SelectedItem as ComboBoxItem).value + "' WHERE Email = '" + email + "'", conn);
                        command2.ExecuteNonQuery();
                        if (cpass)
                        {
                            SqlCommand command4 = new SqlCommand("UPDATE Users Set Password = '" + textBoxPassword.Text + "' WHERE Email = '" + email + "'", conn);

                            command4.ExecuteNonQuery();
                        }
                        try
                        {
                            Bitmap bmp = new Bitmap(openFileDialogPic.FileName);
                            bmp.Save("picture/" + openFileDialogPic.SafeFileName);
                        }
                        catch (Exception ex)
                        {

                        }
                        MessageBox.Show("Ваши данные изменены и сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormRunnerMenu formMenuRunner = new FormRunnerMenu(email);
                        formMenuRunner.Show();
                        this.Hide();
                    }
                }
            }

        }
    }
}
