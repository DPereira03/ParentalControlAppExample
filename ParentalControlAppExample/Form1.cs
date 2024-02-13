using System.Drawing.Imaging;

namespace ParentalControlAppExample
{
    public partial class Form1 : Form
    {
        Form2 secondForm;
        int count = 0;
        bool Checker = false;
        public static string option = "PLAY";
        public static string WebOption = "OPEN";

        public Form1()
        {
            InitializeComponent();
            secondForm = new Form2(this);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            secondForm.Show();
        }

        public void VPNButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                secondForm.label1.Text = "Internet Search: Wi-Fi (VPN)";
                DisplayBox.Text = "VPN Activated";
                count++;
            }
            else
            {
                secondForm.label1.Text = "Internet Search: Wi-Fi ";
                DisplayBox.Text = "VPN Deactivated";
                count = 0;
            }


        }

        private void LckButton_Click(object sender, EventArgs e)
        {

            if (secondForm.Visible == true)
            {
                secondForm.Visible = false;
                DisplayBox.Text = "Screen Lock Activated";
            }
            else
            {
                secondForm.Visible = true;
                DisplayBox.Text = "Screen Lock Deactivated";
            }
        }

        private void SOSButton_Click(object sender, EventArgs e)
        {

            if (secondForm.SOSHelp.Visible == true)
            {
                secondForm.SOSHelp.Visible = false;
                DisplayBox.Text = "SOS Button Deactivated";
            }
            else
            {
                secondForm.SOSHelp.Visible = true;
                DisplayBox.Text = "SOS Button Activated";
            }
        }

        private void ScrButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            if (option == "PLAY")
            {
                option = "STOP";
                DisplayBox.Text = "Game Filter Activated";
            }
            else
            {
                option = "PLAY";
                DisplayBox.Text = "Game Filter Deactivated";
            }
        }

        private void WebButton_Click(object sender, EventArgs e)
        {

            if (WebOption == "OPEN")
            {
                WebOption = "CLOSE";
                DisplayBox.Text = "Website Filter Activated";
            }
            else
            {
                WebOption = "OPEN";
                DisplayBox.Text = "Website Filter Deactivated";
            }

        }
    }
}