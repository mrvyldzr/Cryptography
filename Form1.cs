using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;



namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        public static byte[] StringToByteArray(String hexadecimal)
        {
            int NumberChars = hexadecimal.Length;
            byte[] bytes = new byte[NumberChars / 2];


            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexadecimal.Substring(i, 2), 16);
            }
            return bytes;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(plaintext.Text);
                
                //SHA256 hash değerini hesaplar
                System.Security.Cryptography.SHA256Managed sha256hash = new System.Security.Cryptography.SHA256Managed();

                byte[] hash = sha256hash.ComputeHash(bytes);

                string hashstring = string.Empty;

                foreach (byte x in hash)
                {   
                    
                    hashstring += String.Format("{0:x2}", x);
                }
                 ciphertext.Text = hashstring;
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}


