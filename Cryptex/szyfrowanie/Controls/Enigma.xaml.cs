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
    /// Interaction logic for Enigma.xaml
    /// </summary>
    public partial class Enigma : UserControl
    {
        public Enigma()
        {
            InitializeComponent();
            Enigma_Grid.Children.Clear();
            Enigma_Grid.Children.Add(new Subcontrol.Enigma_Do());
        }

        private void Enigma_btDo_Click(object sender, RoutedEventArgs e)
        {
            Enigma_Grid.Children.Clear();
            Enigma_Grid.Children.Add(new Subcontrol.Enigma_Do());
        }

        private void Enigma_btOpis_Click(object sender, RoutedEventArgs e)
        {
            Enigma_Grid.Children.Clear();
            Enigma_Grid.Children.Add(new Subcontrol.Enigma_Opis());
        }

        private void Enigma_btAlgo_Click(object sender, RoutedEventArgs e)
        {
            Enigma_Grid.Children.Clear();
            Enigma_Grid.Children.Add(new Subcontrol.Enigma_Algo());
        }

        private void Cezar_btPom_Click(object sender, RoutedEventArgs e)
        {
            Enigma_Grid.Children.Clear();
            Enigma_Grid.Children.Add(new Subcontrol.Pomoc_Enigma());
        }
    }
}
