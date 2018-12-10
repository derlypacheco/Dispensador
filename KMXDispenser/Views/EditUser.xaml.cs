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
using WpfDisp;
using System.Data;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadInfoUser()
        {
            cnnClass.Conectar();
            try
            {
                cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_verInfoUserDisp('" + cnnClass.publicUserEdit + "')", cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["nombre_user"].ToString();
                    comboAccess.Text = dt.Rows[0]["nivel_user"].ToString();
                    txtPass.Password = dt.Rows[0]["clave_user"].ToString();
                    comboAccess.IsEnabled = false;
                }
                cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar la información del usuario", "Error usuario", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadInfoUser();
            comboAccess.IsEnabled = false;
        }

        private void btnSalveUser_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "" && txtPass.Password != "")
            {
                cnnClass.Conectar();
                try
                {
                    cnnClass.cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("CALL sp_UpdateUserDisp('" + txtName.Text + "', '" + txtPass.Password + "', '" + cnnClass.publicUserEdit + "')", cnnClass.cnn);
                    cmd.ExecuteNonQuery();
                    cnnClass.cnn.Close();
                    MessageBox.Show("Se ha actualizado la información del usuario", "Guardado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Se ha generado un error contacte al administrador.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No deje campos vacios", "Campos vacios", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }
        }
    }
}
