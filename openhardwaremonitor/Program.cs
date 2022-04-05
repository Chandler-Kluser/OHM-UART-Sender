using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using System.IO.Ports;


namespace OpenHardwareMonitor {
  public static class Program {

    [STAThread]
    public static String GetSystemInfo() {
      Computer computer = new Computer();
      computer.GPUEnabled = true;
      computer.Open();
      String aux = computer.Hardware[0].Sensors[0].Value.ToString();
      computer.Close();
      return aux;
    }
    public static void Main(String COM_PORT, Int32 BAUD_RATE, Int32 REFRESH_TIME) {
      SerialPort port = new SerialPort(COM_PORT, BAUD_RATE, Parity.None, 8, StopBits.One);
      String str = null;
      port.Encoding = System.Text.Encoding.UTF8;
      while (true) {
        port.Open();
        str = GetSystemInfo();
        port.Write(str);
        port.Close();
        Thread.Sleep(REFRESH_TIME);
      }
    }
  }
}
