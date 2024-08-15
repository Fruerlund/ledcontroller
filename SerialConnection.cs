using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace LED_Controller
{
    public class SerialConnection
    {


        public string data;
        public static bool _continue;
        public static SerialPort serial;
        public static bool connected = false;
        Thread sendThread = null;

        // Constructor
        public SerialConnection()
        {
            serial = new SerialPort();
        }


        public void openSerialConnection(String COM, int BAUD)
        {

            if (connected)
            {
                return;
            }

            try
            {

                setupSerialConnection(COM, BAUD);
                serial.Open();

                _continue = true;

                WaitForOKResponse();

                //sendThread = new Thread(sendSerialData);
                //endThread.Start();
                
                connected = true;

                Console.WriteLine("Opened serial connection");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        static void WaitForOKResponse()
        {
            Console.WriteLine("Waiting for OK Signal from Arduino");
            while (true)
            {
                try {
                    string response = serial.ReadLine();
                    Console.WriteLine(response);
                    if (response.Contains("OK"))
                    {
                        Console.WriteLine("Received 'OK' from Arduino. Proceeding...");
                        break; // Exit the loop when "OK\r\n" is received
                 }
                }
                catch( Exception e )
                {
                  
                }
            }
        }


        public void sendSerialData(string data)
        {
            if (connected == false)
            {
                Console.WriteLine("Please establish serial connection first");
                return;
            }

            Console.WriteLine("sendSerialData: " + data);
            string command = data + "\n";
            serial.Write(command);
            
            
        }



        public void closeSerialConnection()
        {
            if(connected == false)
            {
                return;
            }

            try
            {
                _continue = false;
                connected = false;
                serial.Close();
                Console.WriteLine("Closed serial connection");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void setupSerialConnection(String COM, int BAUD)
        {

            if(serial == null) { return; }

            serial.PortName = COM;
            serial.BaudRate = BAUD;
            serial.DataBits = 8;
            serial.Parity = Parity.None;
            serial.Handshake = Handshake.None;
            serial.ReadTimeout = 1000;
            serial.DtrEnable = true;
            serial.RtsEnable = true;

            Console.WriteLine("Setup OK!");

        }



    }
}
