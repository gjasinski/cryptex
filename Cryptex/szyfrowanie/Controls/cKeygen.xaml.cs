using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szyfrowanie.Controls
{
    /// <summary>
    /// Interaction logic for cKeygen.xaml
    /// </summary>
    public partial class cKeygen : UserControl
    {
        string bufor1;
        string bufor2;
        Keygen kg=new Keygen(0,0,0,0,0);
        public cKeygen()
        {
            InitializeComponent();
            bufor1 = txtRounds.Text;
            bufor2 = keyLength.Text;
        }

        private void rotorsCount_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblRCount.Content = rotorsCount.Value;
        }

        private void rotorSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblRSize.Content = rotorSize.Value;
        }

        private void complexity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblComplex.Content = complexity.Value;
        }

        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (complexity.Value == 0)
            {
                MessageBox.Show("Złożoność nie może być równa 0", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                kg.setComplexity(Convert.ToInt64(complexity.Value));
                kg.setKeyLength(Convert.ToInt64(keyLength.Text) * 2);
                kg.setRotorsCount(Convert.ToInt64(rotorsCount.Value));
                kg.setRotorSize(Convert.ToInt64(rotorSize.Value));
                kg.setRounds(Convert.ToInt64(txtRounds.Text));
                lblKey.Text = Convert.ToString(kg.generateKey());
            }
        }

        private void btCopyKey_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(lblKey.Text);
        }

        private void Label_MouseEnter_1(object sender, MouseEventArgs e)
        {
            label.Content = "Długość klucza musi być podzielna przez 8.";
        }

        private void Label_MouseLeave_1(object sender, MouseEventArgs e)
        {
            label.Content = "";
        }

        private void Label_MouseEnter_2(object sender, MouseEventArgs e)
        {
            label.Content = "Im więcej rund tym program dłużej generuje klucz, dlatego ilość rund została ograniczona do 100.";
        }

        private void Label_MouseLeave_2(object sender, MouseEventArgs e)
        {
            label.Content = "";
        }
        
        private void txtRounds_TextChanged(object sender, TextChangedEventArgs e)
        {           
            try
            {
                if (Convert.ToInt32(txtRounds.Text) > 100) txtRounds.Text = "100";
            }
            catch (FormatException)
            {
                MessageBox.Show("Zły format danych! Podawaj tylko liczby!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                txtRounds.Text = "1";
            }
            bufor1 = txtRounds.Text;
        }

        private void keyLength_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(keyLength.Text) > 16384) keyLength.Text = "16384";
            }
            catch (FormatException)
            {
                MessageBox.Show("Zły format danych! Podawaj tylko liczby!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                keyLength.Text = bufor2;
            }
            bufor2 = keyLength.Text;
        }
    }
}
