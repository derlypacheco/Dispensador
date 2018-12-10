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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
           
        }

        private void btnCloseForm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }
        }

        private void btnHuella_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                ObtenerHuella();
                // string sendDataArduino = "3;1;3";
                AddOns.COM.SendData("3;1;1");
                VerifyFingerprint verifyFingerprint = new VerifyFingerprint();
                verifyFingerprint.ShowDialog();
                if (WpfDisp.cnnClass.publicHuella > 0)
                {
                    FingerprintIcon.Foreground = new SolidColorBrush(Colors.LightGreen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error Comunucación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnSaUser_Click(object sender, RoutedEventArgs e)
        {
            if (WpfDisp.cnnClass.publicHuella > 0)
            {
                if (txtPass.Password != "" && txtNombre.Text != "" && comboPermiso.Text != "")
                {
                    WpfDisp.cnnClass.Conectar();
                    try
                    {
                        WpfDisp.cnnClass.cnn.Open();
                        MySqlCommand cmd = new MySqlCommand("CALL sp_insertUserDisp('" + txtNombre.Text + "', '" + txtPass.Password + "', '" + comboPermiso.Text + "', '" + WpfDisp.cnnClass.publicHuella + "', '" + Convert.ToInt16(WpfDisp.cnnClass.ID_Dispensador) + "')", WpfDisp.cnnClass.cnn);
                        cmd.ExecuteNonQuery();
                        WpfDisp.cnnClass.cnn.Close();
                        WpfDisp.cnnClass.publicHuella = 0;
                        txtNombre.Text = "";
                        txtPass.Password = "";
                        MessageBox.Show("Se ha registrado el usuario correctamente", "Nuevo usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                        WpfDisp.cnnClass.cnn.Close();
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hay un error al guardar el usuario, revise con el administrador de red" + ex, "Error de registro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No deje campos vacios", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Aun no captura la huella digital", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ObtenerHuella()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_verificaHuella('" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string valorHay = dt.Rows[0]["huella_user"].ToString();
                    int TotalHoy = Convert.ToInt16(dt.Rows[0]["huella_user"].ToString());
                    WpfDisp.cnnClass.publicHuella = TotalHoy + 1;
                }
            }
            catch
            {

            }
        }


    }
}
