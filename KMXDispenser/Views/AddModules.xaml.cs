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
    /// Interaction logic for AddModules.xaml
    /// </summary>
    public partial class AddModules : Page
    {
        public AddModules()
        {
            InitializeComponent();
        }

        private void NewLinebButton_Click(object sender, RoutedEventArgs e)
        {

            AddLine addLine = new AddLine(); //Declare the window NewUser
            //Set current position of the NewUser Window is located from the button location;
            //addLine.Top = 130;
            //addLine.Left = 340;
            addLine.ShowDialog(); //Shows the window with the custom position

        }
    }
}
