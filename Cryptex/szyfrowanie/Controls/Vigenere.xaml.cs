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
    /// Interaction logic for Vigenere.xaml
    /// </summary>
    public partial class Vigenere : UserControl
    {
        public Vigenere()
        {
            InitializeComponent();
            Vigen_Grid.Children.Clear();
            Vigen_Grid.Children.Add(new Subcontrol.Vigen_Do());
        }

        private void Vigen_btDo_Click(object sender, RoutedEventArgs e)
        {
            Vigen_Grid.Children.Clear();
            Vigen_Grid.Children.Add(new Subcontrol.Vigen_Do());
        }

        private void Vigen_btOpis_Click(object sender, RoutedEventArgs e)
        {
            Vigen_Grid.Children.Clear();
            Vigen_Grid.Children.Add(new Subcontrol.Vigen_Opis());
        }

        private void Vigen_btPom_Click(object sender, RoutedEventArgs e)
        {
            Vigen_Grid.Children.Clear();
            Vigen_Grid.Children.Add(new Subcontrol.Pomoc_Vigenere());
        }
        private void Vigen_btAlgo_Click(object sender, RoutedEventArgs e)
        {
            Vigen_Grid.Children.Clear();
            Vigen_Grid.Children.Add(new Subcontrol.Vigen_Algo());
        }
    }
}
