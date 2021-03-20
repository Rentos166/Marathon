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
    public partial class FormSponsorMoreInfoFond : Form
    {
        public string charityName;
        public FormSponsorMoreInfoFond(string charityName)
        {
            this.charityName = charityName;
            InitializeComponent();
        }

        private void labelFondName_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSponsorMoreInfoFond_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connection.GetString()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Charity WHERE CharityName = '" + charityName + "'", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            pictureBoxLogoFond.Image = Image.FromFile("logo/" + reader["CharityLogo"].ToString());
                        }
                        catch (Exception ex) { }

                        richTextBoxInfo.Text = reader["CharityDescription"].ToString();
                        textBoxFond.Text = reader["CharityName"].ToString();

                    }

                }
            }
        }
    }
}
