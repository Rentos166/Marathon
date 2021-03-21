using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Марафон
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            openFileDialogMar.CheckFileExists = true;
            openFileDialogMar.AddExtension = true;
            openFileDialogMar.Multiselect = true;
            openFileDialogMar.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
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
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (openFileDialogMar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPic.Text = openFileDialogMar.FileName;
                pictureBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPicture.Image = Image.FromFile(openFileDialogMar.FileName);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
                if (textBoxFirstName.Text == "" && textBoxEmail.Text == "" && textBoxPassword.Text == "" &&
                    textBoxConfirmPassword.Text == "" && textBoxLastName.Text == "" && comboBoxGender.SelectedItem == null &&
                    comboBoxCountry.SelectedItem == null && dateTimePickerBirth.Value == null)
                {
                    MessageBox.Show("Одно или несколько обязательных полей для ввода (отмеченных знаком *) не были заполнены!", "Оповещение системы");
                }
                else
                {
                    Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                    Match emailMatch = emailRegex.Match(textBoxEmail.Text);

                    if (emailMatch.Value == "")
                        MessageBox.Show("Некорректный формат email!", "Оповещение системы");
                    else
                    {
                        bool digit = false;
                        bool spec = false;
                        bool lowChar = false;
                        bool pass = false;

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
                            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                            {
                                MessageBox.Show("Пароли не совпадают!", "Оповещение системы");
                            }
                            else
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
                                    SqlCommand command = new SqlCommand("INSERT INTO Users VALUES(@e,@p,@l,@f,@r,@pp)", conn);
                                    command.Parameters.Add("@e", textBoxEmail.Text);
                                    command.Parameters.Add("@p", textBoxPassword.Text);
                                    command.Parameters.Add("@l", textBoxFirstName.Text);
                                    command.Parameters.Add("@f", textBoxLastName.Text);
                                    command.Parameters.Add("@r", "R");
                                    command.Parameters.Add("@pp", textBoxPic.Text);
                                    command.ExecuteNonQuery();
                                    SqlCommand command2 = new SqlCommand("INSERT INTO Runner(Email, Gender, DateOfBirth, CountryCode) VALUES(@e, @g, @d, @c)", conn);
                                    command2.Parameters.Add("@e", textBoxEmail.Text);
                                    command2.Parameters.Add("@g", (comboBoxGender.SelectedItem as ComboBoxItem).value);
                                    command2.Parameters.Add("@d", dateTimePickerBirth.Value);
                                    command2.Parameters.Add("@c", (comboBoxCountry.SelectedItem as ComboBoxItem).value);
                                    command2.ExecuteNonQuery();
                                    try
                                    {
                                        Bitmap bmp = new Bitmap(openFileDialogMar.FileName);
                                        bmp.Save("picture/" + openFileDialogMar.SafeFileName);
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    FormRegistrationMarathon formRegMar = new FormRegistrationMarathon(textBoxEmail.Text);
                                    formRegMar.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Введите email")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == null)
            {
                textBoxEmail.Text = "Введите email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Введите имя")
            {
                textBoxFirstName.Clear();
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == null)
            {
                textBoxFirstName.Text = "Введите имя";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Введите фамилию")
            {
                textBoxLastName.Clear();
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == null)
            {
                textBoxLastName.Text = "Введите фамилию";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }
    }
        
    
}
