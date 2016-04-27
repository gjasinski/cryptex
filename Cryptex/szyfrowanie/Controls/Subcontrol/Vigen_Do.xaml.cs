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

namespace Szyfrowanie.Controls.Subcontrol
{
    /// <summary>
    /// Interaction logic for Vigen_Do.xaml
    /// </summary>
    public partial class Vigen_Do : UserControl
    {
        string bufor;
        public Vigen_Do()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtKey.Text == "") {
                txtCiphered.Text = "Podaj klucz.";
            }
            else
            {
                txtCiphered.Text = Convert.ToString(new Class.Szyfr().vigenere_e(txtPlain.Text, txtKey.Text));
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (txtKeyDC.Text == "")
            {
                txtDeciphered.Text = "Podaj klucz.";
            }
            else
            {
                txtDeciphered.Text = Convert.ToString(new Class.Szyfr().vigenere_d(txtCryptex.Text, txtKeyDC.Text));
            }
        }


        private void txtPlain_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPlain.Text == "Tutaj wpisz tekst do zaszyfrowania.") txtPlain.Text = "";
        }

        private void txtKey_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtKey.Text == "Tutaj wpisz klucz który może składać sie z wielkich i małych liter oraz cyfr.") txtKey.Text = "";
        }

        private void txtCryptex_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtCryptex.Text == "Aby odszfrować wklej tutaj zaszyfrowany tekst.") txtCryptex.Text = "";
        }

        private void txtKeyDC_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtKeyDC.Text == "Tutaj wpisz klucz który może składać sie z wielkich i małych liter oraz cyfr.") txtKeyDC.Text = "";
        }

        private void Label_MouseEnter_1(object sender, MouseEventArgs e)
        {
            bufor = txtPlain.Text;
            txtPlain.Text = "Szyfr Vigenère'a szyfruje i odszyfrowywuje tylko wielkie i małe litery oraz liczby. Inne litery są zamieniane na ich proste odpowiedniki. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";
        }

        private void Label_MouseLeave_1(object sender, MouseEventArgs e)
        {
            txtPlain.Text = bufor;
        }

        private void Label_MouseEnter_2(object sender, MouseEventArgs e)
        {
            bufor = txtKey.Text;
            txtKey.Text = "Klucz może składać się z wielkich i małych liter oraz liczb. Inne litery są zamieniane na ich proste odpowiedniki. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";
        }

        private void Label_MouseLeave_2(object sender, MouseEventArgs e)
        {
            txtKey.Text = bufor;
        }

        private void Label_MouseEnter_3(object sender, MouseEventArgs e)
        {
            bufor = txtCryptex.Text;
            txtCryptex.Text = "Szyfr Vigenère'a szyfruje i odszyfrowywuje tylko wielkie i małe litery oraz liczby. Inne litery są zamieniane na ich proste odpowiedniki. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";

        }

        private void Label_MouseLeave_3(object sender, MouseEventArgs e)
        {
            txtCryptex.Text = bufor;
        }

        private void Label_MouseEnter_4(object sender, MouseEventArgs e)
        {
            bufor = txtKeyDC.Text;
            txtKeyDC.Text = "Klucz może składać się z wielkich i małych liter oraz liczb. Inne litery są zamieniane na ich proste odpowiedniki. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";

        }

        private void Label_MouseLeave_4(object sender, MouseEventArgs e)
        {
            txtKeyDC.Text = bufor;
        }

    }
}
