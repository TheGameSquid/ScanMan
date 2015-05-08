using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ItextSharpHelper;

namespace ScanMan
{
    public partial class ModeRequestControl : UserControl, IModeControl
    {
        private bool inbound = false;

        public ModeRequestControl()
        {
            InitializeComponent();
        }

        public void BarcodeLogic(string barcode)
        {
            if (barcode.Contains("_"))
            {
                if (barcode.Substring(0, 3) == "TP_")
                {
                    Asset itm = new Asset();

                    itm.Name = panelAssets.Controls.Count.ToString();
                    itm.txtType.Text = barcode.Substring(3);
                    itm.Anchor = AnchorStyles.Left;
                    itm.Dock = DockStyle.Right;
                    Size sz = new System.Drawing.Size();
                    sz = itm.Size;
                    sz.Width = panelAssets.Size.Width - 10;
                    itm.Size = sz;
                    panelAssets.Controls.Add(itm);
                }
                if (barcode.Substring(0, 3) == "NM_")
                {
                    txtName.Text = barcode.Substring(3);
                }
                if (barcode.Substring(0, 3) == "DP_")
                {
                    txtDepartment.Text = barcode.Substring(3);
                }
                if (barcode.Substring(0, 3) == "RN_" || barcode.Substring(0, 2) == "WO" || barcode.Substring(0, 2) == "GO")
                {
                    txtReason.Text = barcode.Substring(3);
                    // TODO: There is currently no "inbound" logic yet
                    inbound = false;
                    //if (txtReden.Text.ToUpper().Contains("IN"))
                    //{
                    //    inbound = true;
                    //}
                    //else
                    //{
                    //    inbound = false;
                    //}
                }
                if (barcode.Substring(0, 3) == "CM_")
                {
                    if (barcode.Substring(3, 3) == "PRN")
                    {
                        Print();
                    }
                    if (barcode.Substring(3, 3) == "CLR")
                    {
                        Clear();
                    }
                }

            }
            else
            {
                if (barcode.Length == 9)
                {
                    if (panelAssets.Controls.Count == 0)
                    {
                        MessageBox.Show("Please scan an asset-type first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Asset itm = panelAssets.Controls.Find((panelAssets.Controls.Count - 1).ToString(), true)[0] as Asset;
                        itm.txtAsset.Text = barcode;
                    }
                }
                else
                {
                    txtReason.Text = barcode;
                }

            }
        }

        public void Clear()
        {
            txtDepartment.Clear();
            txtName.Clear();
            txtReason.Clear();
            panelAssets.Controls.Clear();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Asset asset = new Asset();

            asset.Name = panelAssets.Controls.Count.ToString();
            asset.txtType.Text = "1234".Substring(3);
            // Set the size of the asset control to the size of the panel - 40
            asset.Size = new Size(panelAssets.Size.Width - 40, panelAssets.Size.Height);

            panelAssets.Controls.Add(asset);
        }

        private void pictureScanner_Click(object sender, EventArgs e)
        {
            // TODO
        }

        public void Print()
        {
            string sfileName = DateTime.Now.ToString("yyyyMMdd_hhmmss") + txtReason.Text + "_" + txtName.Text + ".pdf";
            SaveFileDialog of = new SaveFileDialog();
            of.InitialDirectory = @"C:\Data";
            of.InitialDirectory = Properties.Settings.Default.FileDir;
            of.FileName = of.InitialDirectory + "\\" + sfileName;
            string fileName = of.FileName;
            Letter1 mydoc = new Letter1();

            mydoc.FooterLines.Add("B-IT");

            mydoc.GenerateLetter(this, inbound);
            FileStream f = new FileStream(fileName, FileMode.Create);
            f.Write(mydoc.DocumentBytes, 0, mydoc.DocumentBytes.Length);
            f.Close();
            string printer = Properties.Settings.Default.Printer;

            ProcessStartInfo info = new ProcessStartInfo(fileName);
            info.Verb = "Print";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);
        }

        public class Letter1 : ITextLetterBase
        {
            public Letter1()
            {
            }

            public void GenerateLetter(ModeRequestControl frmCurrent, bool inbound)
            {

                l1.NewPage();
                BaseFont Titlebf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, "utf-8", true);
                iTextSharp.text.Font tf = new iTextSharp.text.Font(Titlebf, 14, 0, BaseColor.BLACK);

                BaseFont Titlebf2 = BaseFont.CreateFont(BaseFont.HELVETICA, "utf-8", true);
                iTextSharp.text.Font tf2 = new iTextSharp.text.Font(Titlebf2, 10, 0, BaseColor.BLACK);

                BaseFont Titlebf3 = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, "utf-8", true);
                iTextSharp.text.Font tf3 = new iTextSharp.text.Font(Titlebf3, 10, 0, BaseColor.BLACK);

                BaseFont Titlebf4 = BaseFont.CreateFont(BaseFont.HELVETICA, "utf-8", true);
                iTextSharp.text.Font tf4 = new iTextSharp.text.Font(Titlebf4, 8, 0, BaseColor.BLACK);

                BaseFont Titlebf5 = BaseFont.CreateFont(BaseFont.HELVETICA, "utf-8", true);
                iTextSharp.text.Font tf5 = new iTextSharp.text.Font(Titlebf5, 6, 0, BaseColor.BLACK);

                iTextSharp.text.Image gif2 = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, BaseColor.WHITE);


                string movement = "Uitgaand";
                string movement2 = "uit";
                if (inbound)
                {
                    movement = "Inkomend";
                    movement2 = "naar";
                }
                else
                {
                    movement = "Uitgaand";
                }

                GenerateLetterBase();

                gif2.ScaleAbsoluteHeight(30.5f);
                gif2.ScaleAbsoluteWidth(40.5f);
                l1.Add(new Phrase("\n"));
                Phrase logo = new Phrase(new Chunk(gif2, 0, 0));
                l1.Add(logo);
                l1.Add(new Phrase("\n"));
                l1.Add(new Phrase("\n"));
                Phrase p = new Phrase("Addendum - " + movement + " materiaal stock \n\n", tf);
                l1.Add(p);

                Phrase p2 = new Phrase("Ondergetekende, " + frmCurrent.txtName.Text + " verklaart hierbij onderstaand materiaal " + movement2 + " Yptostock te vervoeren.\n\n", tf2);
                l1.Add(p2);
                Phrase p4 = new Phrase("Departement: " + frmCurrent.txtDepartment.Text + "\n", tf2);
                l1.Add(p4);
                Phrase p5 = new Phrase("Reden : " + frmCurrent.txtReason.Text + "\n", tf2);
                l1.Add(p5);
                PdfPTable table = new PdfPTable(3);
                PdfPCell celTitle = new PdfPCell();
                Phrase pt = new Phrase("Type", tf3);
                celTitle.AddElement(pt);
                PdfPCell celTitle2 = new PdfPCell();
                Phrase pt2 = new Phrase("Asset#", tf3);
                celTitle2.AddElement(pt2);
                PdfPCell celTitle3 = new PdfPCell();
                Phrase pt3 = new Phrase("AD Info", tf3);
                celTitle3.AddElement(pt3);
                float[] widths = new float[] { 1f, 1.5f, 10f, };
                table.SetWidths(widths);
                table.AddCell(celTitle);
                table.AddCell(celTitle2);
                table.AddCell(celTitle3);
                table.CompleteRow();

                foreach (Control ctr in frmCurrent.panelAssets.Controls)
                {
                    if (ctr.GetType().ToString() == "ScanMan.Asset")
                    {
                        Asset ctrlA = ctr as Asset;
                        PdfPCell celTitlea = new PdfPCell();
                        Phrase pta = new Phrase(ctrlA.txtType.Text, tf4);
                        celTitlea.AddElement(pta);

                        PdfPCell celTitle4 = new PdfPCell();
                        Phrase pt4 = new Phrase(ctrlA.txtAsset.Text, tf4);
                        celTitle4.AddElement(pt4);

                        PdfPCell celTitle5 = new PdfPCell();
                        if (ctrlA.txtLocationAd.Text.Contains(Properties.Settings.Default.ErrorOU))
                        {
                            Phrase pt5 = new Phrase(ctrlA.txtLocationAd.Text, tf5);
                            celTitle5.BackgroundColor = iTextSharp.text.BaseColor.RED;
                            celTitle5.AddElement(pt5);
                        }
                        else
                        {
                            Phrase pt5 = new Phrase(ctrlA.txtLocationAd.Text, tf5);
                            celTitle5.AddElement(pt5);
                        }
                        table.AddCell(celTitlea);
                        table.AddCell(celTitle4);
                        table.AddCell(celTitle5);
                        table.CompleteRow();
                    }
                }
                l1.Add(table);
                Phrase p6 = new Phrase("Opgemaakt op: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " \n\n", tf2);
                l1.Add(p6);
                Phrase p7 = new Phrase("Handtekening werkne(e)m(st)er/opdrachtnemer\n\n", tf2);
                l1.Add(p7);
                l1.Close();
                DocumentBytes = PDFStream.GetBuffer();
            }

            internal void GenerateLetter2(DataGridView dataGridView1)
            {
                GenerateLetterBase();
                PdfPTable table = new PdfPTable(3);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    PdfPCell cel = new PdfPCell();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        if (c.Name != "Foto")
                        {
                            string strText = r.Cells[c.Name].Value.ToString();
                            string str = c.Name + " : " + strText;
                            Phrase p = new Phrase(str);
                            cel.AddElement(p);
                        }
                    }
                    table.AddCell(cel);
                }
                table.CompleteRow();
                l1.Add(table);
                l1.Close();
                DocumentBytes = PDFStream.GetBuffer();
            }
        }
    }
}
