using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

using System.IO.Ports;
using Modbus.Device;

namespace modbus
{
    public partial class Form1 : Form
    {
        // Variable declaration
        bool is_COMportOpen = false;
        ModbusSerialMaster master;
        public byte slave_address = 2;

        bool is_on_rly1 = false;
        bool is_on_rly2 = false;
        bool is_on_rly3 = false;
        bool is_on_rly4 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmb_ComportNo.Items.AddRange(ports);

            // initial WFC
            grb_RelayControl.Enabled = false;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_COMportOpen == false)
                {
                    serialPort1.PortName = cmb_ComportNo.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmb_Baudrate.Text);
                    serialPort1.DataBits = Convert.ToInt32(cmb_DataBits.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cmb_ParityBit.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmb_StopBits.Text);

                    serialPort1.Open();
                    master = ModbusSerialMaster.CreateRtu(serialPort1);
                    is_COMportOpen = true;
                    btn_Open.Text = "Close";
                    progressBar1.Value = 100;
                    grb_RelayControl.Enabled = true;

                    // initial read the CoilRegister value
                    bool[] status_relay = master.ReadCoils(slave_address, 8, 4);
                    // Relay 4
                    if (status_relay[0])
                    {
                        txt_sta_rly4.Text = "Relay 4 is off now.";
                        is_on_rly4 = false;
                        btn_ctrl_rly4.Text = "&4 ON";
                    }
                    else
                    {
                        txt_sta_rly4.Text = "Relay 4 is on now.";
                        is_on_rly4 = true;
                        btn_ctrl_rly4.Text = "&4 OFF";
                    }
                    // Relay 3
                    if (status_relay[1])
                    {
                        txt_sta_rly3.Text = "Relay 3 is off now.";
                        is_on_rly3 = false;
                        btn_ctrl_rly3.Text = "&3 ON";
                    }
                    else
                    {
                        txt_sta_rly3.Text = "Relay 3 is on now.";
                        is_on_rly3 = true;
                        btn_ctrl_rly3.Text = "&3 OFF";
                    }
                    // Relay 2
                    if (status_relay[2])
                    {
                        txt_sta_rly2.Text = "Relay 2 is off now.";
                        is_on_rly2 = false;
                        btn_ctrl_rly2.Text = "&2 ON";
                    }
                    else
                    {
                        txt_sta_rly2.Text = "Relay 2 is on now.";
                        is_on_rly2 = true;
                        btn_ctrl_rly2.Text = "&2 OFF";
                    }
                    // Relay 1
                    if (status_relay[3])
                    {
                        txt_sta_rly1.Text = "Relay 1 is off now.";
                        is_on_rly1 = false;
                        btn_ctrl_rly1.Text = "&1 ON";
                    }
                    else
                    {
                        txt_sta_rly1.Text = "Relay 1 is on now.";
                        is_on_rly1 = true;
                        btn_ctrl_rly1.Text = "&1 OFF";
                    }
                }
                else 
                {
                    serialPort1.Close();
                    master.Dispose();
                    is_COMportOpen = false;
                    btn_Open.Text = "Open";
                    progressBar1.Value = 0;
                    grb_RelayControl.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error when opening COM port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void btn_ctrl_rly1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                is_on_rly1 = !is_on_rly1;
              //  master.WriteSingleRegister(slave_address, 6, 3);
                if (is_on_rly1)
                {
                    btn_ctrl_rly1.Text = "&1 OFF";
                   // master.WriteSingleCoil(slave_address, 9, false);
                    master.WriteSingleRegister(slave_address, 6, 0);

                }
                else
                {
                    btn_ctrl_rly1.Text = "&1 ON";
                  //  master.WriteSingleCoil(slave_address, 9, true);
                    master.WriteSingleRegister(slave_address, 6, 1);
                }

                bool[] status_relay = master.ReadCoils(slave_address, 6, 8);
                if (status_relay[0])
                {
                    txt_sta_rly1.Text = "Relay 1 is off now.";
                }
                else
                {
                    txt_sta_rly1.Text = "Relay 1 is on now.";
                }                
            }
        }

        private void btn_ctrl_rly2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                is_on_rly2 = !is_on_rly2;
                if (is_on_rly2)
                {
                    btn_ctrl_rly2.Text = "&2 OFF";
                    master.WriteSingleCoil(slave_address, 10, false);
                }
                else
                {
                    btn_ctrl_rly2.Text = "&2 ON";
                    master.WriteSingleCoil(slave_address, 10, true);
                }

                bool[] status_relay = master.ReadCoils(slave_address, 10, 1);
                if (status_relay[0])
                {
                    txt_sta_rly2.Text = "Relay 2 is off now.";
                }
                else
                {
                    txt_sta_rly2.Text = "Relay 2 is on now.";
                }
            }
        }

        private void btn_ctrl_rly3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                is_on_rly3 = !is_on_rly3;
                if (is_on_rly3)
                {
                    btn_ctrl_rly3.Text = "&3 OFF";
                    master.WriteSingleCoil(slave_address, 9, false);
                }
                else
                {
                    btn_ctrl_rly3.Text = "&3 ON";
                    master.WriteSingleCoil(slave_address, 9, true);
                }

                bool[] status_relay = master.ReadCoils(slave_address, 9, 1);
                if (status_relay[0])
                {
                    txt_sta_rly3.Text = "Relay 3 is off now.";
                }
                else
                {
                    txt_sta_rly3.Text = "Relay 3 is on now.";
                }
            }
        }

        private void btn_ctrl_rly4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                is_on_rly4 = !is_on_rly4;
                if (is_on_rly4)
                {
                    btn_ctrl_rly4.Text = "&4 OFF";
                    master.WriteSingleCoil(slave_address, 8, false);
                }
                else
                {
                    btn_ctrl_rly4.Text = "&4 ON";
                    master.WriteSingleCoil(slave_address, 8, true);
                }

                bool[] status_relay = master.ReadCoils(slave_address, 8, 1);
                if (status_relay[0])
                {
                    txt_sta_rly4.Text = "Relay 4 is off now.";
                }
                else
                {
                    txt_sta_rly4.Text = "Relay 4 is on now.";
                }
            }
        }
    }
}
