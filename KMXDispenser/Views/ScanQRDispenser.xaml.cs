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

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for ScanQRDispenser.xaml
    /// </summary>
    public partial class ScanQRDispenser : Page
    {
        public ScanQRDispenser()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TxtQR.Focus();
          
        }

        private void TxtQR_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtQR.Text == "1")
            {
                DispenserQRResult dispenserQRResult = new DispenserQRResult();
                dispenserQRResult.ShowDialog();
            }
        }
    }
}
