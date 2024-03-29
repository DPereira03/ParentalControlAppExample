﻿using System;
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
        public string WhereAmI = "I am in ThisShop in ThisPlace";
        public string Detection = "Nothing";
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


        public string WebCheck = "ACCESS";
        public string checkText = "";
        public string related = "nothing";
        public int wordFound = 0;
        public string WEBCHECK(string checkText)
        {

            string filepath = "C:\\Users\\djper\\OneDrive\\Documents\\Year 3\\.Final Study\\.Main work\\Program\\ParentalControlAppExample\\ParentalControlAppExample\\Websites.txt";


            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                if (line.Contains(checkText))
                {
                    WebCheck = "DENIED";
                    break;
                }
                else
                {
                    WebCheck = "ACCESS";
                }
            }

            return WebCheck;

        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string UserSearch = SearchBar.Text;
            checkText = UserSearch;
            string text;
            string OUTDEC;
            string Access = "ACCESS";

            if (Form1.WebOption == "CLOSE")
            {
                Access = WEBCHECK(checkText.ToLower());
            }

            if (Form1.AIOption == "ON")
            {
                firstForm.WordingCheck(checkText.ToLower());
            }


            if (Access != "DENIED")
            {
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

                    if (text.ToLower().Contains("devil"))
                    {
                        related = "hell";
                    }
                    else if (text.ToLower().Contains("hello"))
                    {
                        related = "smile";
                    }
                    else
                    {
                        related = "Nothing";
                    }


                }
                else
                {
                    text = "Showing results for " + UserSearch;
                    MessageBox.Show(text);

                    if (text.ToLower().Contains("devil") && firstForm.Found == 0)
                    {
                        related = "hell";
                    }
                    else if (text.ToLower().Contains("hello"))
                    {
                        related = "smile";
                    }
                    else
                    {
                        related = "Nothing";
                    }
                }
            }
            else
            {
                MessageBox.Show("Access Denied");
            }

            if (Form1.AIOption == "ON" && firstForm.notified == 0)
            {
                firstForm.WordingCheck(checkText.ToLower());
            }

            firstForm.notified = 0;

        }

        public void BetApp_Click(object sender, EventArgs e)
        {
            string check = Form1.option;


            if (check == "STOP")
            {
                MessageBox.Show("Application Blocked");
            }
            else
            {
                MessageBox.Show("Application Loaded");
            }
        }

        private void GameApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Loaded");
        }
    }
}
