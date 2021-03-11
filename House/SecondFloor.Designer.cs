
namespace House
{
    partial class SecondFloor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondFloor));
            this.buttonRoom1 = new System.Windows.Forms.Button();
            this.buttonRoom2 = new System.Windows.Forms.Button();
            this.buttonRoom3 = new System.Windows.Forms.Button();
            this.buttonBathRoom = new System.Windows.Forms.Button();
            this.buttonFAN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPortFloor2 = new System.IO.Ports.SerialPort(this.components);
            this.TempValue = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTextFan = new System.Windows.Forms.Label();
            this.comboBoxSelectorMode = new System.Windows.Forms.ComboBox();
            this.UpdateTemp = new System.Windows.Forms.Timer(this.components);
            this.SetMaxTemp = new System.Windows.Forms.TextBox();
            this.SetTemp = new System.Windows.Forms.Button();
            this.DefaultTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRoom1
            // 
            this.buttonRoom1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRoom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom1.Location = new System.Drawing.Point(595, 157);
            this.buttonRoom1.Name = "buttonRoom1";
            this.buttonRoom1.Size = new System.Drawing.Size(143, 35);
            this.buttonRoom1.TabIndex = 1;
            this.buttonRoom1.Text = "Bed Room 1";
            this.buttonRoom1.UseVisualStyleBackColor = false;
            this.buttonRoom1.Click += new System.EventHandler(this.buttonRoom1_Click);
            // 
            // buttonRoom2
            // 
            this.buttonRoom2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRoom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom2.Location = new System.Drawing.Point(595, 225);
            this.buttonRoom2.Name = "buttonRoom2";
            this.buttonRoom2.Size = new System.Drawing.Size(143, 35);
            this.buttonRoom2.TabIndex = 2;
            this.buttonRoom2.Text = "Bed Room 2";
            this.buttonRoom2.UseVisualStyleBackColor = false;
            this.buttonRoom2.Click += new System.EventHandler(this.buttonRoom2_Click);
            // 
            // buttonRoom3
            // 
            this.buttonRoom3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRoom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom3.Location = new System.Drawing.Point(595, 289);
            this.buttonRoom3.Name = "buttonRoom3";
            this.buttonRoom3.Size = new System.Drawing.Size(143, 35);
            this.buttonRoom3.TabIndex = 3;
            this.buttonRoom3.Text = "Bed Room 3";
            this.buttonRoom3.UseVisualStyleBackColor = false;
            this.buttonRoom3.Click += new System.EventHandler(this.buttonRoom3_Click);
            // 
            // buttonBathRoom
            // 
            this.buttonBathRoom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBathRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBathRoom.Location = new System.Drawing.Point(595, 357);
            this.buttonBathRoom.Name = "buttonBathRoom";
            this.buttonBathRoom.Size = new System.Drawing.Size(143, 35);
            this.buttonBathRoom.TabIndex = 4;
            this.buttonBathRoom.Text = "Bathroom 2";
            this.buttonBathRoom.UseVisualStyleBackColor = false;
            this.buttonBathRoom.Click += new System.EventHandler(this.buttonBathRoom_Click);
            // 
            // buttonFAN
            // 
            this.buttonFAN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonFAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFAN.Location = new System.Drawing.Point(595, 422);
            this.buttonFAN.Name = "buttonFAN";
            this.buttonFAN.Size = new System.Drawing.Size(143, 35);
            this.buttonFAN.TabIndex = 5;
            this.buttonFAN.Text = "FAN";
            this.buttonFAN.UseVisualStyleBackColor = false;
            this.buttonFAN.Click += new System.EventHandler(this.buttonFAN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperature (°C)";
            // 
            // serialPortFloor2
            // 
            this.serialPortFloor2.BaudRate = 209700;
            this.serialPortFloor2.PortName = "COM3";
            this.serialPortFloor2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TempValue
            // 
            this.TempValue.AutoSize = true;
            this.TempValue.BackColor = System.Drawing.Color.Transparent;
            this.TempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempValue.Location = new System.Drawing.Point(640, 33);
            this.TempValue.Name = "TempValue";
            this.TempValue.Size = new System.Drawing.Size(153, 108);
            this.TempValue.TabIndex = 7;
            this.TempValue.Text = "20";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(45, 33);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(121, 36);
            this.Return.TabIndex = 8;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // LabelTextFan
            // 
            this.LabelTextFan.AutoSize = true;
            this.LabelTextFan.BackColor = System.Drawing.Color.Transparent;
            this.LabelTextFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextFan.Location = new System.Drawing.Point(299, 9);
            this.LabelTextFan.Name = "LabelTextFan";
            this.LabelTextFan.Size = new System.Drawing.Size(175, 24);
            this.LabelTextFan.TabIndex = 10;
            this.LabelTextFan.Text = "Select Mode FAN";
            // 
            // comboBoxSelectorMode
            // 
            this.comboBoxSelectorMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectorMode.FormattingEnabled = true;
            this.comboBoxSelectorMode.Items.AddRange(new object[] {
            "Automatic Mode",
            "Manual Mode"});
            this.comboBoxSelectorMode.Location = new System.Drawing.Point(300, 33);
            this.comboBoxSelectorMode.Name = "comboBoxSelectorMode";
            this.comboBoxSelectorMode.Size = new System.Drawing.Size(174, 28);
            this.comboBoxSelectorMode.TabIndex = 11;
            this.comboBoxSelectorMode.Text = "Automatic Mode";
            this.comboBoxSelectorMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectorMode_SelectedIndexChanged);
            // 
            // UpdateTemp
            // 
            this.UpdateTemp.Enabled = true;
            this.UpdateTemp.Interval = 2000;
            this.UpdateTemp.Tick += new System.EventHandler(this.UpdateTemp_Tick);
            // 
            // SetMaxTemp
            // 
            this.SetMaxTemp.Location = new System.Drawing.Point(301, 71);
            this.SetMaxTemp.Name = "SetMaxTemp";
            this.SetMaxTemp.Size = new System.Drawing.Size(68, 20);
            this.SetMaxTemp.TabIndex = 12;
            this.SetMaxTemp.Text = "28";
            // 
            // SetTemp
            // 
            this.SetTemp.Location = new System.Drawing.Point(375, 71);
            this.SetTemp.Name = "SetTemp";
            this.SetTemp.Size = new System.Drawing.Size(99, 23);
            this.SetTemp.TabIndex = 13;
            this.SetTemp.Text = "Set Temp Max";
            this.SetTemp.UseVisualStyleBackColor = true;
            this.SetTemp.Click += new System.EventHandler(this.SetTemp_Click);
            // 
            // DefaultTemp
            // 
            this.DefaultTemp.Location = new System.Drawing.Point(375, 106);
            this.DefaultTemp.Name = "DefaultTemp";
            this.DefaultTemp.Size = new System.Drawing.Size(99, 23);
            this.DefaultTemp.TabIndex = 14;
            this.DefaultTemp.Text = "Default 28 °C";
            this.DefaultTemp.UseVisualStyleBackColor = true;
            this.DefaultTemp.Click += new System.EventHandler(this.DefaultTemp_Click);
            // 
            // SecondFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 513);
            this.Controls.Add(this.DefaultTemp);
            this.Controls.Add(this.SetTemp);
            this.Controls.Add(this.SetMaxTemp);
            this.Controls.Add(this.comboBoxSelectorMode);
            this.Controls.Add(this.LabelTextFan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.TempValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFAN);
            this.Controls.Add(this.buttonBathRoom);
            this.Controls.Add(this.buttonRoom3);
            this.Controls.Add(this.buttonRoom2);
            this.Controls.Add(this.buttonRoom1);
            this.Name = "SecondFloor";
            this.Text = "SecondFloor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondFloor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoom1;
        private System.Windows.Forms.Button buttonRoom2;
        private System.Windows.Forms.Button buttonRoom3;
        private System.Windows.Forms.Button buttonBathRoom;
        private System.Windows.Forms.Button buttonFAN;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPortFloor2;
        private System.Windows.Forms.Label TempValue;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTextFan;
        private System.Windows.Forms.ComboBox comboBoxSelectorMode;
        private System.Windows.Forms.Timer UpdateTemp;
        private System.Windows.Forms.TextBox SetMaxTemp;
        private System.Windows.Forms.Button SetTemp;
        private System.Windows.Forms.Button DefaultTemp;
    }
}