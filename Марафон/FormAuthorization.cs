using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон
{
    public struct Users
    {
        public string email;
        public string password;
        public string type;
        public string fn;
        public string ln;
    }
    public partial class FormAuthorization : Form
    {

        public static Users users = new Users();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {

        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                //ищем в базе данных пользователя с такими логином и паролем и запоминаем их
                foreach (User user in Program.marDb.User)
                {
                    if (textBoxEmail.Text == user.Email && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.email = user.Email;
                        users.password = user.Password;
                        users.type = user.RoleId;
                        users.fn = user.FirstName;
                        users.ln = user.LastName;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    if (users.type == "R")
                    {
                        MessageBox.Show("Вы вошли в систему как: Бегун, " + users.fn + " " + users.ln, "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        FormRunnerMenu runnerMenu = new FormRunnerMenu();
                        runnerMenu.Show();
                        this.Hide();
                    }
                    else if (users.type == "A")
                    {
                        MessageBox.Show("Вы вошли в систему как: Администратор, " + users.fn + " " + users.ln, "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        FormMenuAdmin administratorMenu = new FormMenuAdmin();
                        administratorMenu.Show();
                        this.Hide();
                    }
                    else if (users.type == "C")
                    {
                        MessageBox.Show("Вы вошли в систему как: Координатор, " + users.fn + " " + users.ln, "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        FormCoordinator coordinator = new FormCoordinator();
                        coordinator.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
