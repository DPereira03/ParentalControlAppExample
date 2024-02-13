using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

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


        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {

                RSA.ImportParameters(RSAKeyInfo);

                encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return encryptedData;

        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {

            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {

                RSA.ImportParameters(RSAKeyInfo);

                decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
            return decryptedData;
        }


        private void SearchBut_Click(object sender, EventArgs e)
        {
            string UserSearch = SearchBar.Text;
            string text;
            string OUTDEC;

            if (label1.Text.Contains("VPN"))
            {

                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(UserSearch);
                byte[] encryptedData;
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);

                    string folder = @"C:\Users\djper\OneDrive\Documents\Year 3\.Final Study\.Main work\Program\ParentalControlAppExample\ParentalControlAppExample\EncText.txt";
                    File.WriteAllText(folder, Encoding.UTF8.GetString(encryptedData));


                    decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                    OUTDEC = Encoding.UTF8.GetString(decryptedData);

                }

                text = "Showing results for " + OUTDEC;
                MessageBox.Show(text);

            }
            else
            {
                text = "Showing results for " + UserSearch;
                MessageBox.Show(text);
            }

        }

        public void BetApp_Click(object sender, EventArgs e)
        {
            string check = Form1.option;


            if (check == "STOP")
            {
                MessageBox.Show("Game Blocked");
            }
            else 
            { 
                MessageBox.Show("Game Loaded");
            }
        }
    }
}
