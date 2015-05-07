using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace ScanMan
{
    public partial class Asset : UserControl
    {
        public Asset()
        {
            InitializeComponent();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAsset_TextChanged(object sender, EventArgs e)
        {
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
            {
                // find a computer
                ComputerPrincipal computer = ComputerPrincipal.FindByIdentity(ctx, txtType.Text+txtAsset.Text);
                if (computer != null)
                {
                    txtLocationAd.Text = computer.DistinguishedName;
                    if (txtLocationAd.Text.Contains(Properties.Settings.Default.ErrorOU))
                    {
                        txtLocationAd.BackColor = System.Drawing.Color.OrangeRed;
                    }
                }
                else
                {
                    txtLocationAd.Text = "Not Found";
                }
                
            } 
        }

        private void txtLocationAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
