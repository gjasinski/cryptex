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
    /// Interaction logic for Pomoc.xaml
    /// </summary>
    public partial class Pomoc : UserControl
    {
        public Pomoc()
        {
            InitializeComponent();
            Pomoc_Grid.Children.Clear();
            Pomoc_Grid.Children.Add(new Subcontrol.Pomoc_Cezar());
        }

        private void Pomoc_btCezar_Click(object sender, RoutedEventArgs e)
        {
            Pomoc_Grid.Children.Clear();
            Pomoc_Grid.Children.Add(new Subcontrol.Pomoc_Cezar());
        }

        private void Pomoc_btViegenere_Click(object sender, RoutedEventArgs e)
        {
            Pomoc_Grid.Children.Clear();
            Pomoc_Grid.Children.Add(new Subcontrol.Pomoc_Vigenere());
        }

        private void Pomoc_btKeygen_Click(object sender, RoutedEventArgs e)
        {
            Pomoc_Grid.Children.Clear();
            Pomoc_Grid.Children.Add(new Subcontrol.Pomoc_Keygen());
        }

        private void Pomoc_btEnigma_Click(object sender, RoutedEventArgs e)
        {
            Pomoc_Grid.Children.Clear();
            Pomoc_Grid.Children.Add(new Subcontrol.Pomoc_Enigma());
        }
    }
}
