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
    /// Interaction logic for Enigma_Do.xaml
    /// </summary>
    public partial class Enigma_Do : UserControl
    {
        string bufor;
        public Enigma_Do()
        {
            InitializeComponent();
            rtrRevers.SelectedIndex = 0;
            rtrLeft.SelectedIndex = 0;
            rtrMiddle.SelectedIndex = 1;
            rtrRight.SelectedIndex = 2;

        }

        private void sldKey3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string sldtableKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            lblKey3.Content = sldtableKey[Convert.ToInt32(sldKey3.Value)];
        }

        private void sldKey2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string sldtableKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            lblKey2.Content = sldtableKey[Convert.ToInt32(sldKey2.Value)];
        }

        private void sldKey1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string sldtableKey = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            lblKey1.Content = sldtableKey[Convert.ToInt32(sldKey1.Value)];
        }

        private void bt_ed_enigma(object sender, RoutedEventArgs e)
        {
            txtEnigma.Text = new Class.Enigma().Enigma_ED(Convert.ToString(txtEnigma.Text), rtrRight.SelectedIndex + 1, rtrMiddle.SelectedIndex + 1, rtrLeft.SelectedIndex + 1, rtrRevers.SelectedIndex + 1, Convert.ToInt32(sldKey1.Value), Convert.ToInt32(sldKey2.Value), Convert.ToInt32(sldKey3.Value));
        }

        private void bt_delx_enigma(object sender, RoutedEventArgs e)
        {
            txtEnigma.Text = new Class.Enigma().delX(txtEnigma.Text);
        }

        private void genKey_enigma(object sender, RoutedEventArgs e)
        {
            Random R = new Random();
            int m = Convert.ToInt32(Math.Round(100*R.NextDouble()));
            rtrRevers.SelectedIndex = m%4;
            do
            {
                m = Convert.ToInt32(Math.Round(100 * R.NextDouble()));
                rtrLeft.SelectedIndex = m % 5;
                m = Convert.ToInt32(Math.Round(100 * R.NextDouble()));
                rtrMiddle.SelectedIndex = m % 5;
                m = Convert.ToInt32(Math.Round(100 * R.NextDouble()));
                rtrRight.SelectedIndex = m % 5;
            } while (rtrLeft.SelectedIndex == rtrMiddle.SelectedIndex || rtrLeft.SelectedIndex == rtrRight.SelectedIndex || rtrMiddle.SelectedIndex == rtrRight.SelectedIndex);
            m = Convert.ToInt32(Math.Round(100*R.NextDouble()));
            sldKey3.Value = m%26;
            m = Convert.ToInt32(Math.Round(100*R.NextDouble()));
            sldKey2.Value = m%26;
            m = Convert.ToInt32(Math.Round(100*R.NextDouble()));
            sldKey1.Value = m%26;

        }

        private void Label_MouseEnter_1(object sender, MouseEventArgs e)
        {
            bufor = txtEnigma.Text;
            txtEnigma.Text = "Wirnika należy ustawić tak aby się niepowtarzały. Niedozwolone jest ustawienie np. 1-2-1.\nEnigma szyfruje tylko standardowe znaki.  Znaki spacji zamienia na 'X', znaki diakrytyczne na ich zwykłe odpowiedniki, a inne znaki których nie ma w tablicy są pomijane.";
        }

        private void Label_MouseLeave_1(object sender, MouseEventArgs e)
        {
            txtEnigma.Text = bufor;
        }

        private void Label_MouseEnter_2(object sender, MouseEventArgs e)
        {
            bufor = txtEnigma.Text;
            txtEnigma.Text = "Po odszyfrowaniu aby tekst był czytelniejszy naciśnij 'Usuń X', wtedy program zastąpi znaki 'X' spacjami. Np: \nALAXMAXKOTA\nALA MA KOTA";
        }

        private void Label_MouseLeave_2(object sender, MouseEventArgs e)
        {
            txtEnigma.Text = bufor;
        }

        private void txtEnigma_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtEnigma.Text == "Tu wpisz wiadomośc do zaszyfrowania lub odszyfrowania") txtEnigma.Text = "";
        }


    }
}
