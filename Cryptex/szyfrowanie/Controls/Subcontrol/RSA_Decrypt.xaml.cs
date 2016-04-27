using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace Szyfrowanie.Controls.Subcontrol
{
    /// <summary>
    /// Interaction logic for RSA_Decrypt.xaml
    /// </summary>
    public partial class RSA_Decrypt : UserControl
    {
        public RSA_Decrypt()
        {
            InitializeComponent();
        }

        private void bt_Decrypt_Click(object sender, RoutedEventArgs e)
        {
            string plaintext = "";
            string cipheredtext = txt_Ciphered.Text;
            cipheredtext = File.ReadAllText("info.txt");
            long n = Convert.ToInt64(txt_Keyn.Text);
            long de = Convert.ToInt64(txt_Keyd.Text);
            int buf;
            int error = 0;
            Class.RSA rsa = new Class.RSA();
            for (int i = 0; i < cipheredtext.Length; i++)
            {
                try
                {
                    buf = rsa.encode(Char.ConvertToUtf32(cipheredtext[i].ToString(), 0), n, de);
                    if (buf > 55295 && buf < 57343)
                    {
                        plaintext += cipheredtext[i];
                        error++;
                    }
                    else plaintext += Char.ConvertFromUtf32(buf);
                }
                catch
                {
                    buf = rsa.encode(Char.ConvertToUtf32(cipheredtext[i], cipheredtext[i + 1]), n, de);
                    if (buf > 55295 && buf < 57343)
                    {
                        plaintext += cipheredtext[i] + cipheredtext[i + 1];
                        error++;
                        error++;
                    }
                    else plaintext += Char.ConvertFromUtf32(buf);
                    i++;
                }
            }
            if (error > cipheredtext.Length * 0.1) MessageBox.Show("E:" + error.ToString() + "Proszę zmienić klucz");
            txt_Plain.Text = plaintext;
            File.WriteAllText("info.txt", cipheredtext);
        }

        private void bt_Open_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog of = new System.Windows.Forms.OpenFileDialog();
            of.Filter = "Pliki tekstowe RSA (*.txt)|";
            of.FileName = "rsa_encode_output.txt";
            of.ShowDialog();
            txt_Ciphered.Text = string.Empty;
            var lines = File.ReadAllLines(of.FileName);
            foreach (string linia in lines)
            {
                txt_Ciphered.Text += linia;
            }
        }       
    }
}
