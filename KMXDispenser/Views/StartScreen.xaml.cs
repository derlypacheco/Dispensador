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
using System.Data;
using MySql.Data.MySqlClient;

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

        private void ComprobarApp()
        {
            try
            {
                WpfDisp.cnnClass.Conectar();
                WpfDisp.cnnClass.obtenerInfoPC();
                // Consulta a conexion ID_Dispensador
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_ConsultaDispensador('" + WpfDisp.cnnClass.serieDispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    WpfDisp.cnnClass.licenciaWeb = dt.Rows[0]["serie_disp"].ToString();
                    WpfDisp.cnnClass.ID_Dispensador = dt.Rows[0]["id_disp"].ToString();
                    WpfDisp.cnnClass.hk_disp = dt.Rows[0]["hk_disp"].ToString();
                    // Cargamos las cantidades de cartuchos que corresponde al dispensador
                    WpfDisp.cnnClass.cartuchos = Convert.ToInt16(dt.Rows[0]["cartucho_disp"].ToString());
                    //Log();
                }
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show(WpfDisp.cnnClass.errConexion, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

        private void Log()
        {
            WpfDisp.cnnClass.Conectar();
            MySqlCommand cmd = new MySqlCommand("CALL sp_logDisp('" + WpfDisp.cnnClass.ID_Dispensador + "', '" + WpfDisp.cnnClass.pc_Procesador + "', '" + WpfDisp.cnnClass.pc_BiosVersion + "', '" + WpfDisp.cnnClass.pc_BoardProduct + "', '" + WpfDisp.cnnClass.pc_Marca + "', '" + WpfDisp.cnnClass.pc_ModelVersion + "', '" + WpfDisp.cnnClass.pc_Serie + "')", WpfDisp.cnnClass.cnn);
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                cmd.ExecuteNonQuery();
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {

            }
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
                            if (i == 92)
                            {
                                if (WpfDisp.cnnClass.openCnn())
                                {
                                    ComprobarApp();
                                    if (WpfDisp.cnnClass.licenciaWeb == WpfDisp.cnnClass.serieDispensador)
                                    //if ("TABOAFYATgBCADEANgAxADIAMQA2AA==" == cnnClass.serieDispensador)
                                    {
                                        Log();
                                        MainWindow principal = new MainWindow();
                                        principal.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Este dispendador no esta registrado.", "Licencia no valida", MessageBoxButton.OK, MessageBoxImage.Error);
                                        // Frm Solicitar el registro
                                        // SolicitarRegistro registro = new SolicitarRegistro();
                                        // registro.Show();
                                        this.Hide();
                                        //App.Current.Shutdown();
                                    }
                                }
                                else
                                {
                                    // msg error
                                }
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
