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
        public bool inbound = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getBarcodeScanner();
            
        }

        private void getBarcodeScanner()
        {
            try
            {
                
                SerialPort barCodeReader = new SerialPort(Properties.Settings.Default.ScannerCom);
                if (!barCodeReader.IsOpen)
                {
                    barCodeReader.Open();
                    barCodeReader.DataReceived += new SerialDataReceivedEventHandler(barCodeReader_DataReceived);
                    pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
                }

            }
            catch
            {
                //pbErrorStat.Enabled = false;

                pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
                this.Refresh();
           }
        }
        void barCodeReader_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string inp = sp.ReadExisting();
            int len = inp.Length;
            this.Invoke((MethodInvoker)delegate { BarcodeLogic(inp.Remove(inp.Length - 1)); });
            sp.DiscardInBuffer();
        }

        private void BarcodeLogic(string p)
        {
            if(p.Contains("_"))
            {
                if (p.Substring(0, 3) == "TP_")
                {
                    Asset itm = new Asset();

                    itm.Name = pnlItems.Controls.Count.ToString();
                    itm.txtType.Text = p.Substring(3);
                    itm.Anchor = AnchorStyles.Left;
                    itm.Dock = DockStyle.Right;
                    Size sz = new System.Drawing.Size();
                    sz = itm.Size;
                    sz.Width = pnlItems.Size.Width - 10;
                    itm.Size = sz;
                    pnlItems.Controls.Add(itm);
                }
                if (p.Substring(0, 3) == "NM_")
                {
                    txtNaam.Text = p.Substring(3);
                }
                if (p.Substring(0, 3) == "DP_")
                {
                    txtDepartement.Text = p.Substring(3);
                }
                if (p.Substring(0, 3) == "RN_" || p.Substring(0, 2) == "WO" || p.Substring(0, 2) == "GO")
                {
                    txtReden.Text = p.Substring(3);
                    if (txtReden.Text.ToUpper().Contains("IN"))
                    {
                        inbound = true;
                    }
                    else
                    {
                        inbound = false;
                    }
                }
                if (p.Substring(0, 3) == "CM_")
                {
                    if (p.Substring(3, 3) == "PRN")
                    {
                        PrintDoc();
                    }
                    if (p.Substring(3, 3) == "CLR")
                    {
                        ClearScreen();
                    }
                }
                
            }
            else
            {
                if(p.Length==9)
                {
                    Asset itm = pnlItems.Controls.Find((pnlItems.Controls.Count - 1).ToString(), true)[0] as Asset;
                    itm.txtAsset.Text = p;
                    
                }
                else
                {
                    txtReden.Text = p;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearScreen();
            
        }

        private void ClearScreen()
        {
            txtDepartement.Clear();
            txtNaam.Clear();
            txtReden.Clear();
            pnlItems.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }

        private void PrintDoc()
        {
            string sfileName = DateTime.Now.ToString("yyyyMMdd_hhmmss") + txtReden.Text + "_"+txtNaam.Text+ ".pdf";
            SaveFileDialog of = new SaveFileDialog();
            of.InitialDirectory = @"C:\Data";
            of.InitialDirectory = Properties.Settings.Default.FileDir;
            of.FileName =  of.InitialDirectory + "\\"+sfileName;
            string fileName = of.FileName;
            Letter1 mydoc = new Letter1();
            
            mydoc.FooterLines.Add("B-IT");
            
            mydoc.GenerateLetter(this,inbound);
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
            
            public void GenerateLetter(Form1 frmCurrent,bool inbound)
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

                Phrase p2 = new Phrase("Ondergetekende, " + frmCurrent.txtNaam.Text + " verklaart hierbij onderstaand materiaal "+movement2+" Yptostock te vervoeren.\n\n", tf2);
                l1.Add(p2);
                Phrase p4 = new Phrase("Departement: "+frmCurrent.txtReden.Text+"\n", tf2);
                l1.Add(p4);
                Phrase p5 = new Phrase("Locatie : " + frmCurrent.txtDepartement.Text + "\n", tf2);
                l1.Add(p5);
                PdfPTable table = new PdfPTable(3);
                PdfPCell celTitle = new PdfPCell();
                Phrase pt = new Phrase("Type", tf3);
                celTitle.AddElement(pt);
                PdfPCell celTitle2 = new PdfPCell();
                Phrase pt2 = new Phrase("Asset#", tf3);
                celTitle2.AddElement(pt2);
                PdfPCell celTitle3 = new PdfPCell();
                Phrase pt3 = new Phrase("Ad Info", tf3);
                celTitle3.AddElement(pt3);
                float[] widths = new float[] { 1f, 1.5f, 10f,};
                table.SetWidths(widths);
                table.AddCell(celTitle);
                table.AddCell(celTitle2);
                table.AddCell(celTitle3);
                table.CompleteRow();

                foreach (Control ctr in frmCurrent.pnlItems.Controls)
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
                Phrase p6 = new Phrase("Opgemaakt op: " +DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +" \n\n", tf2);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Asset itm = new Asset();
            
            itm.Name = pnlItems.Controls.Count.ToString();
            itm.txtType.Text = "1234".Substring(3);
            Size sz = new System.Drawing.Size();
            sz = itm.Size;
            sz.Width = pnlItems.Size.Width - 40;
            itm.Size = sz;
            

            pnlItems.Controls.Add(itm);
        }

        private void pnlItems_Resize(object sender, EventArgs e)
        {
            foreach (Asset ast in pnlItems.Controls)
            {
                Size sz = new System.Drawing.Size();
                sz = ast.Size;
                sz.Width = pnlItems.Size.Width-40;
                ast.Size = sz;
            }
            pnlItems.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearScreen();
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
            getBarcodeScanner();
        }




    }
}
