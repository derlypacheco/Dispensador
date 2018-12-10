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
using MySql.Data.MySqlClient;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for ModulesInfo.xaml
    /// </summary>
    public partial class ModulesInfo : Page
    {
        public ModulesInfo()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadData()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_listarModulosDispensador('" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                gridModulos.ItemsSource = dt.DefaultView;
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("No se han listado los modulos, revisa tu conexión a internet", "Error en la conexión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BuscarData()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_BuscarModulosDispensador('" + txtModulo.Text.Trim() + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                gridModulos.ItemsSource = dt.DefaultView;
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("No se han listado los modulos, revisa tu conexión a internet", "Error en la conexión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();

        }

        private void buscar()
        {
            try
            {
                if (txtModulo.Text != "")
                {
                    BuscarData();
                }
                else
                {
                    MessageBox.Show("Coloca el número de conector", "Caja vacia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {

            }
        }

        private void SearchButton_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtModulo_KeyDown(object sender, KeyEventArgs e)
        {
            int total = txtModulo.Text.Length;
            if (total > 1)
            {
                buscar();
            }
        }
    }
}
