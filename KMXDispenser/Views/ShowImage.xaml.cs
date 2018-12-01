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
    /// Interaction logic for ShowImage.xaml
    /// </summary>
    public partial class ShowImage : Window
    {
        public ShowImage()
        {
            InitializeComponent();
        }

        private void MainImageContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (InvalidOperationException)
            {

              //Drag only when primary mouse button is down
            }
            
        }

        private void GridTools_MouseMove(object sender, MouseEventArgs e)
        {
            GridTools.Opacity = 100;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Source = new BitmapImage(new Uri(WpfDisp.cnnClass.imgPIN));
            }
            catch
            {
                MessageBox.Show("No se puede mostrar la imagen", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                image.Source = new BitmapImage(new Uri(""));
            }
            catch
            {

            }
        }
    }
}
