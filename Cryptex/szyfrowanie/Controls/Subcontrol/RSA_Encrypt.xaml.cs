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
    /// Interaction logic for RSA_Encrypt.xaml
    /// </summary>
    public partial class RSA_Encrypt : UserControl
    {
        private string ciphered;
        public RSA_Encrypt()
        {
            InitializeComponent();
           // string z = Char.ConvertFromUtf32(01012);
            //txt_Ciphered.Text = z;
        }

        private void bt_encrypt_Click(object sender, RoutedEventArgs e)
        {
            string plaintext = txt_Plain.Text;
            string cipheredtext = "";
            long n = Convert.ToInt64(txt_Keyn.Text);
            long en = Convert.ToInt64(txt_Keye.Text);
            int buf;
            int error = 0;
            Class.RSA rsa = new Class.RSA();
            //string hexValue = 
            for (int i = 0; i < plaintext.Length; i++)
            {
                try
                {
                    buf = rsa.encode(Char.ConvertToUtf32(plaintext[i].ToString(), 0), n, en);
                    if (buf > 55295 && buf < 57343)
                    {
                        cipheredtext += plaintext[i];
                        error++;
                }
                    else cipheredtext += Char.ConvertFromUtf32(buf);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    buf = rsa.encode(Char.ConvertToUtf32(plaintext[i], plaintext[i+1]), n, en);
                    if (buf > 55295 && buf < 57343)
                {
                        cipheredtext += plaintext[i] + plaintext[i + 1] ;
                        error++;
                        error++;
                    }
                    else cipheredtext += Char.ConvertFromUtf32(buf);
                }

            }
            if (error > plaintext.Length * 0.1) MessageBox.Show("E:"+error.ToString()+"Proszę zmienić klucz");
            txt_Ciphered.Text = cipheredtext;
            this.ciphered = cipheredtext;
        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sd = new System.Windows.Forms.SaveFileDialog();
            sd.DefaultExt = ".txt";
            sd.FileName = "rsa_encode_output.txt";
            sd.Filter = "Pliki tekstowe RSA (*.txt)|";
            sd.ShowDialog();
            string filename = sd.FileName;
            string[] tab = new string[1];
            tab[0] = this.ciphered;
            File.WriteAllLines(filename, tab);
        }       
    }
}
