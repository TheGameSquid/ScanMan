using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScanMan
{
    public partial class ModeSelectionControl : UserControl, IModeControl
    {
        public ModeSelectionControl()
        {
            InitializeComponent();
        }

        public void BarcodeLogic(Barcode barcode)
        {
            // No specific logic required
        }

        public void Clear()
        {
            // No specific logic required
        }

        public void Print()
        {
            // No specific logic required
        }

        private void buttonModeKitting_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Parent.Parent;
            parent.ChangeMode(new ModeKittingControl());
        }

        private void buttonWIP_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Parent.Parent;
            parent.ChangeMode(new ModeRequestControl());
        }
    }
}
