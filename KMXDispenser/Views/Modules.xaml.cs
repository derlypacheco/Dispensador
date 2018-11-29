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
    /// Interaction logic for Modules.xaml
    /// </summary>
    public partial class Modules : Page
    {
        public Modules()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Dashboard());
        }
        
        private void AddModulesItem_Selected(object sender, RoutedEventArgs e)
        {
            ModuleFrameContent.Navigate(new AddModules());
            infoModulesItem.IsSelected = false;

        }

        private void InfoModulesItem_Selected(object sender, RoutedEventArgs e)
        {
            ModuleFrameContent.Navigate(new ModulesInfo());
            AddModulesItem.IsSelected = false;
        }

     
    }
}
