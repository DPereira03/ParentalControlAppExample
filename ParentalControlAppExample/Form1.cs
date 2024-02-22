using System.Drawing.Imaging;
using System.Security.Cryptography.Xml;
using System.Text;

namespace ParentalControlAppExample
{
    public partial class Form1 : Form
    {
        Form2 secondForm;
        int count = 0;
        int counter = 0;
        public int Found = 0;
        bool Checker = false;
        public static string option = "PLAY";
        public static string WebOption = "OPEN";
        public static string AIOption = "OFF";
        bool AI = false;

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
                VPNButton.BackColor = Color.Lime;
            }
            else
            {
                secondForm.label1.Text = "Internet Search: Wi-Fi ";
                DisplayBox.Text = "VPN Deactivated";
                count = 0;
                VPNButton.BackColor = Color.Crimson;
            }


        }

        private void LckButton_Click(object sender, EventArgs e)
        {

            if (secondForm.Visible == true)
            {
                secondForm.Visible = false;
                DisplayBox.Text = "Screen Lock Activated";
                LckButton.BackColor = Color.Lime;
            }
            else
            {
                secondForm.Visible = true;
                DisplayBox.Text = "Screen Lock Deactivated";
                LckButton.BackColor = Color.Crimson;
            }
        }

        private void SOSButton_Click(object sender, EventArgs e)
        {

            if (secondForm.SOSHelp.Visible == true)
            {
                secondForm.SOSHelp.Visible = false;
                DisplayBox.Text = "SOS Button Deactivated";
                SOSButton.BackColor = Color.Crimson;
            }
            else
            {
                secondForm.SOSHelp.Visible = true;
                DisplayBox.Text = "SOS Button Activated";
                SOSButton.BackColor = Color.Lime;
            }
        }

        private void ScrButton_Click(object sender, EventArgs e)
        {
            secondForm.label2.Visible = true;
            if (timeleft == 20)
            {
                timer1.Start();
                DisplayBox.Text = "Time out activated";
                ScrButton.BackColor = Color.Lime;
            }
            else
            {
                timer1.Stop();
                timeleft = 20;
                DisplayBox.Text = "Time out deactivated";
                secondForm.Visible = true;
                secondForm.label2.Visible = false;
                secondForm.label2.Text = "Time left 20 seconds";
                ScrButton.BackColor = Color.Crimson;
            }
        }

        int timeleft = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                secondForm.label2.Text = "Time left " + timeleft + " seconds";
            }
            else
            {
                timer1.Stop();
                if (secondForm.Visible == true)
                {
                    secondForm.Visible = false;
                    DisplayBox.Text = "Timed out";
                }

            }
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            if (option == "PLAY")
            {
                option = "STOP";
                DisplayBox.Text = "Game Filter Activated";
                AppButton.BackColor = Color.Lime;
            }
            else
            {
                option = "PLAY";
                DisplayBox.Text = "Game Filter Deactivated";
                AppButton.BackColor = Color.Crimson;
            }
        }

        private void WebButton_Click(object sender, EventArgs e)
        {

            if (WebOption == "OPEN")
            {
                WebOption = "CLOSE";
                DisplayBox.Text = "Website Filter Activated";
                WebButton.BackColor = Color.Lime;
            }
            else
            {
                WebOption = "OPEN";
                DisplayBox.Text = "Website Filter Deactivated";
                WebButton.BackColor = Color.Crimson;
            }

        }

        private void LocButton_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                DisplayBox.Text = secondForm.WhereAmI;
                counter = 1;
                LocButton.BackColor = Color.Lime;
            }
            else
            {
                DisplayBox.Text = "Location tracker disabled";
                counter = 0;
                LocButton.BackColor = Color.Crimson;
            }
        }

        private void AIbutton_Click(object sender, EventArgs e)
        {
            if (AIOption == "OFF")
            {
                AIOption = "ON";
                DisplayBox.Text = "AI monitoring Activated";
                AIbutton.BackColor = Color.Lime;
            }
            else
            {
                AIOption = "OFF";
                DisplayBox.Text = "AI monitoring Deactivated";
                AIbutton.BackColor = Color.Crimson;
            }

        }

        public string harm;
        public int notified = 0;
        public string WordingCheck(string checkText)
        {

            string filepath = "C:\\Users\\djper\\OneDrive\\Documents\\Year 3\\.Final Study\\.Main work\\Program\\ParentalControlAppExample\\ParentalControlAppExample\\AIWords.txt";


            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                if (line.Contains(checkText))
                {
                    harm = "yes";
                    notified = 1;
                    break;
                }
                else
                {
                    harm = "no";
                }
            }


            if (harm == "yes")
            {
                MessageBox.Show("Potenital harm detected, search term: " + checkText);
            }
            else if (secondForm.related == "hell")
            {
                MessageBox.Show("Potenital harm detected, search term: " + checkText +
                    ", results show: " + secondForm.related);
                string folder = @"C:\Users\djper\OneDrive\Documents\Year 3\.Final Study\.Main work\Program\ParentalControlAppExample\ParentalControlAppExample\AIWords.txt";
                string newText = Environment.NewLine + secondForm.checkText;
                File.AppendAllText(folder, newText.ToLower());
                Found = 1;
            }

            
            return harm;

        }


    }
}