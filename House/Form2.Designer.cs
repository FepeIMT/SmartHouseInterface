
namespace House
{
    partial class FirstFloor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstFloor));
            this.buttonBathroom = new System.Windows.Forms.Button();
            this.buttonKitchen = new System.Windows.Forms.Button();
            this.buttonGarden = new System.Windows.Forms.Button();
            this.buttonLivingRoom = new System.Windows.Forms.Button();
            this.serialPortFloor1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TempFloor1 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBathroom
            // 
            this.buttonBathroom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBathroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBathroom.Location = new System.Drawing.Point(626, 179);
            this.buttonBathroom.Name = "buttonBathroom";
            this.buttonBathroom.Size = new System.Drawing.Size(143, 35);
            this.buttonBathroom.TabIndex = 0;
            this.buttonBathroom.Text = "Bathroom";
            this.buttonBathroom.UseVisualStyleBackColor = false;
            this.buttonBathroom.Click += new System.EventHandler(this.buttonBathroom_Click);
            // 
            // buttonKitchen
            // 
            this.buttonKitchen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKitchen.Location = new System.Drawing.Point(626, 245);
            this.buttonKitchen.Name = "buttonKitchen";
            this.buttonKitchen.Size = new System.Drawing.Size(143, 35);
            this.buttonKitchen.TabIndex = 1;
            this.buttonKitchen.Text = "Kitchen";
            this.buttonKitchen.UseVisualStyleBackColor = false;
            this.buttonKitchen.Click += new System.EventHandler(this.buttonKitchen_Click);
            // 
            // buttonGarden
            // 
            this.buttonGarden.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGarden.Location = new System.Drawing.Point(626, 312);
            this.buttonGarden.Name = "buttonGarden";
            this.buttonGarden.Size = new System.Drawing.Size(143, 35);
            this.buttonGarden.TabIndex = 2;
            this.buttonGarden.Text = "Garden";
            this.buttonGarden.UseVisualStyleBackColor = false;
            this.buttonGarden.Click += new System.EventHandler(this.buttonGarden_Click);
            // 
            // buttonLivingRoom
            // 
            this.buttonLivingRoom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonLivingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLivingRoom.Location = new System.Drawing.Point(626, 378);
            this.buttonLivingRoom.Name = "buttonLivingRoom";
            this.buttonLivingRoom.Size = new System.Drawing.Size(143, 35);
            this.buttonLivingRoom.TabIndex = 3;
            this.buttonLivingRoom.Text = "Living Room";
            this.buttonLivingRoom.UseVisualStyleBackColor = false;
            this.buttonLivingRoom.Click += new System.EventHandler(this.buttonLivingRoom_Click);
            // 
            // serialPortFloor1
            // 
            this.serialPortFloor1.BaudRate = 209700;
            this.serialPortFloor1.PortName = "COM3";
            this.serialPortFloor1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortFloor1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperature (°C)";
            // 
            // TempFloor1
            // 
            this.TempFloor1.AutoSize = true;
            this.TempFloor1.BackColor = System.Drawing.Color.Transparent;
            this.TempFloor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempFloor1.Location = new System.Drawing.Point(309, 300);
            this.TempFloor1.Name = "TempFloor1";
            this.TempFloor1.Size = new System.Drawing.Size(153, 108);
            this.TempFloor1.TabIndex = 5;
            this.TempFloor1.Text = "20";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(37, 35);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(121, 36);
            this.Return.TabIndex = 6;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // FirstFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 513);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.TempFloor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLivingRoom);
            this.Controls.Add(this.buttonGarden);
            this.Controls.Add(this.buttonKitchen);
            this.Controls.Add(this.buttonBathroom);
            this.Name = "FirstFloor";
            this.Text = "First Floor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstFloor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBathroom;
        private System.Windows.Forms.Button buttonKitchen;
        private System.Windows.Forms.Button buttonGarden;
        private System.Windows.Forms.Button buttonLivingRoom;
        private System.IO.Ports.SerialPort serialPortFloor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TempFloor1;
        private System.Windows.Forms.Button Return;
    }
}