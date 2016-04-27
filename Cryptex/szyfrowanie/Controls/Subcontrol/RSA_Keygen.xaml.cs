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

namespace Szyfrowanie.Controls.Subcontrol
{
    /// <summary>
    /// Interaction logic for RSA_Keygen.xaml
    /// </summary>
    public partial class RSA_Keygen : UserControl
    {
        public RSA_Keygen()
        {
            InitializeComponent();
            txt_Range.Text = "1000";
        }
        Class.RSA rsa = new Class.RSA();

        private void bt_Gen_Click(object sender, RoutedEventArgs e)
        {
            string key = rsa.keygen(Convert.ToInt32(txt_Range.Text));
            txt_Keyn.Text = key.Substring(0, key.IndexOf('|'));
            key = key.Remove(0, key.IndexOf('|')+1);
            txt_Keye.Text = key.Substring(0, key.IndexOf('/'));
            key = key.Remove(0, key.IndexOf('/')+1);
            txt_Keynn.Text = key.Substring(0, key.IndexOf('|'));
            key = key.Remove(0, key.IndexOf('|')+1);
            txt_Keyd.Text = key.Substring(0, key.Length);
        }
       
    }
}
