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
    /// Interaction logic for Keygen_Main.xaml
    /// </summary>
    public partial class Keygen_Main : UserControl
    {
        public Keygen_Main()
        {
            InitializeComponent();
            Keygen_Grid.Children.Clear();
            Keygen_Grid.Children.Add(new cKeygen());
        }

        private void Keygen_btDo_Click(object sender, RoutedEventArgs e)
        {
            Keygen_Grid.Children.Clear();
            Keygen_Grid.Children.Add(new cKeygen());
        }

        private void Keygen_btOpis_Click(object sender, RoutedEventArgs e)
        {
            Keygen_Grid.Children.Clear();
            Keygen_Grid.Children.Add(new Subcontrol.cKeygen_Opis());
        }

        private void Keygen_btPom_Click(object sender, RoutedEventArgs e)
        {
            Keygen_Grid.Children.Clear();
            Keygen_Grid.Children.Add(new Subcontrol.Pomoc_Keygen());
        }

        private void Keygen_btAlgo_Click(object sender, RoutedEventArgs e)
        {
            Keygen_Grid.Children.Clear();
            Keygen_Grid.Children.Add(new Subcontrol.cKeygen_Algo());
        }
    }
}
