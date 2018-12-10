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
using MySql.Data.MySqlClient;
using System.Data;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for UpdateCavity.xaml
    /// </summary>
    public partial class UpdateCavity : Window
    {
        public UpdateCavity()
        {
            InitializeComponent();
        }


        private void loadDatos()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_resultCavDet('" + WpfDisp.cnnClass.publicCavDet + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string idLAFM = dt.Rows[0]["id_la_disp"].ToString();
                    TxtCavity.Text = dt.Rows[0]["cavidad_relacion"].ToString();
                    TxtCandado.Text = dt.Rows[0]["pinBlock_relacion"].ToString();
                    TxtContador.Text = dt.Rows[0]["pinContador_relacion"].ToString();
                    TxtStockMin.Text = dt.Rows[0]["min_stock_relacion"].ToString();
                    TxtStockMax.Text = dt.Rows[0]["max_stock_relacion"].ToString();
                    ComboIDCartucho.Text = dt.Rows[0]["Cartucho_relacion"].ToString();
                    WpfDisp.cnnClass.idModRelaciones = dt.Rows[0]["id_relaciones"].ToString();
                    MostrarNombreLAFM(idLAFM);
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados, la ventana se cerrara", "Sin datos", MessageBoxButton.OK, MessageBoxImage.Warning);
                    this.Close();
                }
            }
            catch
            {

            }
        }

        private void MostrarNombreLAFM(string idLAFM)
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_mostrarNombreLA('" + idLAFM + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    TxtNum.Text = dt.Rows[0]["FMproveedor"].ToString();
                    //cnnClass.idLAPublicUpdate = dt.Rows[0]["id_la_disp"].ToString();
                }
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {

            }
        }

        public string idLASP;
        public bool valorRegreso;
        private bool BuscarWFMLA()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_buskFMDisp('" + TxtNum.Text.Trim() + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    TxtNum.BorderBrush = System.Windows.Media.Brushes.Green;

                    valorRegreso = true;
                    idLASP = dt.Rows[0]["id_la_disp"].ToString();
                    //cnnClass.idLAPublicUpdate = dt.Rows[0]["id_la_disp"].ToString();
                    WpfDisp.cnnClass.imgPIN = "https://spa-kufferath.mx/" + dt.Rows[0]["foto_la_disp"].ToString();
                    BtnShowImage.IsEnabled = true;
                    BtnShowImage.Visibility = Visibility.Visible;
                    //MessageBox.Show(idLASP);
                    WpfDisp.cnnClass.cnn.Close();
                }
                else
                {
                    TxtNum.BorderBrush = System.Windows.Media.Brushes.Red;
                    WpfDisp.cnnClass.cnn.Close();
                    valorRegreso = false;
                }
                BtnSearchNum.IsEnabled = true;
            }
            catch
            {
            }
            return valorRegreso;
        }


        private void btnCloseForm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void guardaInfoDisp(string idModulo)
        {
            // MessageBox.Show(cnnClass.publicCavDet);
            WpfDisp.cnnClass.Conectar();
            try
            {
                int valueModulo = Convert.ToInt16(WpfDisp.cnnClass.idModuloPublic); // idModuloPublic
                //MessageBox.Show("ID del modulo: "+valueModulo);
                // falta rnviar el ID correcto para el where y hacer el update correcto
                //'"+txtCavidad.Text+ "', '"+cnnClass.UserID+ "', '"+txtCoorX.Text+ "', '"+txtCoorY.Text+ "', '"+txtPinLook.Text+ "', '"+txtPinContador.Text+"', '"+ cnnClass.idModuloPublic + "', '"+txtMaximo.Text+"', '"+txtMinimo.Text+"', '"+ idLASP + "', '"+ valueModulo + "'
                // string cadena = txtCavidad.Text + " - " + cnnClass.UserID + " - " + txtCoorX.Text + " - " + txtCoorY.Text + " - " + txtPinLook.Text + " - " + txtPinContador.Text + " - " + cnnClass.idModuloPublic + " - " + txtMaximo.Text + " - " + txtMinimo.Text + " - " + idLASP + " - " + cnnClass.idModRelaciones;
                // MessageBox.Show(cadena);
                WpfDisp.cnnClass.cnn.Open();
                MySqlCommand cmd = new MySqlCommand("CALL sp_disp_guardaCavDet('" + TxtCavity.Text + "', '" + WpfDisp.cnnClass.UserID + "', '" + ComboIDCartucho.Text + "', '" + TxtCandado.Text + "', '" + TxtContador.Text + "', '" + WpfDisp.cnnClass.idModuloPublic + "', '" + TxtStockMax.Text + "', '" + TxtStockMin.Text + "', '" + idLASP + "', '" + WpfDisp.cnnClass.idModRelaciones + "')", WpfDisp.cnnClass.cnn);
                cmd.ExecuteNonQuery();
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("No se ha podido almacenar la información", "Error de comunicación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void BtnUpdateCavDet_Click(object sender, RoutedEventArgs e)
        {
            if (BuscarWFMLA() == true)
            {
                WpfDisp.cnnClass.Conectar();
                try
                {
                    WpfDisp.cnnClass.cnn.Open();
                    MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_buskFMDisp('" + TxtNum.Text.Trim() + "')", WpfDisp.cnnClass.cnn);
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        TxtNum.BorderBrush = System.Windows.Media.Brushes.Green;
                        TxtNum.Text = dt.Rows[0]["numPart_Prov_la_disp"].ToString();
                        idLASP = dt.Rows[0]["id_la_disp"].ToString();
                        WpfDisp.cnnClass.cnn.Close();
                        int modID = Convert.ToInt16(WpfDisp.cnnClass.publicCavDet);
                        guardaInfoDisp(WpfDisp.cnnClass.publicCavDet);
                        MessageBox.Show("Se ha guardado el registro correctamente", "Actualización correcta", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        TxtNum.BorderBrush = System.Windows.Media.Brushes.Red;
                        MessageBox.Show("El número de proveedor no corresponde a uno valido", "Número no encontrado", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                catch
                {

                }
            }
        }

        private void BtnShowImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ShowImage FrmImagen = new ShowImage();
                FrmImagen.ShowDialog();
            }
            catch
            {

            }
        }

        private void BtnSearchNum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BtnSearchNum.IsEnabled = false;
                BuscarWFMLA();
            }
            catch
            {

            }
        }

        private void llenarComboCartucho()
        {
            try
            {
                for (int i=1; i <= WpfDisp.cnnClass.cartuchos; i++)
                {
                    ComboIDCartucho.Items.Add(i);
                }
            }
            catch
            {
                MessageBox.Show("No se han cargado los cartuchos disponibles","Cargando cartuchos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            llenarComboCartucho();
            //label.Content = "Cavidad seleccionada: "+cnnClass.publicCav;
            loadDatos();
            TxtNum.BorderBrush = System.Windows.Media.Brushes.Transparent;
            //btnSave.IsEnabled = false;
            BtnShowImage.Visibility = Visibility.Hidden;
            BtnShowImage.IsEnabled = false;
        }
    }
}
