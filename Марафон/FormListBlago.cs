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
    public partial class FormListBlago : Form
    {
        public FormListBlago()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormListBlago_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Charity", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                int z = 0;
                while (reader.Read())
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = pictureBoxLogoBlago.Size;
                    pb.Location = new Point(pictureBoxLogoBlago.Location.X, pictureBoxLogoBlago.Location.Y + z);
                    pb.BorderStyle = BorderStyle.Fixed3D;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (reader["CharityLogo"].ToString() != "")
                        pb.Image = Image.FromFile("logo/" + reader["CharityLogo"].ToString());
                    Label lb = new Label();
                    lb.Size = label2.Size;
                    lb.Location = new Point(label2.Location.X, label2.Location.Y + z);
                    lb.Font = label2.Font;
                    lb.ForeColor = label2.ForeColor;
                    lb.Text = reader["CharityName"].ToString();
                    RichTextBox rb = new RichTextBox();
                    rb.Size = richTextBoxInfoBlago.Size;
                    rb.Location = new Point(richTextBoxInfoBlago.Location.X, richTextBoxInfoBlago.Location.Y + z);
                    rb.Font = richTextBoxInfoBlago.Font;
                    rb.ForeColor = richTextBoxInfoBlago.ForeColor;
                    rb.Text = reader["CharityDescription"].ToString();
                    rb.ReadOnly = true;
                    panel1.Controls.Add(pb);
                    panel1.Controls.Add(lb);
                    panel1.Controls.Add(rb);
                    z += 156;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMoreInfo formMI = new FormMoreInfo();
            formMI.Show();
            this.Hide();
        }
    }
}
