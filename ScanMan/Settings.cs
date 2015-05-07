using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScanMan
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ErrorOU = txtErrorOu.Text;
            Properties.Settings.Default.ScannerCom = txtComPoort.Text;
            Properties.Settings.Default.FileDir = txtFileDir.Text;
            Properties.Settings.Default.Printer = txtPrinter.Text;
            Properties.Settings.Default.Save();
            toolStripButton1.BackColor = System.Drawing.Color.YellowGreen;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtErrorOu.Text = Properties.Settings.Default.ErrorOU;
            txtPrinter.Text = Properties.Settings.Default.Printer;
            txtFileDir.Text = Properties.Settings.Default.FileDir;
            txtComPoort.Text = Properties.Settings.Default.ScannerCom;
        }
    }
}
