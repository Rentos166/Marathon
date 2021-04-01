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
    public partial class FormCoordinatorRunner : Form
    {
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        string connection = @"Data Source=DESKTOP-PKUSCSQ\SQLEXPRESS;Initial Catalog=Marathon;Integrated Security=True";
        public string email;

        public FormCoordinatorRunner()
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
        public void loadRunners() //Выгрузка всех нужных данных в dataGrid
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.[Users].FirstName, dbo.[Users].LastName, dbo.Runner.Email,  " +
                    "dbo.RegistrationStatus.RegistrationStatus FROM            " +
                    "dbo.Registration INNER JOIN dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId " +
                    "= dbo.RegistrationStatus.RegistrationStatusId " +
                    "INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId " +
                    "INNER JOIN dbo.[Users] ON dbo.Runner.Email = dbo.[Users].Email", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                runnersDataGrid.DataSource = dataSet.Tables[0];
                totalNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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
        public void loadStatus() //Загрузка статуса регистрации в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from RegistrationStatus", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                statusComboBox.DataSource = dataSet.Tables[0];
                statusComboBox.DisplayMember = "RegistrationStatus";
                statusComboBox.ValueMember = "RegistrationStatusId";

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
        public void loadDistances() //Загрузка всех дистанций в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from EventType", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                distanceComboBox.DataSource = dataSet.Tables[0];
                distanceComboBox.DisplayMember = "EventTypeName";
                distanceComboBox.ValueMember = "EventTypeId";
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
        private void FormCoordinatorRunner_Load(object sender, EventArgs e)
        {
            timerMarathon.Start(); 
            loadDistances();
            loadStatus();
            loadRunners();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView rowView = (DataRowView)statusComboBox.SelectedItem;
                string statusName = rowView[1].ToString();
                rowView = (DataRowView)distanceComboBox.SelectedItem;
                string eventName = rowView[1].ToString();
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"SELECT dbo.[Users].FirstName, dbo.[Users].LastName, dbo.Runner.Email, dbo.RegistrationStatus.RegistrationStatus FROM dbo.Event INNER JOIN dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId " +
                    $" INNER JOIN dbo.RegistrationEvent ON dbo.Event.EventId = dbo.RegistrationEvent.EventId" +
                    $" INNER JOIN dbo.Registration ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId " +
                    $"INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.[Users] " +
                    $"ON dbo.Runner.Email = dbo.[Users].Email " +
                    $"INNER JOIN dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId " +
                    $"WHERE (dbo.EventType.EventTypeName = '{eventName}') AND (dbo.RegistrationStatus.RegistrationStatus = '{statusName}')", connectionSql);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                runnersDataGrid.DataSource = dataSet.Tables[0];
                totalNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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

        private void emailButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = null;
                using (var dialog = new FolderBrowserDialog())
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.SelectedPath + @"\runner.txt";

                connectionSql.Open();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    for (int j = 0; j < runnersDataGrid.Rows.Count; j++)
                    {
                        dataAdapter = new SqlDataAdapter($"SELECT dbo.[Users].FirstName, dbo.[Users].LastName, dbo.[Users].Email FROM  dbo.Runner INNER JOIN dbo.[Users] ON dbo.Runner.Email = dbo.[Users].Email AND dbo.Runner.Email = dbo.[Users].Email INNER JOIN dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN dbo.RegistrationStatus ON dbo.RegistrationStatus.RegistrationStatusId = dbo.Registration.RegistrationStatusId where FirstName = '{runnersDataGrid.Rows[j].Cells[0].Value}' and LastName = '{runnersDataGrid.Rows[j].Cells[1].Value}' and [Runner].Email = '{runnersDataGrid.Rows[j].Cells[2].Value}' and RegistrationStatus = '{runnersDataGrid.Rows[j].Cells[3].Value}'", connection);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            string Name = dataSet.Tables[0].Rows[i][0].ToString();
                            string LastName = dataSet.Tables[0].Rows[i][1].ToString();
                            string Email = dataSet.Tables[0].Rows[i][2].ToString();
                            string All = '"' + LastName + " " + Name + '"' + "<" + Email + ">" + ";" + "\n";
                            byte[] array = Encoding.Default.GetBytes(All);
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                    MessageBox.Show("Текст записан в файл");
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

        private void csvButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = null;

                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.SelectedPath + @"\runner.csv";
                }

                connectionSql.Open();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {

                    string columns = "FirstName,LastName,Email,Gender,CountryName,DateOfBirth,RegistrationStatus,RaceKitOption,EventTypeName";
                    byte[] arrayCollums = Encoding.Default.GetBytes(columns + "\n");
                    fileStream.Write(arrayCollums, 0, arrayCollums.Length);
                    for (int j = 0; j < runnersDataGrid.Rows.Count; j++)
                    {
                        dataAdapter = new SqlDataAdapter($"SELECT * FROM View_1 where FirstName = '{runnersDataGrid.Rows[j].Cells[0].Value}' and LastName = '{runnersDataGrid.Rows[j].Cells[1].Value}' and Email = '{runnersDataGrid.Rows[j].Cells[2].Value}' and RegistrationStatus = '{runnersDataGrid.Rows[j].Cells[3].Value}'", connection);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            string Name = dataSet.Tables[0].Rows[i][0].ToString();
                            string LastName = dataSet.Tables[0].Rows[i][1].ToString();
                            string Email = dataSet.Tables[0].Rows[i][2].ToString();
                            string Gender = dataSet.Tables[0].Rows[i][3].ToString();
                            string CountryName = dataSet.Tables[0].Rows[i][4].ToString();
                            DateTime DateOfBirth = DateTime.Parse(dataSet.Tables[0].Rows[i][5].ToString());
                            TimeSpan span = DateTime.Now - DateOfBirth;
                            string Birth = DateOfBirth.ToString();
                            string Age = (span.Days / 365).ToString();
                            string RegistrationStatus = dataSet.Tables[0].Rows[i][6].ToString();
                            string Option = dataSet.Tables[0].Rows[i][7].ToString();
                            string Event = dataSet.Tables[0].Rows[i][8].ToString();
                            string All = Name + "," + LastName + "," + Email + "," + Gender + "," + CountryName + "," + Birth + "," + Age + "," + RegistrationStatus + "," + Option + "," + Event + "\n";
                            byte[] array = Encoding.Default.GetBytes(All);
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                    MessageBox.Show("Текст записан в файл");
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCoordinator coordinator = new FormCoordinator(email);
            coordinator.Show();
            this.Hide();
        }

        private void FormCoordinatorRunner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (email != "")
            {
                FormCoordinatorRunnerEdit form = new FormCoordinatorRunnerEdit();
                form.emailUserLabel.Text = email;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного бегуна");
            }
        }

        private void runnersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (runnersDataGrid.SelectedRows[0].Index != -1)
            {
                email = runnersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
