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
    public partial class FormRunnerMenu : Form
    {
        public FormRunnerMenu()
        {
            InitializeComponent();
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            FormContacts formContacts = new FormContacts();
            formContacts.Show();
            this.Hide();
        }
    }
}
