using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Kencrypt;

namespace KEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] allFilePaths;
        private string[] allFileNames;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Text|*.txt";
            fdlg.Title = "Select Files";
            fdlg.Multiselect = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                allFileNames = fdlg.SafeFileNames;
                allFilePaths = fdlg.FileNames;

                foreach (string i in allFileNames)
                {
                    if (decryptListBox.Items.ToString().Contains(i))
                    {
                        continue;
                    }
                    else
                    {
                        decryptListBox.Items.Add(i.ToString());
                        label2.Text = "Files Chosen: ";
                    }
                }
            }
        }


        private void btnClearList_Click(object sender, EventArgs e)
        {
            decryptListBox.Items.Clear();
            allFilePaths = null;
            allFileNames = null;

        }

        public void encryptBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select Files";
            fdlg.Filter = "Text|*.txt";
            fdlg.Multiselect = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                allFileNames = fdlg.SafeFileNames;
                allFilePaths = fdlg.FileNames;

                foreach (string i in allFileNames)
                {
                    if (encryptListBox.Items.ToString().Contains(i))
                    {
                        continue;
                    }
                    else
                    {
                        encryptListBox.Items.Add(i.ToString());
                        label3.Text = "Files Chosen: ";
                    }
                }
            }
        }

        private void EncryptClearList_Click(object sender, EventArgs e)
        {
            encryptListBox.Items.Clear();
            allFilePaths = null;
            allFileNames = null;
        }

        public void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (encryptKey.TextLength < 32)
            {
                MessageBox.Show("Please enter at least 32 digit key");
            }

            else if (allFilePaths == null || allFileNames == null)
            {
                MessageBox.Show("List is empty");
            }


            else
            {
                foreach (string i in allFilePaths)
                {
                    string content = File.ReadAllText(i, Encoding.UTF8);
                    var encryptedString = AesOperation.EncryptString(encryptKey.Text, content);
                    File.WriteAllText(i, encryptedString);
                }

                MessageBox.Show($"Encrypted {allFileNames.Length} files.");
                allFilePaths = null;
                allFileNames = null;
                encryptListBox.Items.Clear();

            }    
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            int passwordLength = 32;

            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string AllChar = CapitalLetters + SmallLetters + Digits;

            StringBuilder pw = new StringBuilder();
            for (int n = 0; n < passwordLength; n++)
            {
                pw = pw.Append(Crypter.GenerateChar(AllChar));

            }
            var key = pw.ToString();
            encryptKey.Text = key;

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (decryptKey.TextLength < 32)
            {
                MessageBox.Show("Please enter at least 32 digit key");
            }

            else if (allFileNames == null | allFilePaths == null)
            {
                MessageBox.Show("List is empty");
            }

            else
            {
                
                foreach (string i in allFilePaths)
                {
                    string content = File.ReadAllText(i, Encoding.UTF8);
                    var decryptedString = AesOperation.DecryptString(decryptKey.Text, content);
                    File.WriteAllText(i, decryptedString);
                }

                MessageBox.Show($"Decrypted {allFileNames.Length} files.");
                allFilePaths = null;
                allFileNames = null;
                encryptListBox.Items.Clear();
            }
        }

        private void encryptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
