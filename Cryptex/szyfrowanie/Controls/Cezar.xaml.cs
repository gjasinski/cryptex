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
    /// Interaction logic for Cezar.xaml
    /// </summary>
    public partial class Cezar : UserControl
    {
        public Cezar()
        {
            InitializeComponent();
            Cezar_Grid.Children.Clear();
            Cezar_Grid.Children.Add(new Subcontrol.Cezar_Do());
        }

        private void Cezar_btDo_Click(object sender, RoutedEventArgs e)
        {
            Cezar_Grid.Children.Clear();
            Cezar_Grid.Children.Add(new Subcontrol.Cezar_Do());
        }

        private void Cezar_btOpis_Click(object sender, RoutedEventArgs e)
        {
            Cezar_Grid.Children.Clear();
            Cezar_Grid.Children.Add(new Subcontrol.Cezar_Opis());
        }

        private void Cezar_btAlgo_Click(object sender, RoutedEventArgs e)
        {
            Cezar_Grid.Children.Clear();
            Cezar_Grid.Children.Add(new Subcontrol.Cezar_Algo());
        }

        private void Cezar_btPom_Click(object sender, RoutedEventArgs e)
        {
            Cezar_Grid.Children.Clear();
            Cezar_Grid.Children.Add(new Subcontrol.Pomoc_Cezar());
        }
    }
}
