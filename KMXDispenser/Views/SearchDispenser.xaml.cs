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
using System.Data;
using WpfDisp;
using MySql.Data.MySqlClient;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for SearchDispenser.xaml
    /// </summary>
    public partial class SearchDispenser : Window
    {
        public SearchDispenser()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void llenarInfo()
        {
            cnnClass.Conectar();
            try
            {
                cnnClass.cnn.Open();
                string sqlString = "CALL spListLA_disp('" + cnnClass.txtNumeroBuscar + "')";
                MySqlDataAdapter cmd = new MySqlDataAdapter(sqlString, cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblNameLA.Content = "Número LA: "+dt.Rows[0]["prov_la_disp"].ToString();
                    ProviderNumTitle.Content = "Número de Proveedor: "+dt.Rows[0]["numPart_Prov_la_disp"].ToString();
                    ProviderTitle.Content = "Proveedor: "+dt.Rows[0]["marcaProv_la_disp"].ToString();
                    ClientNumTitle.Content = "Número de Cliente: " + dt.Rows[0]["numPart_Cliente_la_disp"].ToString();
                    ProviderAltTitle.Content = "Proveedor Alterno: " + dt.Rows[0]["provalterno_la_disp"].ToString();
                    BrandAltTitle.Content = "Marca Alterna: " + dt.Rows[0]["marcaprovalterno_la_disp"].ToString();
                    KeyTitle.Content = "Llave:" + dt.Rows[0]["llave_la_disp"].ToString();
                    TypeTitle.Content = "Tipo:" + dt.Rows[0]["tipo_la_disp"].ToString();
                    StockTitle.Content = "Existencias:" + dt.Rows[0]["existencia_la_disp"].ToString();
                    //LocatePinTitle.Content = "Ubicacion del pin:" + dt.Rows[0]["coordX_la_disp"].ToString();
                   // txtCoorY.Text = dt.Rows[0]["coordY_la_disp"].ToString();
                    cnnClass.imgPIN = "https://spa-kufferath.mx/" + dt.Rows[0]["foto_la_disp"].ToString();
                    CallModulos(dt.Rows[0]["id_la_disp"].ToString());
                    if (dt.Rows[0]["foto_la_disp"].ToString() != "")  // System.IO.File.Exists(dt.Rows[0]["foto_la_disp"].ToString())
                    {
                        BtnShowImage.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        BtnShowImage.Visibility = Visibility.Hidden;
                    }
                }
            }
            catch
            {
                MessageBox.Show(cnnClass.errConexion, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CallModulos(string id)
        {
            try
            {
                cnnClass.Conectar();
                string sqlModulo = "spModulos_disp('" + id + "')";
                MySqlDataAdapter cmd = new MySqlDataAdapter(sqlModulo, cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                DatagridModuleApplied.ItemsSource = dt.DefaultView;
            }
            catch
            {
                MessageBox.Show(cnnClass.errConexion, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            llenarInfo();
        }

        private void BtnShowImage_Click(object sender, RoutedEventArgs e)
        {
            ShowImage fotoFrm = new ShowImage();
            fotoFrm.ShowDialog();
        }

        private void llenarGrid(string id)
        {
            try
            {
                cnnClass.Conectar();
                string sqlGridTable = "CALL spLAaplican_disp('" + id + "')";
                MySqlDataAdapter cmd = new MySqlDataAdapter(sqlGridTable, cnnClass.cnn);
                DataTable dt = new DataTable("disp_modulos");
                cmd.Fill(dt);
                DatagridResult.ItemsSource = dt.DefaultView;
            }
            catch
            {
                MessageBox.Show(cnnClass.errConexion, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DatagridModuleApplied_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataRowView row = DatagridModuleApplied.SelectedItem as DataRowView;
                llenarGrid(row.Row.ItemArray[5].ToString());
                Decimal total = DatagridResult.Items.Count;
                // GroupCavidades.Header = "Corresponde a Modulo " + row.Row.ItemArray[1].ToString().Trim() + " | Número M: " + row.Row.ItemArray[2].ToString().Trim() + " Total: " + total;
            }
            catch
            {

            }
        }
    }
}
