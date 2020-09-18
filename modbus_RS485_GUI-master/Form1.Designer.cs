namespace modbus
{
    partial class Form1
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
            this.grb_COMportControl = new System.Windows.Forms.GroupBox();
            this.cmb_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ParityBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ComportNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grb_COMportStatus = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Open = new System.Windows.Forms.Button();
            this.grb_RelayControl = new System.Windows.Forms.GroupBox();
            this.btn_ctrl_rly4 = new System.Windows.Forms.Button();
            this.btn_ctrl_rly3 = new System.Windows.Forms.Button();
            this.btn_ctrl_rly2 = new System.Windows.Forms.Button();
            this.btn_ctrl_rly1 = new System.Windows.Forms.Button();
            this.txt_sta_rly4 = new System.Windows.Forms.TextBox();
            this.txt_sta_rly3 = new System.Windows.Forms.TextBox();
            this.txt_sta_rly2 = new System.Windows.Forms.TextBox();
            this.txt_sta_rly1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grb_COMportControl.SuspendLayout();
            this.grb_COMportStatus.SuspendLayout();
            this.grb_RelayControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_COMportControl
            // 
            this.grb_COMportControl.Controls.Add(this.cmb_StopBits);
            this.grb_COMportControl.Controls.Add(this.label5);
            this.grb_COMportControl.Controls.Add(this.cmb_ParityBit);
            this.grb_COMportControl.Controls.Add(this.label4);
            this.grb_COMportControl.Controls.Add(this.cmb_DataBits);
            this.grb_COMportControl.Controls.Add(this.label3);
            this.grb_COMportControl.Controls.Add(this.cmb_Baudrate);
            this.grb_COMportControl.Controls.Add(this.label2);
            this.grb_COMportControl.Controls.Add(this.cmb_ComportNo);
            this.grb_COMportControl.Controls.Add(this.label1);
            this.grb_COMportControl.Location = new System.Drawing.Point(20, 20);
            this.grb_COMportControl.Name = "grb_COMportControl";
            this.grb_COMportControl.Size = new System.Drawing.Size(240, 170);
            this.grb_COMportControl.TabIndex = 0;
            this.grb_COMportControl.TabStop = false;
            this.grb_COMportControl.Text = "COM port control";
            // 
            // cmb_StopBits
            // 
            this.cmb_StopBits.FormattingEnabled = true;
            this.cmb_StopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cmb_StopBits.Location = new System.Drawing.Point(107, 135);
            this.cmb_StopBits.Name = "cmb_StopBits";
            this.cmb_StopBits.Size = new System.Drawing.Size(105, 21);
            this.cmb_StopBits.TabIndex = 8;
            this.cmb_StopBits.Text = "One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop Bits";
            // 
            // cmb_ParityBit
            // 
            this.cmb_ParityBit.FormattingEnabled = true;
            this.cmb_ParityBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmb_ParityBit.Location = new System.Drawing.Point(107, 108);
            this.cmb_ParityBit.Name = "cmb_ParityBit";
            this.cmb_ParityBit.Size = new System.Drawing.Size(105, 21);
            this.cmb_ParityBit.TabIndex = 6;
            this.cmb_ParityBit.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity Bit";
            // 
            // cmb_DataBits
            // 
            this.cmb_DataBits.FormattingEnabled = true;
            this.cmb_DataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cmb_DataBits.Location = new System.Drawing.Point(107, 81);
            this.cmb_DataBits.Name = "cmb_DataBits";
            this.cmb_DataBits.Size = new System.Drawing.Size(105, 21);
            this.cmb_DataBits.TabIndex = 4;
            this.cmb_DataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Bits";
            // 
            // cmb_Baudrate
            // 
            this.cmb_Baudrate.FormattingEnabled = true;
            this.cmb_Baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_Baudrate.Location = new System.Drawing.Point(107, 54);
            this.cmb_Baudrate.Name = "cmb_Baudrate";
            this.cmb_Baudrate.Size = new System.Drawing.Size(105, 21);
            this.cmb_Baudrate.TabIndex = 2;
            this.cmb_Baudrate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate [bps]";
            // 
            // cmb_ComportNo
            // 
            this.cmb_ComportNo.FormattingEnabled = true;
            this.cmb_ComportNo.Location = new System.Drawing.Point(107, 27);
            this.cmb_ComportNo.Name = "cmb_ComportNo";
            this.cmb_ComportNo.Size = new System.Drawing.Size(105, 21);
            this.cmb_ComportNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port no";
            // 
            // grb_COMportStatus
            // 
            this.grb_COMportStatus.Controls.Add(this.progressBar1);
            this.grb_COMportStatus.Controls.Add(this.btn_Open);
            this.grb_COMportStatus.Location = new System.Drawing.Point(20, 196);
            this.grb_COMportStatus.Name = "grb_COMportStatus";
            this.grb_COMportStatus.Size = new System.Drawing.Size(240, 60);
            this.grb_COMportStatus.TabIndex = 1;
            this.grb_COMportStatus.TabStop = false;
            this.grb_COMportStatus.Text = "COM port status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(105, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(23, 19);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(67, 26);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // grb_RelayControl
            // 
            this.grb_RelayControl.Controls.Add(this.btn_ctrl_rly4);
            this.grb_RelayControl.Controls.Add(this.btn_ctrl_rly3);
            this.grb_RelayControl.Controls.Add(this.btn_ctrl_rly2);
            this.grb_RelayControl.Controls.Add(this.btn_ctrl_rly1);
            this.grb_RelayControl.Controls.Add(this.txt_sta_rly4);
            this.grb_RelayControl.Controls.Add(this.txt_sta_rly3);
            this.grb_RelayControl.Controls.Add(this.txt_sta_rly2);
            this.grb_RelayControl.Controls.Add(this.txt_sta_rly1);
            this.grb_RelayControl.Controls.Add(this.label11);
            this.grb_RelayControl.Controls.Add(this.label10);
            this.grb_RelayControl.Controls.Add(this.label9);
            this.grb_RelayControl.Controls.Add(this.label8);
            this.grb_RelayControl.Controls.Add(this.label7);
            this.grb_RelayControl.Controls.Add(this.label6);
            this.grb_RelayControl.Location = new System.Drawing.Point(278, 20);
            this.grb_RelayControl.Name = "grb_RelayControl";
            this.grb_RelayControl.Size = new System.Drawing.Size(258, 169);
            this.grb_RelayControl.TabIndex = 2;
            this.grb_RelayControl.TabStop = false;
            this.grb_RelayControl.Text = "Modbus Command Single Shot";
            // 
            // btn_ctrl_rly4
            // 
            this.btn_ctrl_rly4.Location = new System.Drawing.Point(177, 134);
            this.btn_ctrl_rly4.Name = "btn_ctrl_rly4";
            this.btn_ctrl_rly4.Size = new System.Drawing.Size(75, 23);
            this.btn_ctrl_rly4.TabIndex = 11;
            this.btn_ctrl_rly4.Text = "&4 ON";
            this.btn_ctrl_rly4.UseVisualStyleBackColor = true;
            this.btn_ctrl_rly4.Click += new System.EventHandler(this.btn_ctrl_rly4_Click);
            // 
            // btn_ctrl_rly3
            // 
            this.btn_ctrl_rly3.Location = new System.Drawing.Point(177, 106);
            this.btn_ctrl_rly3.Name = "btn_ctrl_rly3";
            this.btn_ctrl_rly3.Size = new System.Drawing.Size(75, 23);
            this.btn_ctrl_rly3.TabIndex = 10;
            this.btn_ctrl_rly3.Text = "&3 ON";
            this.btn_ctrl_rly3.UseVisualStyleBackColor = true;
            this.btn_ctrl_rly3.Click += new System.EventHandler(this.btn_ctrl_rly3_Click);
            // 
            // btn_ctrl_rly2
            // 
            this.btn_ctrl_rly2.Location = new System.Drawing.Point(177, 79);
            this.btn_ctrl_rly2.Name = "btn_ctrl_rly2";
            this.btn_ctrl_rly2.Size = new System.Drawing.Size(75, 23);
            this.btn_ctrl_rly2.TabIndex = 9;
            this.btn_ctrl_rly2.Text = "&2 ON";
            this.btn_ctrl_rly2.UseVisualStyleBackColor = true;
            this.btn_ctrl_rly2.Click += new System.EventHandler(this.btn_ctrl_rly2_Click);
            // 
            // btn_ctrl_rly1
            // 
            this.btn_ctrl_rly1.Location = new System.Drawing.Point(177, 52);
            this.btn_ctrl_rly1.Name = "btn_ctrl_rly1";
            this.btn_ctrl_rly1.Size = new System.Drawing.Size(75, 23);
            this.btn_ctrl_rly1.TabIndex = 8;
            this.btn_ctrl_rly1.Text = "&1 ON";
            this.btn_ctrl_rly1.UseVisualStyleBackColor = true;
            this.btn_ctrl_rly1.Click += new System.EventHandler(this.btn_ctrl_rly1_Click);
            // 
            // txt_sta_rly4
            // 
            this.txt_sta_rly4.Location = new System.Drawing.Point(64, 136);
            this.txt_sta_rly4.Name = "txt_sta_rly4";
            this.txt_sta_rly4.ReadOnly = true;
            this.txt_sta_rly4.Size = new System.Drawing.Size(107, 20);
            this.txt_sta_rly4.TabIndex = 7;
            // 
            // txt_sta_rly3
            // 
            this.txt_sta_rly3.Location = new System.Drawing.Point(64, 108);
            this.txt_sta_rly3.Name = "txt_sta_rly3";
            this.txt_sta_rly3.ReadOnly = true;
            this.txt_sta_rly3.Size = new System.Drawing.Size(107, 20);
            this.txt_sta_rly3.TabIndex = 7;
            // 
            // txt_sta_rly2
            // 
            this.txt_sta_rly2.Location = new System.Drawing.Point(64, 81);
            this.txt_sta_rly2.Name = "txt_sta_rly2";
            this.txt_sta_rly2.ReadOnly = true;
            this.txt_sta_rly2.Size = new System.Drawing.Size(107, 20);
            this.txt_sta_rly2.TabIndex = 7;
            // 
            // txt_sta_rly1
            // 
            this.txt_sta_rly1.Location = new System.Drawing.Point(64, 55);
            this.txt_sta_rly1.Name = "txt_sta_rly1";
            this.txt_sta_rly1.ReadOnly = true;
            this.txt_sta_rly1.Size = new System.Drawing.Size(107, 20);
            this.txt_sta_rly1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Relay 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Relay 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Relay 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Relay 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 272);
            this.Controls.Add(this.grb_RelayControl);
            this.Controls.Add(this.grb_COMportStatus);
            this.Controls.Add(this.grb_COMportControl);
            this.Name = "Form1";
            this.Text = "Modbus RTU RS-485";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_COMportControl.ResumeLayout(false);
            this.grb_COMportControl.PerformLayout();
            this.grb_COMportStatus.ResumeLayout(false);
            this.grb_RelayControl.ResumeLayout(false);
            this.grb_RelayControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_COMportControl;
        private System.Windows.Forms.ComboBox cmb_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ParityBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ComportNo;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grb_COMportStatus;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grb_RelayControl;
        private System.Windows.Forms.Button btn_ctrl_rly4;
        private System.Windows.Forms.Button btn_ctrl_rly3;
        private System.Windows.Forms.Button btn_ctrl_rly2;
        private System.Windows.Forms.Button btn_ctrl_rly1;
        private System.Windows.Forms.TextBox txt_sta_rly4;
        private System.Windows.Forms.TextBox txt_sta_rly3;
        private System.Windows.Forms.TextBox txt_sta_rly2;
        private System.Windows.Forms.TextBox txt_sta_rly1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;

    }
}

