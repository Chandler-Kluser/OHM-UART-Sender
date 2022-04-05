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
using System.Threading;
using System.Management;
using System.Management.Instrumentation;
using System.IO.Ports;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;

namespace OHM_UART_Sender
{
    public partial class MainWindow : Window
    {
        public bool running;
        public Thread t;
        public MainWindow()
        {
            running = false;
            InitializeComponent();
            Button_Start_Stop.Content = "Start";
        }

        private void Button_Start_Stop_Click(object sender, RoutedEventArgs e)
        {
            if (this.running)
            {
                Button_Start_Stop.Content = "Start";
                this.running = false;
                t.Abort();
                t = null;
            }
            else
            {
                Button_Start_Stop.Content = "Stop";
                this.running = true;
                if (t==null)
                {
                    string str1 = TextBox_COM_Port.Text;
                    Int32 int_1 = int.Parse(TextBox_BAUD_RATE.Text);
                    Int32 int_2 = int.Parse(TextBox_REFRESH_TIME.Text);
                    t = new Thread(() => Program.Main(str1, int_1, int_2));
                    t.Start();
                }
            }
        }
    }
}
