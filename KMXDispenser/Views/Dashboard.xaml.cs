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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
       
        public Dashboard()
        {
            InitializeComponent();
        }

        private void AddModulesButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Modules());
        }

        private void ManualsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
