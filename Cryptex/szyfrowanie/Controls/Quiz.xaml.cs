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

namespace Szyfrowanie.Controls
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : UserControl
    {
        public byte selectedIndex = 90;
        public byte qNo = 0;
        public byte questionIndex;
        public Class.Quiz q = new Class.Quiz();
        public byte iloscPkt = 0;
        public Quiz()
        {
            try
            {
                if (System.IO.File.Exists("Data/Data.txt"))
                {
                    InitializeComponent();
                    q.generator();
                    lblPytanie.Content = q.pytania[q.index[0], 0];
                    odp1.Content = q.pytania[q.index[0], 1].Remove(q.pytania[q.index[0], 1].Length - 3);
                    odp2.Content = q.pytania[q.index[0], 2].Remove(q.pytania[q.index[0], 2].Length - 3);
                    odp3.Content = q.pytania[q.index[0], 3].Remove(q.pytania[q.index[0], 3].Length - 3);
                    odp4.Content = q.pytania[q.index[0], 4].Remove(q.pytania[q.index[0], 4].Length - 3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Spróbuj jeszcze raz");
            }

        }

        private void odp1_Checked(object sender, RoutedEventArgs e)
        {
            selectedIndex = 1;
        }

        private void odp2_Checked(object sender, RoutedEventArgs e)
        {
            selectedIndex = 2;
        }

        private void odp3_Checked(object sender, RoutedEventArgs e)
        {
            selectedIndex = 3;
        }

        private void odp4_Checked(object sender, RoutedEventArgs e)
        {
            selectedIndex = 4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedIndex == 90)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej odpowiedzi!", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (q.checkAnswer(q.index[qNo], selectedIndex) == true)
                {
                    MessageBox.Show("Poprawna odpowiedź!", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);
                    iloscPkt++;
                    qNo++;
                    lblPytanie.Content = q.pytania[q.index[qNo], 0];
                    odp1.Content = q.pytania[q.index[qNo], 1].Remove(q.pytania[q.index[qNo], 1].Length - 3);
                    odp2.Content = q.pytania[q.index[qNo], 2].Remove(q.pytania[q.index[qNo], 2].Length - 3);
                    odp3.Content = q.pytania[q.index[qNo], 3].Remove(q.pytania[q.index[qNo], 3].Length - 3);
                    odp4.Content = q.pytania[q.index[qNo], 4].Remove(q.pytania[q.index[qNo], 4].Length - 3);
                }
                else
                {
                    string tekst = "";
                    for (byte i = 0; i <= 5; i++)
                    {
                        if (q.checkAnswer(q.index[qNo], i)) { tekst = q.pytania[q.index[qNo], i].Remove(q.pytania[q.index[qNo], i].Length - 3); break; }
                        else continue;
                    }
                    MessageBox.Show("Zła odpowiedź!\n Poprawna odpowiedź to : \n " + tekst, "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);
                    qNo++;
                    lblPytanie.Content = q.pytania[q.index[qNo], 0];
                    odp1.Content = q.pytania[q.index[qNo], 1].Remove(q.pytania[q.index[qNo], 1].Length - 3);
                    odp2.Content = q.pytania[q.index[qNo], 2].Remove(q.pytania[q.index[qNo], 2].Length - 3);
                    odp3.Content = q.pytania[q.index[qNo], 3].Remove(q.pytania[q.index[qNo], 3].Length - 3);
                    odp4.Content = q.pytania[q.index[qNo], 4].Remove(q.pytania[q.index[qNo], 4].Length - 3);
                }
                if (qNo == 5)
                {
                    MessageBox.Show("Koniec Quizu! Zdobyto " + (iloscPkt) + " punktów na 5", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);
                    qNo = 0;
                    iloscPkt = 0;
                    this.q = new Class.Quiz();
                    q.generator();
                    lblPytanie.Content = q.pytania[q.index[qNo], 0];
                    odp1.Content = q.pytania[q.index[qNo], 1].Remove(q.pytania[q.index[qNo], 1].Length - 3);
                    odp2.Content = q.pytania[q.index[qNo], 2].Remove(q.pytania[q.index[qNo], 2].Length - 3);
                    odp3.Content = q.pytania[q.index[qNo], 3].Remove(q.pytania[q.index[qNo], 3].Length - 3);
                    odp4.Content = q.pytania[q.index[qNo], 4].Remove(q.pytania[q.index[qNo], 4].Length - 3);
                }
            }
        }

    }
}