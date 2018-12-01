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
using System.Threading;

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

        public int cav, det;
        public string rand;


        private void randValor()
        {
            Random obj = new Random();
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = posibles.Length;
            char letra;
            int longitudnuevacadena = 8;
            string nuevacadena = "";
            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            rand = nuevacadena;
            //MessageBox.Show(rand);
        }
        private void NewLinebButton_Click(object sender, RoutedEventArgs e)
        {

            AddLine addLine = new AddLine(); //Declare the window NewUser
            //Set current position of the NewUser Window is located from the button location;
            //addLine.Top = 130;
            //addLine.Left = 340;
            addLine.ShowDialog(); //Shows the window with the custom position

        }

        // Funcion para insertar todas las cavidades que aplican 
        private void LlenaGrdCavidades(int ca, string rand)
        {
            // Valor que recive ca corresponde a la cantidad de cavidades y detecciones
            int start = 0; // iniciamos el ciclo
            WpfDisp.cnnClass.Conectar();
            WpfDisp.cnnClass.cnn.Open();
            while (start < ca)
            {
                try
                {
                    MySqlCommand cmd1 = new MySqlCommand("CALL sp_AddCavidades('DET" + start + "', '" + rand + "', '" + WpfDisp.cnnClass.UserID + "', '" + CboxLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                    cmd1.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand("CALL sp_AddCavidades('CAV" + start + "', '" + rand + "', '" + WpfDisp.cnnClass.UserID + "', '" + CboxLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                    cmd2.ExecuteNonQuery();
                    start++;
                }
                catch
                {
                    MessageBox.Show("Error al agregar las cavidades", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            WpfDisp.cnnClass.cnn.Close();
            start = 0;
            GrCav(rand);
        }
        // End Llena GridCavidades 

        private void GrCav(string fol)
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_disp_cavdet('" + fol + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                DataGridCavDet.ItemsSource = dt.DefaultView;
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar las cavidades en la tabla", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        // Llenando el DataGrid con las cavidades y detecciones. 
        // Ejecutamos cuando buscas un modulo
        private void GrDet(string fol)
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_disp_cavdet('" + fol + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                DataGridCavDet.ItemsSource = dt.DefaultView;
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar las cavidades en la tabla", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LlenaGrdDetecciones(int de, string ra)
        {
            int start = 0;
            WpfDisp.cnnClass.Conectar();
            WpfDisp.cnnClass.cnn.Open();
            while (start < de)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CALL sp_AddCavidades('DET" + start + "', '" + ra + "', '" + WpfDisp.cnnClass.UserID + "', '" + CboxLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                    cmd.ExecuteNonQuery();
                    start++;
                }
                catch
                {
                    MessageBox.Show("Error al agregar las detecciones", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            WpfDisp.cnnClass.cnn.Close();
            start = 0;
            //GrDet(rand);
        }

        public void llenaCombo()
        {
            WpfDisp.cnnClass.Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("CALL sp_ListLineas('" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
            DataSet dt = new DataSet();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                da.Fill(dt, "disp_Lineas");
                CboxLine.ItemsSource = dt.Tables["disp_Lineas"].DefaultView;
                CboxLine.DisplayMemberPath = dt.Tables["disp_Lineas"].Columns["linea_lndisp"].ToString();
                CboxLine.SelectedValuePath = dt.Tables["disp_Lineas"].Columns["id_linea_lndisp"].ToString();
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("No se cargaron las Líneas", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CboxLine_DropDownOpened(object sender, EventArgs e)
        {
            llenaCombo();
        }

        private void validaBTN()
        {
            if (TxtNombreID.Text != "")
            {
                SearchWebButton.IsEnabled = true;
            }
            else
            {
                SearchWebButton.IsEnabled = false;
            }
        }

        public string folioBusk = "";

        private void SearchWebButton_Click(object sender, RoutedEventArgs e)
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                validaBTN();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_buskModuloFrm('" + TxtNombreID.Text.Trim() + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    WpfDisp.cnnClass.cnn.Open();
                    TxtCavidad.Text = dt.Rows[0]["cant_cav_mod"].ToString();
                    TxtDeteccion.Text = dt.Rows[0]["cant_det_mod"].ToString();
                    TxtNumberM.Text = dt.Rows[0]["numerom_mod"].ToString();
                    TxtPartNumber.Text = dt.Rows[0]["noPart_mod"].ToString();
                    WpfDisp.cnnClass.idModuloPublic = dt.Rows[0]["id_modulo"].ToString();
                    WpfDisp.cnnClass.idLAPublicUpdate = dt.Rows[0]["id_modulo"].ToString();
                    //comboLineas.Text = dt.Rows[0][""].ToString();
                    TxtNombreID.Text = dt.Rows[0]["id_cliente_mod"].ToString();
                    //imgPin.Source = new BitmapImage(new Uri(""));
                    WpfDisp.cnnClass.cnn.Close();
                    folioBusk = dt.Rows[0]["key_mod"].ToString();
                    //MessageBox.Show(folioBusk);
                    GrCav(folioBusk);
                }
                else
                {
                    TxtCavidad.Text = "";
                    TxtDeteccion.Text = "";
                    TxtNumberM.Text = "";
                    TxtPartNumber.Text = "";
                    TxtNombreID.Text = "";
                    DataGridCavDet.ItemsSource = null;
                    //DataGridCavDet.Items.Refresh();
                }
                //if(folioBusk != "")
                //{

                //}
            }
            catch
            {

            }
        }

       

        private void DataGridCavDet_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            // Debe mostrar al principio el ID para mandar llamar la funcion a otro formulario mediante una variable publica 
            // cuando esta variable se deja de usar o cierra el dialogo se vacia esta variable. 
            try
            {
                DataRowView row = DataGridCavDet.SelectedItem as DataRowView;
                WpfDisp.cnnClass.publicCavDet = row.Row.ItemArray[0].ToString();
                WpfDisp.cnnClass.idLAPublicUpdate = row.Row.ItemArray[2].ToString();
                UpdateCavity AcCav = new UpdateCavity();
                AcCav.ShowDialog();
                // MessageBox.Show(row.Row.ItemArray[0].ToString());
            }
            catch
            {

            }
        }

        public void GuardarCnn()
        {
            WpfDisp.cnnClass.Conectar();
            MySqlCommand cmd = new MySqlCommand("CALL sp_NuevoModulo('" + TxtNombreID.Text + "','" + TxtPartNumber.Text + "','" + TxtCavidad.Text + "','" + TxtDeteccion.Text + "','" + WpfDisp.cnnClass.UserID + "','" + WpfDisp.cnnClass.ID_Dispensador + "', '" + TxtDesc.Text + "', '" + rand + "', '" + TxtNumberM.Text + "')", WpfDisp.cnnClass.cnn);
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                cmd.ExecuteNonQuery();
                WpfDisp.cnnClass.cnn.Close();
                btnAddModule.IsEnabled = true;
                // Llenamos la Grid de las Cavidades
                cav = Convert.ToInt16(TxtCavidad.Text);
                det = Convert.ToInt16(TxtDeteccion.Text);
                // Inserta Cavidades
                LlenaCavDet(cav, rand);
                // Inserta Detecciones
                LlenaDetDet(det, rand);
                // Llena el Grid
                GrDet(rand);
                MessageBox.Show("Se ha creado el Módulo " + TxtNombreID.Text + " correctamente", "Nuevo módulo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show(WpfDisp.cnnClass.errConexion, "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LlenaDetDet(int de, string ra)
        {
            int start = 0;
            WpfDisp.cnnClass.Conectar();
            WpfDisp.cnnClass.cnn.Open();
            while (start < de)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CALL sp_AddCavidades('DET" + start + "', '" + ra + "', '" + WpfDisp.cnnClass.UserID + "', '" + CboxLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                    cmd.ExecuteNonQuery();
                    start++;
                }
                catch
                {
                    MessageBox.Show("Error al agregar las detecciones", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            WpfDisp.cnnClass.cnn.Close();
            start = 0;
            //GrDet(rand);  // Se ha cambiado al momento de generar el modulo
        }

        private void LlenaCavDet(int ca, string rand)
        {
            int start = 0;
            WpfDisp.cnnClass.Conectar();
            WpfDisp.cnnClass.cnn.Open();
            while (start < ca)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CALL sp_AddCavidades('CAV" + start + "', '" + rand + "', '" + WpfDisp.cnnClass.UserID + "', '" + CboxLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                    cmd.ExecuteNonQuery();
                    start++;
                }
                catch
                {
                    MessageBox.Show("Error al agregar las cavidades", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            WpfDisp.cnnClass.cnn.Close();
            start = 0;
            //GrCav(rand); // Se ha cambiado al momento de generar el modulo
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            randValor();
            //SearchWebButton.IsEnabled = false;
            llenaCombo();

        }

        private void btnAddModule_Click(object sender, RoutedEventArgs e)
        {
            btnAddModule.IsEnabled = false;
            GuardarCnn();
            //try
            //{
            //    new Thread(() =>
            //    {
            //        btnAddModule.Dispatcher.BeginInvoke(new Action(() =>
            //            {
            //                btnAddModule.IsEnabled = false;
            //            }
            //        ));

            //    }).Start();
            //}
            //catch
            //{

            //}
        }
    }
}
