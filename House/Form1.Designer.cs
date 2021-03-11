
namespace House
{
    partial class SmartHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartHouse));
            this.Title = new System.Windows.Forms.Label();
            this.ButtonSecondFloor = new System.Windows.Forms.Button();
            this.ButtonFirstFloor = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Rockwell", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(246, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(315, 79);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome";
            // 
            // ButtonSecondFloor
            // 
            this.ButtonSecondFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonSecondFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSecondFloor.Location = new System.Drawing.Point(319, 250);
            this.ButtonSecondFloor.Name = "ButtonSecondFloor";
            this.ButtonSecondFloor.Size = new System.Drawing.Size(200, 56);
            this.ButtonSecondFloor.TabIndex = 1;
            this.ButtonSecondFloor.Text = "Second Floor";
            this.ButtonSecondFloor.UseVisualStyleBackColor = false;
            this.ButtonSecondFloor.Click += new System.EventHandler(this.SecondFloor_Click);
            // 
            // ButtonFirstFloor
            // 
            this.ButtonFirstFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonFirstFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFirstFloor.Location = new System.Drawing.Point(319, 366);
            this.ButtonFirstFloor.Name = "ButtonFirstFloor";
            this.ButtonFirstFloor.Size = new System.Drawing.Size(200, 56);
            this.ButtonFirstFloor.TabIndex = 2;
            this.ButtonFirstFloor.Text = "First Floor";
            this.ButtonFirstFloor.UseVisualStyleBackColor = false;
            this.ButtonFirstFloor.Click += new System.EventHandler(this.ButtonFirstFloor_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 209700;
            this.serialPort1.PortName = "COM3";

            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SmartHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 513);
            this.Controls.Add(this.ButtonFirstFloor);
            this.Controls.Add(this.ButtonSecondFloor);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SmartHouse";
            this.Text = "Smart House";
            this.Activated += new System.EventHandler(this.SmartHouse_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartHouse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonSecondFloor;
        private System.Windows.Forms.Button ButtonFirstFloor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

