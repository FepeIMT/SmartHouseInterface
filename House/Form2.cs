using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class FirstFloor : Form
    {
        byte[] buffer = { 0, 0 };
        int[] Led_Status = new int[] { 0, 0, 0, 0 };

        enum elements 
        {
            BATHROOM1,
            KITCHEN,
            GARDEN,
            LIVINGROOM
        };

        enum info {COMMAND, DATA};

        enum function { Update_Temp, Update_Leds, Data_Requested};

        enum options { Change_State, Request_FirstFloor, Request_SecondFloor}
        enum status
        {
            APAGADO = 0,
            ENCENDIDO,
            ROOM1_ON,
            ROOM1_OFF,
            ROOM2_ON,
            ROOM2_OFF,
            ROOM3_ON,
            ROOM3_OFF,
            BATHROOM1_ON,
            BATHROOM1_OFF,
            BATHROOM2_ON,
            BATHROOM2_OFF,
            KITCHEN_ON,
            KITCHEN_OFF,
            GARDEN_ON,
            GARDEN_OFF,
            LIVINGROOM_ON,
            LIVINGROOM_OFF,
            FAN_ON,
            FAN_OFF
        };
        public FirstFloor()
        {
            InitializeComponent();
            serialPortFloor1.Open();
            buffer[(int)info.COMMAND] = (int)options.Request_FirstFloor;
            serialPortFloor1.Write(buffer, 0, 2);
        }

        private void buttonBathroom_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if(Led_Status[(int)elements.BATHROOM1] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.BATHROOM1_ON;
                serialPortFloor1.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.BATHROOM1_OFF;
                serialPortFloor1.Write(buffer, 0, 2);
            }
        }

        private void FirstFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.principal.Show();
            serialPortFloor1.Close();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            serialPortFloor1.Close();
            Program.principal.Show();
            Close();
        }

        private void serialPortFloor1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPortFloor1.Read(buffer, 0, 2);
            if(buffer[(int)info.COMMAND] == (int)function.Update_Temp)
            {
                this.Invoke(new EventHandler(ShowData));
            }
            else if(buffer[(int)info.COMMAND] == (int)function.Update_Leds)
            {
                this.Invoke(new EventHandler(UpdateLeds));
            }
            else if(buffer[(int)info.COMMAND] == (int)function.Data_Requested)
            {
                this.Invoke(new EventHandler(UpdateButtonColors));
            }

        }

        private void UpdateButtonColors(object sender, EventArgs e)
        {
            switch((int)buffer[(int)info.DATA])
            {
                case (int)status.BATHROOM1_ON:
                    this.buttonBathroom.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.BATHROOM1] = (int)status.ENCENDIDO;
                    break;
                case (int)status.KITCHEN_ON:
                    this.buttonKitchen.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.KITCHEN] = (int)status.ENCENDIDO;
                    break;
                case (int)status.GARDEN_ON:
                    this.buttonGarden.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.GARDEN] = (int)status.ENCENDIDO;
                    break;
                case (int)status.LIVINGROOM_ON:
                    this.buttonLivingRoom.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.LIVINGROOM] = (int)status.ENCENDIDO;
                    break;
                default:
                    break;
            }
        }

        private void UpdateLeds(object sender, EventArgs e)
        {
            switch ((int)buffer[(int)info.DATA])
            {
                case (int)status.BATHROOM1_ON:
                    MessageBox.Show("Bathroom On");
                    Led_Status[(int)elements.BATHROOM1] = (int)status.ENCENDIDO;
                    this.buttonBathroom.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.BATHROOM1_OFF:
                    MessageBox.Show("Bathroom Off");
                    Led_Status[(int)elements.BATHROOM1] = (int)status.APAGADO;
                    this.buttonBathroom.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.KITCHEN_ON:
                    MessageBox.Show("Kitchen On");
                    Led_Status[(int)elements.KITCHEN] = (int)status.ENCENDIDO;
                    this.buttonKitchen.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.KITCHEN_OFF:
                    MessageBox.Show("Kitchen Off");
                    Led_Status[(int)elements.KITCHEN] = (int)status.APAGADO;
                    this.buttonKitchen.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.GARDEN_ON:
                    MessageBox.Show("Garden On");
                    Led_Status[(int)elements.GARDEN] = (int)status.ENCENDIDO;
                    this.buttonGarden.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.GARDEN_OFF:
                    MessageBox.Show("Garden Off");
                    Led_Status[(int)elements.GARDEN] = (int)status.APAGADO;
                    this.buttonGarden.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.LIVINGROOM_ON:
                    MessageBox.Show("Living Room On");
                    Led_Status[(int)elements.LIVINGROOM] = (int)status.ENCENDIDO;
                    this.buttonLivingRoom.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.LIVINGROOM_OFF:
                    MessageBox.Show("Living Room Off");
                    Led_Status[(int)elements.LIVINGROOM] = (int)status.APAGADO;
                    this.buttonLivingRoom.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                default:
                    break;                
            }
        }

        private void ShowData(object sender, EventArgs e)
        {
            TempFloor1.Text = buffer[(int)info.DATA].ToString();
        }

        private void buttonKitchen_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.KITCHEN] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.KITCHEN_ON;
                serialPortFloor1.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.KITCHEN_OFF;
                serialPortFloor1.Write(buffer, 0, 2);
            }
        }

        private void buttonGarden_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.GARDEN] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.GARDEN_ON;
                serialPortFloor1.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.GARDEN_OFF;
                serialPortFloor1.Write(buffer, 0, 2);
            }
        }

        private void buttonLivingRoom_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.LIVINGROOM] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.LIVINGROOM_ON;
                serialPortFloor1.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.LIVINGROOM_OFF;
                serialPortFloor1.Write(buffer, 0, 2);
            }
        }
    }
}
