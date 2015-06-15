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
            this.controlKittingAsset.Clear();
        }

        public void Print()
        {
            if (controlKittingAsset.AssetOK)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(Path.Combine(Directory.GetCurrentDirectory(), "Documents", "Base", "Checklist.xlsx"));
                Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1];

                excelSheet.Cells[4, 2] = excelSheet.Cells[4, 2].Text + " " + controlKittingAsset.txtAsset.Text;
                excelSheet.Cells[5, 2] = excelSheet.Cells[5, 2].Text + " " + controlKittingAsset.txtType.Text;
                excelSheet.Cells[6, 2] = excelSheet.Cells[6, 2].Text + " " + txtName.Text;

                string strFileName = "Kitting-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".xlsx";
                string strFile = Path.Combine(Directory.GetCurrentDirectory(), "Documents", "Output", strFileName);
                excelWorkbook.Application.DisplayAlerts = false;
                excelWorkbook.SaveAs(Filename: strFile, ConflictResolution: XlSaveConflictResolution.xlLocalSessionChanges);

                // Print out the sheet
                excelSheet.PrintOutEx(1, 1, 1, false, ActivePrinter: Properties.Settings.Default.Printer);

                excelWorkbook.Close();
                excelApp = null;
            }
            else
            {
                MessageBox.Show(null, "Please fill in an existing asset!", "Asset error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
