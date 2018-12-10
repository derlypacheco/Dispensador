using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;
using System.Net;
//using System.Net.NetworkInformation;
using System.IO.Ports;
using System.Windows.Input;
using System.Windows;

namespace WpfDisp
{
    class cnnClass
    { 
        public static string UserID, localIP, publicUserEdit, publicCavDet, disensador, imgPIN, encripPublic, descriptPublic, serieDispensador, licenciaWeb, hk_disp, HKDispensador, tipoSurtir;
        public static char ver_tablas, exportar, ver_graficas;
        public static int publicHuella;
        public static String TotalesSurtir; // Solo cuando estan surtiendo el dispensador
        public static Int16 IDtoRestar, cartuchos;
        public static int IDcantrestar;
        public static string GlobalID_Relacion, txtNumeroBuscar;

        // String de envio a Arduino // 
        public static string send_fila, send_columna, send_ancla, send_led, send_llave, send_cant, send_accion, send_id, send_ledRojo;
        // Se envia de la siguiete manera 
        public static string sendDataArduino = send_fila+";"+send_columna+ ";" + send_ancla+ ";" + send_led+ ";" + send_llave+ ";" + send_cant+ ";" + send_accion+ ";" + send_id;

        public static string idModuloPublic;
        public static string idLAPublicUpdate;
        public static string idModRelaciones;
        public static string rutaPDF; 

        public static string PortName = "COM10";

       public static void vaciarSenders()
        {
            send_accion = "0";      // Accion a realizar 0 = Grabar, 1 = Leer, 2 = Dispensar, 3 = Surtir
            send_fila = "0";        // Fila en dispensador
            send_ancla = "0";       // Ancla de cartucho
            send_cant = "0";        // Cantidad a dispensar solo aplica para ordenes del SAP
            send_columna = "0";     // Columna en el dispensador 
            send_id = "0";          // ID de la Huella del usuario
            send_led = "0";         // Led del cartucho

            send_llave = "0";       // Llave a dispensar 
        }

        public static string pc_Marca, pc_Serie, pc_BoardProduct, pc_BiosVersion, pc_ModelVersion, pc_Procesador, ID_Dispensador;
        public static string errConexion = "No hay conexión a internet verifique con el Administrador de red en su empresa.";
        public static string sinResultados = "No se encontraron resultados.";
        public static string tablaVacia = "No hay resultados para mostrar en la tabla.";
        public static string nopuedeabrir = "No se puede abrir este módulo de la aplicación"; 

        public static MySqlConnection cnn;
        //public static string erCnn;

        public static SerialPort serial = new SerialPort {
            PortName = "COM1",
            BaudRate = 9600,
            Handshake = Handshake.None,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One,
            ReadTimeout = 200,
            WriteTimeout = 50
        };

        public static void saber()
        {
            if (Keyboard.IsKeyDown(Key.K) && Keyboard.IsKeyDown(Key.Escape) && Keyboard.IsKeyDown(Key.M))
            {
                MessageBox.Show("Propiedad de kufferath México");
            }

            if (Keyboard.IsKeyDown(Key.F10))
            {
                //EncriptarCadena qr = new EncriptarCadena();
                //qr.ShowDialog();
            }

            if (Keyboard.IsKeyDown(Key.F1))
            {
                //VisorPDF visor = new VisorPDF();
                //visor.ShowDialog();
            }
        }

        public static MySqlConnection Conectar()
        {
                string strcnn = "Database=spakuffe_kufferath; Data Source=spa-kufferath.mx;User Id=spakuffe_plantas;Password=Ganspod123";
                cnn = new MySqlConnection(strcnn);
                return cnn;
        }

        public static void desconectar()
        {
            try
            {
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Error en desconectar");
            }
        }

        /// Encripta una cadena
        public static void EncriptarSerie(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            serieDispensador = result;
        }

        public static void ObtenerIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            
        }

        public static void obtenerInfoPC()
        {
            try
            {
                String path2 = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";  // Procesador usado
                String path = "HARDWARE\\DESCRIPTION\\System\\BIOS"; // Información de la Placa Base
                RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
                RegistryKey key2 = Registry.LocalMachine.OpenSubKey(path2);
                pc_Procesador = key2.GetValue("ProcessorNameString").ToString();
                String processor = key.GetValue("BaseBoardProduct").ToString();
                pc_BiosVersion = key.GetValue("BIOSVersion").ToString();
                pc_BoardProduct = key.GetValue("BaseBoardProduct").ToString();
                pc_Marca = key.GetValue("SystemManufacturer").ToString();
                pc_ModelVersion = key.GetValue("SystemVersion").ToString();
                pc_Serie = key.GetValue("BaseBoardProduct").ToString();
                EncriptarSerie(processor);
            }
            catch
            {

            }
        }


        public static bool openCnn()
        {
            try
            {
                Conectar();
                return true;
            }  catch
            {
                return false;
                
            }
        }

        
    }

}



//foreach(string st in SerialPort.GetPortNames())
//                {
//                   // Listar puertos 
//                }