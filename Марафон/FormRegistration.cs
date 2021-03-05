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

namespace Марафон
{
    public partial class FormRegistration : Form
    {
        void ShowGender()
        {
            comboBoxGender.Items.Clear();
            foreach (Gender gender in Program.marDb.Gender)
            {
                string[] item = { gender.Gender1 };
                comboBoxGender.Items.Add(string.Join(" ", item));
            }
        }
        void ShowCountry()
        {
            comboBoxCountry.Items.Clear();
            foreach (Country country in Program.marDb.Country)
            {
                string[] item = { country.CountryCode };
                comboBoxCountry.Items.Add(string.Join(" ", item));
            }
        }
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            ShowGender();
            ShowCountry();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            openFileDialogMar.CheckFileExists = true;
            openFileDialogMar.AddExtension = true;
            openFileDialogMar.Multiselect = true;
            openFileDialogMar.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

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
            try
            {
                if (textBoxFirstName.Text != "" && textBoxEmail.Text != "" && textBoxPassword.Text != "" &&
                    textBoxConfirmPassword.Text != "" && textBoxLastName.Text != "" && comboBoxGender.SelectedItem != null &&
                    comboBoxCountry.SelectedItem != null && dateTimePickerBirth.Value != null)
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
                                    Runner runner = new Runner();
                                    runner.Email = textBoxEmail.Text;
                                    runner.User.Email = textBoxEmail.Text;
                                    runner.User.Password = textBoxPassword.Text;
                                    runner.User.FirstName = textBoxFirstName.Text;
                                    runner.User.LastName = textBoxLastName.Text;
                                    runner.User.RoleId = "R";
                                    runner.Gender = comboBoxGender.SelectedItem.ToString();
                                    runner.DateOfBirth = dateTimePickerBirth.Value;
                                    runner.CountryCode = comboBoxCountry.SelectedItem.ToString();
                                    //  Program.marathonSkillsEntities.Runner.Add(runner);
                                    //  Program.marathonSkillsEntities.SaveChanges();
                                }
                            }
                        }

                        else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
        
    
}
