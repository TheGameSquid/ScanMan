using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ItextSharpHelper;
using System.Diagnostics;

namespace ScanMan
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            GetBarcodeScanner();
        }

        private void GetBarcodeScanner()
        {
            try
            {
                
                SerialPort barCodeReader = new SerialPort(Properties.Settings.Default.ScannerCom);
                if (!barCodeReader.IsOpen)
                {
                    barCodeReader.Open();
                    barCodeReader.DataReceived += new SerialDataReceivedEventHandler(BarcodeReader_DataReceived);
                    // TODO pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
                }

            }
            catch
            {
                //pbErrorStat.Enabled = false;

                // TODO: pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
                this.Refresh();
           }
        }
        void BarcodeReader_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string input = port.ReadExisting();
            this.Invoke((MethodInvoker)delegate { BarcodeLogic(input.Remove(input.Length - 1)); });
            port.DiscardInBuffer();
        }

        private void BarcodeLogic(string barcode)
        {
            this.modeControlRequest.BarcodeLogic(barcode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }

        private void PrintDoc()
        {
            // TODO
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //ClearScreen();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }



        private void OpenSettings()
        {
            Settings frmSettings = new Settings();
            frmSettings.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetBarcodeScanner();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            GetBarcodeScanner();
        }
    }
}
