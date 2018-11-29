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

namespace KMXDispenser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void HostWindowInFrame(Frame fraContainer, Window win)
        {
            object tmp = win.Content;
            win.Content = null;
            fraContainer.Content = new ContentControl() { Content = tmp };
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DashboardItem_TouchDown(object sender, TouchEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.ToolTip = "Pressed";

        }

        private void DashboardItem_Selected(object sender, RoutedEventArgs e)
        {
            ContentMultiScreen.Navigate(new Views.Dashboard());
           // HostWindowInFrame(ContentMultiScreen, new Views.Dashboard());
        }

        private void UsuarioItem_Selected(object sender, RoutedEventArgs e)
        {
            ContentMultiScreen.Navigate(new Views.Users());
        }

        private void SurtirItem_Selected(object sender, RoutedEventArgs e)
        {
            ContentMultiScreen.Navigate(new Views.AddMaterial());
        }

        private void BuscarItem_Selected(object sender, RoutedEventArgs e)
        {
            ContentMultiScreen.Navigate(new Views.Search());
        }

        private void DispensarItem_Selected(object sender, RoutedEventArgs e)
        {

            ContentMultiScreen.Navigate(new Views.ScanQRDispenser());
        }
    }
}
