using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Input;
using System.Windows;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace KMXDispenser.AddOns
{
    class COM
    {

        public static SerialPort serial = new SerialPort
        {
            PortName = "COM10",
            BaudRate = 9600,
            Handshake = Handshake.None,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One,
            ReadTimeout = 200,
            WriteTimeout = 50
        };

        private static void conectar_puertoserial()
        {
            try
            {
                serial.Open();
                serial.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            }
            catch
            {
                //MessageBox.Show("No se puede conectar al dispensador.", "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                //TerminaTodo();
            }
        }

        private static void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serial.IsOpen)
                {
                    string reciberx = serial.ReadExisting();
                    int value = Convert.ToInt16(reciberx);
                    Thread.Sleep(5);
                    if (value == 1)
                    {
                        //TerminaTodo();
                    }
                }
                else
                {
                    MessageBox.Show("El dispensador no esta conectado", "Conexión", MessageBoxButton.OK, MessageBoxImage.Warning);
                    //TerminaTodo();
                }
            }
            catch
            {
                // MessageBox.Show("Hay un probmea al retornar el valor de la huella", "", MessageBoxButton.OK, MessageBoxImage.Error);
                //TerminaTodo();
            }
        }

        public static void SendData(string ValueRecibe)
        {
            try
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                }
                conectar_puertoserial();
                string sendDataArduino = ValueRecibe;
                string data = sendDataArduino + "\n";
                byte[] hexstring = Encoding.ASCII.GetBytes(data);
                foreach (byte hexval in hexstring)
                {
                    byte[] _hexval = new byte[] { hexval };
                    serial.Write(_hexval, 0, 1);
                    Thread.Sleep(1);
                }
                serial.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex, "Error Comunucación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
