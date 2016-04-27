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
    /// Interaction logic for Informacje.xaml
    /// </summary>
    public partial class Informacje : UserControl
    {
        public Informacje()
        {
            InitializeComponent();
            Informacje_Grid.Children.Clear();
            Informacje_Grid.Children.Add(new Subcontrol.Informacje_Autorzy());
        }

        private void Informacje_btAutorzy_Click(object sender, RoutedEventArgs e)
        {
            Informacje_Grid.Children.Clear();
            Informacje_Grid.Children.Add(new Subcontrol.Informacje_Autorzy());
        }

        private void Informacje_btZrodla_Click(object sender, RoutedEventArgs e)
        {
            Informacje_Grid.Children.Clear();
            Informacje_Grid.Children.Add(new Subcontrol.Informacje_Zrodla());
        }
    }
}
