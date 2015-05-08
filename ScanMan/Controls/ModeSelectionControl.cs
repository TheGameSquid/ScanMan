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

        public void BarcodeLogic(string barcode)
        {
            if (barcode.Contains("_"))
            {
                if (barcode.Substring(0, 3) == "CL_GREEN")
                {
                    this.BackColor = Color.Green;
                }
                else if (barcode.Substring(0, 3) == "CL_RED")
                {
                    this.BackColor = Color.Red;
                }
            }
        }

        public void Clear()
        {
            // TODO
        }

        public void Print()
        {
            // TODO
        }

        private void buttonModeKitting_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Parent.Parent;
            parent.ChangeMode(new ModeRequestControl());
        }

        private void buttonWIP_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Parent.Parent;
            parent.ChangeMode(new ModeKittingControl());
        }
    }
}
