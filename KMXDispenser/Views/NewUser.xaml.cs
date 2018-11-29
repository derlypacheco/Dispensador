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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
           
        }

        private void btnCloseForm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHuella_Click(object sender, RoutedEventArgs e)
        {
            VerifyFingerprint verifyFingerprint = new VerifyFingerprint();
            verifyFingerprint.ShowDialog();

            FingerprintIcon.Foreground = new SolidColorBrush(Colors.LightGreen);

        }
    }
}
