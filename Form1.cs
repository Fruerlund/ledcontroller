using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LED_Controller
{
    public partial class Form1 : Form
    {

        public SerialConnection serial = new SerialConnection();

        public Form1()
        {

            InitializeComponent();
            Console.SetOut(new MultiTextWriter(new ControlWriter(TEXTBOX_CONSOLE), Console.Out));


        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TEXTBOX_CONSOLE.SelectionStart = TEXTBOX_CONSOLE.Text.Length;
            TEXTBOX_CONSOLE.ScrollToCaret();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                String COM = BOX_COMPORTS.SelectedItem.ToString();
                int BAUD = int.Parse(BOX_BAUDRATE.SelectedItem.ToString());
                serial.openSerialConnection(COM, BAUD);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
      
        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            try
            {
                serial.closeSerialConnection();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }


        private void btnSend_Click(object sender, EventArgs e)
        {
     
            Button b = sender as Button;

            switch(b.Text)
            {
                case "RED":
                    serial.sendSerialData("4");
                    break;
                case "RED1":
                    serial.sendSerialData("8");
                    break;
                case "RED2":
                    serial.sendSerialData("12");
                    break;
                case "RED3":
                    serial.sendSerialData("16");
                    break;
                case "RED4":
                    serial.sendSerialData("20");
                    break;
                case "GREEN":
                    serial.sendSerialData("5");
                    break;
                case "GREEN1":
                    serial.sendSerialData("9");
                    break;
                case "GREEN2":
                    serial.sendSerialData("13");
                    break;
                case "GREEN3":
                    serial.sendSerialData("17");
                    break;
                case "GREEN4":
                    serial.sendSerialData("21");
                    break;
                case "BLUE":
                    serial.sendSerialData("6");
                    break;
                case "BLUE1":
                    serial.sendSerialData("10");
                    break;
                case "BLUE2":
                    serial.sendSerialData("14");
                    break;
                case "BLUE3":
                    serial.sendSerialData("18");
                    break;
                case "BLUE4":
                    serial.sendSerialData("22");
                    break;
                case "WHITE":
                    serial.sendSerialData("7");
                    break;
                case "OFF":
                    serial.sendSerialData("2");
                    break;
                case "ON":
                    serial.sendSerialData("3");
                    break;
                case "+":
                    serial.sendSerialData("0");
                    break;
                case "-":
                    serial.sendSerialData("1");
                    break;
                case "FLASH":
                    serial.sendSerialData("11");
                    break;
                case "STROBE":
                    serial.sendSerialData("15");
                    break;
                case "FADE":
                    serial.sendSerialData("19");
                    break;
                case "SMOOTH":
                    serial.sendSerialData("23");
                    break;
                default:
                    break;
            }
        }

    }
}
