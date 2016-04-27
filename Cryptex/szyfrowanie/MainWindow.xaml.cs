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

namespace Szyfrowanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Home());
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btMinim_Click(object sender, RoutedEventArgs e)
        {
            MainWin.WindowState = WindowState.Minimized;
        }

        private void btKeygen_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Keygen_Main());
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Home());
        }

        private void btCezar_Tab_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Cezar());
        }

        private void btVige_Tab_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Vigenere());
        }

        private void btKeys_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Keys());
        }

        private void btDefinitions_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Defs());            
        }

        private void btEnigma_Tab_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Enigma());  
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Informacje());  
        }

        private void btHelp_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Pomoc());  
        }

        private void btQuiz_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.Quiz());  
        }

        private void btRSA_Click(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Controls.RSA());
        }
    }













































}
