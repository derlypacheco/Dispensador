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
using System.Data;
using WpfDisp;
using MySql.Data.MySqlClient;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        { 
                cnnClass.Conectar();
                try
                {
                    MySqlDataAdapter cmd = new MySqlDataAdapter("CALL spListLA_disp('" + TxtSearchBox.Text.Trim() + "')", cnnClass.cnn);
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    if(dt.Rows.Count == 1)
                    {
                    // Cargamos en variable publica el valor a buscar.
                    cnnClass.txtNumeroBuscar = TxtSearchBox.Text.Trim();
                    TxtSearchBox.Text = "";
                    SearchButton.IsEnabled = false;
                    SearchDispenser searchDispenser = new SearchDispenser();
                    searchDispenser.ShowDialog();
                    }
                    if(dt.Rows.Count == 0)
                    {
                    // Mensaje numero LA no existe.
                    MessageBox.Show("El número " + TxtSearchBox + " no existe en la base de datos.", "Sin resultados", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    cnnClass.cnn.Close();
                }
                catch
                {
                    MessageBox.Show(cnnClass.errConexion, "Problemas de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                } 
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SearchButton.IsEnabled = false;
        }

        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TxtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            int cant = TxtSearchBox.Text.Length;
            if (cant > 3)
            {
                SearchButton.IsEnabled = true;
            }
            else
            {
                SearchButton.IsEnabled = false;
            }
        }
    }
}
