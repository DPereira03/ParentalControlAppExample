using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlAppExample
{
    public partial class Form2 : Form
    {
        Form1 firstForm;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            firstForm = parent;
        }

        public void SOSHelp_Click(object sender, EventArgs e)
        {
            firstForm.DisplayBox.Text = "HELP NEEDED";
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string UserSearch = SearchBar.Text;

            if (label1.Text.Contains("VPN"))
            {
                MessageBox.Show("Yes");
            }

            string text = "Showing results for " + UserSearch;
            MessageBox.Show(text);

        }
    }
}
