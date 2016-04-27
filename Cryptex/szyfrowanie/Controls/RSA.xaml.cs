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
    /// Interaction logic for RSA.xaml
    /// </summary>
    public partial class RSA : UserControl
    {
        public RSA()
        {
            InitializeComponent();
            RSA_Grid.Children.Clear();
            RSA_Grid.Children.Add(new Subcontrol.RSA_Encrypt());
        }

        private void RSA_btEncypt_Click(object sender, RoutedEventArgs e)
        {
            RSA_Grid.Children.Clear();
            RSA_Grid.Children.Add(new Subcontrol.RSA_Encrypt());
        }

        private void RSA_btDecrypt_Click(object sender, RoutedEventArgs e)
        {
            RSA_Grid.Children.Clear();
            RSA_Grid.Children.Add(new Subcontrol.RSA_Decrypt());
        }

        private void RSA_btKeygen_Click(object sender, RoutedEventArgs e)
        {
            RSA_Grid.Children.Clear();
            RSA_Grid.Children.Add(new Subcontrol.RSA_Keygen());
        }

        private void RSA_btPom_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
