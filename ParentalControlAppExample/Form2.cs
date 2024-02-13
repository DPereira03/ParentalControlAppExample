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

            if (label1.Text.Contains("VPN"))
            {

                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(UserSearch);
                byte[] encryptedData;
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);

                    decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                    string OUTDEC = Encoding.UTF8.GetString(decryptedData);


                    MessageBox.Show("Decrypted: "+ OUTDEC);
                }

            }

            string text = "Showing results for " + UserSearch;
            MessageBox.Show(text);

        }
    }
}
