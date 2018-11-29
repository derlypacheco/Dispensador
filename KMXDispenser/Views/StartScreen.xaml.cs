using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        private void OpenDispensador()
        {
            try
            {
                new Thread(() =>
                {

                    lblLoadinfo.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        lblLoadinfo.Content = "Cargando información necesaria";
                    }
                    ));
                    for (int i = 0; i <= 100; i++)
                    {
                        BarStart.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            BarStart.Value = i;
                            if (i == 80)
                            {
                                lblLoadinfo.Content = "Abriendo la aplicación";  // colocar esto a 90 % de load
                            }
                            if (i == 100)
                            {
                                
                                      //  Log();
                                        MainWindow principal = new MainWindow();
                                        principal.Show();
                                        this.Hide();
                                
                            }
                        }
                        ));
                        Thread.Sleep(35);
                    }
                }).Start();
            }
            catch
            {

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OpenDispensador();
        }
    }
}
