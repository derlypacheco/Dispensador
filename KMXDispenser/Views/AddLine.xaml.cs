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
using MySql.Data.MySqlClient;
using System.Data;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for AddLine.xaml
    /// </summary>
    public partial class AddLine : Window
    {
        public AddLine()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLineas();
            BtnAddLine.IsEnabled = false;
        }

        private void txtValidador()
        {
            int total = TxtAddNewLineTxtAddNewLine.Text.Length;
            if (total > 3)
            {
                BtnAddLine.IsEnabled = true;
            }
            else
            {
                BtnAddLine.IsEnabled = false;
            }
        }

        private void LoadLineas()
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlDataAdapter cmd = new MySqlDataAdapter("CALL sp_ListLineasPlanta('" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                DatagridLineDetails.ItemsSource = dt.DefaultView;
                WpfDisp.cnnClass.cnn.Close();
            }
            catch
            {
                MessageBox.Show("No se pueden mostrar las lineas en la tabla", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddLine_Click(object sender, RoutedEventArgs e)
        {
            WpfDisp.cnnClass.Conectar();
            try
            {
                WpfDisp.cnnClass.cnn.Open();
                MySqlCommand cmd = new MySqlCommand("CALL sp_AddLineaPlanta('" + TxtAddNewLineTxtAddNewLine.Text + "', '" + WpfDisp.cnnClass.ID_Dispensador + "')", WpfDisp.cnnClass.cnn);
                cmd.ExecuteNonQuery();
                WpfDisp.cnnClass.cnn.Close();
                TxtAddNewLineTxtAddNewLine.Text = "";
                LoadLineas();
            }
            catch
            {
                MessageBox.Show("Error al agregar la línea", "Error inserción", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TxtAddNewLineTxtAddNewLine_KeyDown(object sender, KeyEventArgs e)
        {
            txtValidador();
        }
    }
}
