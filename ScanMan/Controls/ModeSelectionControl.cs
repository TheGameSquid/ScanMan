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
    public partial class ModeSelectionControl : UserControl
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
    }
}
