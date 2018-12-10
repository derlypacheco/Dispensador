using System;
using System.Collections.Generic;
using System.IO.Ports;
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
using System.Windows.Threading;
using WpfDisp;

namespace KMXDispenser.Views
{
    /// <summary>
    /// Interaction logic for VerifyFingerprint.xaml
    /// </summary>
    public partial class VerifyFingerprint : Window
    {
        public VerifyFingerprint()
        {
            InitializeComponent();
        }

        AddOns.COM COMs = new AddOns.COM();

        public char resultHuella;

        public static SerialPort serial = new SerialPort
        {
            PortName = WpfDisp.cnnClass.PortName,
            BaudRate = 9600,
            Handshake = Handshake.None,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One,
            ReadTimeout = 200,
            WriteTimeout = 50
        };

        private void conectar_puertoserial()
        {
            try
            {
                serial.Open();
                serial.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
            }
            catch
            {
                //MessageBox.Show("No se puede conectar al dispensador.", "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                TerminaTodo();
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serial.IsOpen)
                {
                    string reciberx = serial.ReadExisting();
                    int value = Convert.ToInt16(reciberx);
                    MessageBox.Show(reciberx);
                    //Thread.Sleep(5);
                    if (value == 3) // valor es igual al valor enviado. 
                    {
                        
                        TerminaTodo();
                    }
                }
                else
                {
                   MessageBox.Show("El dispensador no esta conectado", "Conexión", MessageBoxButton.OK, MessageBoxImage.Warning);
                   //TerminaTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "", MessageBoxButton.OK, MessageBoxImage.Error);
                //TerminaTodo();
            }

        }

        private void TerminaTodo()
        {
            try
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = false;
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, (SendOrPostCallback)delegate {
                        if (serial.IsOpen)
                        {
                            serial.Close();
                        }  
                    this.Close();
                    }, null);
                }).Start();
            }
            catch
            {
                //MessageBox.Show("Hay un problema al terminar los procesos.", "Error de procesos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            WpfDisp.cnnClass.publicHuella = 0;
            TerminaTodo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conectar_puertoserial();
        }
    }
}
