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
    public partial class FormAdminCharityList : Form
    {
        public string email;
        public FormAdminCharityList()
        {
            InitializeComponent();
        }

        private void timerMarathon_Tick(object sender, EventArgs e)
        {
            DateTime marathonTime = new DateTime(2021, 11, 24, 6, 0, 0);
            TimeSpan totalTime = marathonTime - DateTime.Now;
            labelTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormAdminCharityList_Load(object sender, EventArgs e)
        {
            timerMarathon.Start();
            SqlConnection conn = new SqlConnection(Connection.GetString());
            conn.Open();


            SqlCommand command = new SqlCommand("SELECT * FROM Charity ORDER BY CharityId DESC", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                int z = 0;
                while (reader.Read())
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = pictureBoxCharity.Size;
                    pb.Location = new Point(pictureBoxCharity.Location.X, pictureBoxCharity.Location.Y + z);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BorderStyle = BorderStyle.Fixed3D;
                    if (reader["CharityLogo"].ToString() != "")
                    {
                        pb.Image = Image.FromFile("logo/" + reader["CharityLogo"].ToString());
                    }
                    RichTextBox rch1 = new RichTextBox();
                    rch1.Text = reader["CharityName"].ToString();
                    rch1.Size = richTextBoxName.Size;
                    rch1.Location = new Point(richTextBoxName.Location.X, richTextBoxName.Location.Y + z);
                    rch1.Font = richTextBoxName.Font;
                    rch1.ReadOnly = true;
                    RichTextBox rch2 = new RichTextBox();
                    rch2.Text = reader["CharityDescription"].ToString();
                    rch2.Size = richTextBoxOpis.Size;
                    rch2.Location = new Point(richTextBoxOpis.Location.X, richTextBoxOpis.Location.Y + z);
                    rch2.Font = richTextBoxOpis.Font;
                    rch2.ReadOnly = true;
                    Panel pn = new Panel();
                    pn.Size = panelEd.Size;
                    pn.Location = new Point(panelEd.Location.X, panelEd.Location.Y + z);
                    pn.BorderStyle = BorderStyle.Fixed3D;
                    Button bn = new Button();
                    bn.Size = buttonEdit.Size;
                    bn.Location = buttonEdit.Location;
                    bn.Text = "Edit";
                    bn.Font = buttonEdit.Font;
                    bn.Tag = reader["CharityId"].ToString();
                    bn.Click += (ee, aa) => {
                        //MessageBox.Show(bn.Tag.ToString());
                        FormAddEditCharity fm = new FormAddEditCharity(email, bn.Tag.ToString());
                        fm.Show();
                        this.Hide();
                    };
                    pn.Controls.Add(bn);
                    panel1.Controls.Add(pn);
                    panel1.Controls.Add(pb);
                    panel1.Controls.Add(rch1);
                    panel1.Controls.Add(rch2);
                    z += 122;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin(email);
            menuAdmin.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditCharity charity = new FormAddEditCharity(email);
            charity.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditCharity charity = new FormAddEditCharity(email);
            charity.Show();
            this.Hide();
        }

        private void FormAdminCharityList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
