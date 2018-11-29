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
using System.Windows.Shapes;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for AddMaterial.xaml
    /// </summary>
    public partial class AddMaterial : Page
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void BtnSurtir_Click(object sender, RoutedEventArgs e)
        {
            VerifySupplying verifySupplying = new VerifySupplying();
            verifySupplying.ShowDialog();
        }

        private void btnImagen_Click(object sender, RoutedEventArgs e)
        {
            ShowImage showImage = new ShowImage();
            showImage.ShowDialog();
        }
    }
}
