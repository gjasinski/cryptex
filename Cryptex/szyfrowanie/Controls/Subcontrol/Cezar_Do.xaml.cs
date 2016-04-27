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
    /// Interaction logic for Cezar_Do.xaml
    /// </summary>
    public partial class Cezar_Do : UserControl
    {
        string bufor = "";
        public Cezar_Do()
        {
            InitializeComponent();
        }

        private void sldKey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblKey.Content = Convert.ToString(sldKey.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtCiphered.Text = Convert.ToString(new Class.Szyfr().cezar_e(txtPlain.Text, Convert.ToInt32(sldKey.Value)));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            txtDeciphered.Text = Convert.ToString(new Class.Szyfr().cezar_d(txtCryptex.Text, Convert.ToInt32(sldKey2.Value)));
        }

        private void sldKey2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblKey2.Content = Convert.ToString(sldKey2.Value);
        }

        private void txtPlain_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPlain.Text == "Tutaj wpisz tekst do zaszyfrowania. Następnie ustaw klucz za pomocą suwaka.") txtPlain.Text = "";
        }

        private void txtCryptex_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtCryptex.Text == "Tutaj wpisz tekst do odszyfrowania. Następnie ustaw klucz za pomocą suwaka. Pamiętaj klicz musi być taki sam jakim zaszyfrowano wiadomość.") txtCryptex.Text = "";
        }

        private void Label_MouseEnter_1(object sender, MouseEventArgs e)
        {
            bufor = txtPlain.Text;
            txtPlain.Text = "Szyfr Cezara szyfruje i odszyfrowywuje tylko wielkie i małe litery oraz liczby. Inne litery są wycinane. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";
        }

        private void Label_MouseLeave_1(object sender, MouseEventArgs e)
        {
            txtPlain.Text = bufor;
        }

        private void Label_MouseEnter_2(object sender, MouseEventArgs e)
        {
            bufor = txtCryptex.Text;
            txtCryptex.Text = "Szyfr Cezara szyfruje i odszyfrowywuje tylko wielkie i małe litery oraz liczby. Inne litery są wycinane. Dostępna tablica znaków: 'ABCDEFGHIJKLMNOPQRSTUWXYZ abcdefghijklmnopqrstuwxyz1234567890 '";
        }

        private void Label_MouseLeave_2(object sender, MouseEventArgs e)
        {
            txtCryptex.Text = bufor;
        }


    }
}
