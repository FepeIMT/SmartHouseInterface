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

    public partial class SmartHouse : Form
    {

        byte[] buffer = { 0, 250};

        enum function {Update_Temp, Update_Leds}

        public SmartHouse()
        {
            InitializeComponent();

        }

        private void SecondFloor_Click(object sender, EventArgs e)
        {
            Form Second_Floor = new SecondFloor();
            Second_Floor.Show();

            this.Hide();
        }

        private void ButtonFirstFloor_Click(object sender, EventArgs e)
        {
            Form First_Floor = new FirstFloor();
            First_Floor.Show();

            this.Hide();

        }


        private void SmartHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            serialPort1.Open();
            serialPort1.Read(Temp, 0, 2);
            serialPort1.Close();
            */
         


        }



        private void SmartHouse_Activated(object sender, EventArgs e)
        {

        }
    }
}
