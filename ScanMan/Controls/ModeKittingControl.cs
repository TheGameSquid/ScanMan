using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ScanMan
{
    public partial class ModeKittingControl : UserControl, IModeControl
    {
        public ModeKittingControl()
        {
            InitializeComponent();
        }

        public void BarcodeLogic(string barcode)
        {
            if (barcode.Substring(0, 3) == "TP_")
            {
                this.controlKittingAsset.txtType.Text = barcode.Substring(3);
            }
            else if (barcode.Substring(0, 3) == "NM_")
            {
                txtName.Text = barcode.Substring(3);
            }
            else
            {
                this.controlKittingAsset.txtAsset.Text = barcode;
            }
        }

        public void Clear()
        {

        }

        public void Print()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(Path.Combine(Directory.GetCurrentDirectory(), "Checklist.xlsx"));
            Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1];

            excelSheet.Cells[4, 2] = excelSheet.Cells[4, 2].Text + " " + controlKittingAsset.txtAsset.Text;
            excelSheet.Cells[5, 2] = excelSheet.Cells[5, 2].Text + " " + controlKittingAsset.txtType.Text;
            excelSheet.Cells[6, 2] = excelSheet.Cells[6, 2].Text + " " + txtName.Text;

            //excelSheet.Range[4, 2].Text

            string strFile = Path.Combine(Directory.GetCurrentDirectory(), "FLOEPDOODLE.xlsx");
            excelWorkbook.Application.DisplayAlerts = false;
            excelWorkbook.SaveAs(Filename: strFile, ConflictResolution: XlSaveConflictResolution.xlLocalSessionChanges);
            excelWorkbook.Close();
            excelApp = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
