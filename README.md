# Open Hardware Monitor UART Sender

Send your PC Information like CPU/GPU/RAM:

- Temperatures;
- Load;
- Frequencies; or
- or anything Open Hardware Monitor can access

through a Serial Port to send to a smart device like a Microcontroller like Arduino or a Computer like a Raspberry Pi using a minimal GUI made in WPF:

<p align="center">
  <img src="media\WPF.png">
</p>

# How does it work?

OHM UART Sender gets information from OpenHardwareMonitor through:
- OpenHardwareMonitor.dll; and
- OpenHardwareMonitorLib.dll.

Those libraries have had its sizes decreased and codes simplified in order to have a more lightweight application, you can build them with this repository by compiling its entire solution or its project individually.

# Requirements

## Building

To build OHM UART Sender it is necessary to have:

- [.NET Framework 4.5](https://www.microsoft.com/pt-br/download/details.aspx?id=30653 ".NET Framework 4.5"); and
- A C# IDE (like Visual Studio Community).

## Usage

- Start Application;
- Enter Serial Port (COM), Baud Rate and Refresh Time (in ms); and
- Click Start.

OHM UART Sender will automatically send the first GPU Temperature it finds.

If you want to send another information, recompile the Application modifying ` GetSystemInfo() ` function in `OpenHardwareMonitor` assembly.

# Support

Send an e-mail to chandler.kluser@gmail.com.

Do not forget to leave a start to the project!