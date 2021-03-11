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
    public partial class SecondFloor : Form
    {
        byte[] buffer = { 0, 0 };
        int[] Led_Status = new int[] {0, 0, 0, 0, 0 };
        int temp_LM35;
        int temp_Max = 28;
        string temperature;
        enum elements
        {
            ROOM1,
            ROOM2,
            ROOM3,
            BATHROOM2,
            FAN
        };
        enum info { COMMAND, DATA };
        enum function { Update_Temp, Update_Leds, Data_Requested};
        enum options { Change_State, Request_FirstFloor, Request_SecondFloor, Automatic_Mode, Manual_Mode};

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
        public SecondFloor()
        {
            InitializeComponent();
            serialPortFloor2.Open();
            buffer[(int)info.COMMAND] = (int)options.Request_SecondFloor;
            serialPortFloor2.Write(buffer, 0, 2);
            this.buttonFAN.Enabled = false;
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if(Led_Status[(int)elements.ROOM1] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.ROOM1_ON;
                serialPortFloor2.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.ROOM1_OFF;
                serialPortFloor2.Write(buffer, 0, 2);
            }
        }
        
        private void Return_Click(object sender, EventArgs e)
        {
            serialPortFloor2.Close();
            Program.principal.Show();
            Close();

        }

        private void SecondFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.principal.Show();
            serialPortFloor2.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPortFloor2.Read(buffer, 0, 2);
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
                this.Invoke(new EventHandler(UpdateColorButtons));
            }
        }

        private void UpdateColorButtons(object sender, EventArgs e)
        {
            switch((int)buffer[(int)info.DATA])
            {
                case (int)status.ROOM1_ON:
                    this.buttonRoom1.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.ROOM1] = (int)status.ENCENDIDO;
                    break;
                case (int)status.ROOM2_ON:
                    this.buttonRoom2.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.ROOM2] = (int)status.ENCENDIDO;
                    break;
                case (int)status.ROOM3_ON:
                    this.buttonRoom3.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.ROOM3] = (int)status.ENCENDIDO;
                    break;
                case (int)status.BATHROOM2_ON:
                    this.buttonBathRoom.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.BATHROOM2] = (int)status.ENCENDIDO;
                    break;
                case (int)status.FAN_ON:
                    this.buttonFAN.BackColor = System.Drawing.SystemColors.Info;
                    Led_Status[(int)elements.FAN] = (int)status.ENCENDIDO;
                    break;
                default:
                    break;
            }
        }

        private void UpdateLeds(object sender, EventArgs e)
        {
            switch ((int)buffer[1])
            {
                case (int)status.ROOM1_ON:
                    MessageBox.Show("Room 1 On");
                    Led_Status[(int)elements.ROOM1] = (int)status.ENCENDIDO;
                    this.buttonRoom1.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.ROOM1_OFF:
                    Led_Status[(int)elements.ROOM1] = (int)status.APAGADO;
                    MessageBox.Show("Room 1 Off");
                    this.buttonRoom1.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.ROOM2_ON:
                    MessageBox.Show("Room 2 On");
                    Led_Status[(int)elements.ROOM2] = (int)status.ENCENDIDO;
                    this.buttonRoom2.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.ROOM2_OFF:
                    MessageBox.Show("Room 2 Off");
                    Led_Status[(int)elements.ROOM2] = (int)status.APAGADO;
                    this.buttonRoom2.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.ROOM3_ON:
                    MessageBox.Show("Room 3 On");
                    Led_Status[(int)elements.ROOM3] = (int)status.ENCENDIDO;
                    this.buttonRoom3.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.ROOM3_OFF:
                    MessageBox.Show("Room 3 Off");
                    Led_Status[(int)elements.ROOM3] = (int)status.APAGADO;
                    this.buttonRoom3.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.BATHROOM2_ON:
                    MessageBox.Show("Bathroom 2 On");
                    Led_Status[(int)elements.BATHROOM2] = (int)status.ENCENDIDO;
                    this.buttonBathRoom.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.BATHROOM2_OFF:
                    MessageBox.Show("Bathroom 2 Off");
                    Led_Status[(int)elements.BATHROOM2] = (int)status.APAGADO;
                    this.buttonBathRoom.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                case (int)status.FAN_ON:
                    MessageBox.Show("Fan On");
                    Led_Status[(int)elements.FAN] = (int)status.ENCENDIDO;
                    this.buttonFAN.BackColor = System.Drawing.SystemColors.Info;
                    break;
                case (int)status.FAN_OFF:
                    MessageBox.Show("Fan Off");
                    Led_Status[(int)elements.FAN] = (int)status.APAGADO;
                    this.buttonFAN.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    break;
                default:
                    break;
            }


        }

        private void ShowData(object sender, EventArgs e)
        {
            temp_LM35 = buffer[(int)info.DATA];
        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.ROOM2] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.ROOM2_ON;
                serialPortFloor2.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.ROOM2_OFF;
                serialPortFloor2.Write(buffer, 0, 2);
            }
        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.ROOM3] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.ROOM3_ON;
                serialPortFloor2.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.ROOM3_OFF;
                serialPortFloor2.Write(buffer, 0, 2);
            }
        }

        private void buttonBathRoom_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.BATHROOM2] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.BATHROOM2_ON;
                serialPortFloor2.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.BATHROOM2_OFF;
                serialPortFloor2.Write(buffer, 0, 2);
            }
        }

        private void buttonFAN_Click(object sender, EventArgs e)
        {
            buffer[(int)info.COMMAND] = (int)options.Change_State;
            if (Led_Status[(int)elements.FAN] == (int)status.APAGADO)
            {
                buffer[(int)info.DATA] = (int)status.FAN_ON;
                serialPortFloor2.Write(buffer, 0, 2);
            }
            else
            {
                buffer[(int)info.DATA] = (int)status.FAN_OFF;
                serialPortFloor2.Write(buffer, 0, 2);
            }
        }

        private void comboBoxSelectorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectorMode.SelectedIndex == (int)options.Automatic_Mode - 3)
            {
                buffer[(int)info.COMMAND] = (int)options.Automatic_Mode;
                serialPortFloor2.Write(buffer, 0, 2);
                this.buttonFAN.Enabled = false;
            }
            else if(comboBoxSelectorMode.SelectedIndex == (int)options.Manual_Mode - 3)
            {
                buffer[(int)info.COMMAND] = (int)options.Manual_Mode;
                serialPortFloor2.Write(buffer, 0, 2);
                this.buttonFAN.Enabled = true;
            }
        }

        private void UpdateTemp_Tick(object sender, EventArgs e)
        {
            TempValue.Text = temp_LM35.ToString();
            if(comboBoxSelectorMode.SelectedIndex ==  (int)options.Automatic_Mode -3)
            {
                buffer[(int)info.COMMAND] = (int)options.Change_State;
                if(temp_LM35 > temp_Max && Led_Status[(int)elements.FAN] == (int)status.APAGADO)
                {
                    buffer[(int)info.DATA] = (int)status.FAN_ON;
                    serialPortFloor2.Write(buffer, 0, 2);
                }
                else if(temp_LM35 <= temp_Max && Led_Status[(int)elements.FAN] == (int)status.ENCENDIDO)
                {
                    buffer[(int)info.DATA] = (int)status.FAN_OFF;
                    serialPortFloor2.Write(buffer, 0, 2);
                }
            }

        }

        private void DefaultTemp_Click(object sender, EventArgs e)
        {
            temp_Max = 28;
        }

        private void SetTemp_Click(object sender, EventArgs e)
        {
            int intdata = 0;
            double doubledata = 0.0;
            if (this.SetMaxTemp.Text == string.Empty)
            {
                MessageBox.Show("Insert Data");
            }
            else if (int.TryParse(this.SetMaxTemp.Text, out intdata))
            {
                temp_Max = intdata;

            }
            else if(double.TryParse(this.SetMaxTemp.Text, out doubledata))
            {
                //temp_Max = Convert.ToInt32(this.SetMaxTemp.Text);
                MessageBox.Show("Invalid Data");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }
    }
}
