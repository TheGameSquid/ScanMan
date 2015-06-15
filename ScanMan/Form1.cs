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
        private IModeControl activeControl;
        private SerialPort barcodeReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize serial port
            barcodeReader = new SerialPort(Properties.Settings.Default.ScannerCom);
            // Initialize window, set mode to ModeSelection
            ChangeMode(new ModeSelectionControl());
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
                    toolStripButtonScanner.Image = ScanMan.Properties.Resources.Yes;
                }

            }
            catch
            {
                //pbErrorStat.Enabled = false;

                toolStripButtonScanner.Image = ScanMan.Properties.Resources.No;
                this.Refresh();
            }
        }

        private void BarcodeReader_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string input = port.ReadExisting();
            this.Invoke((MethodInvoker)delegate { BarcodeLogic(input.Remove(input.Length - 1)); });
            port.DiscardInBuffer();
        }

        public void ChangeMode(Control modeControl)
        {
            // Remove all IModeControls in the Main Panel
            foreach (Control control in this.panelMain.Controls)
            {
                if (control is IModeControl)
                {
                    this.panelMain.Controls.Remove(control);
                }      
            }

            // Add the new IModeControl, mark it as active
            this.activeControl = (IModeControl)modeControl;
            this.panelMain.Controls.Add(modeControl);
        }

        private void BarcodeLogic(string barcode)
        {
            if (barcode.Substring(0, 3) == "MD_")
            {
                if (barcode == "MD_Selection")
                {
                    ChangeMode(new ModeSelectionControl());
                }
                else if (barcode == "MD_WIP")
                {
                    ChangeMode(new ModeRequestControl());
                }
                else if (barcode == "MD_Kitting")
                {
                    ChangeMode(new ModeKittingControl());
                }
            }
            else
            {
                this.activeControl.BarcodeLogic(barcode);
            } 
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

        private void modeSelectionControl1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            activeControl.Print();
        }    

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            activeControl.Clear();
        }

        private void toolStripButtonConfig_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void toolStripButtonScanner_Click(object sender, EventArgs e)
        {
            GetBarcodeScanner();
        }

        private void toolStripButtonMode_Click(object sender, EventArgs e)
        {
            ChangeMode(new ModeSelectionControl());
        }
    }
}
