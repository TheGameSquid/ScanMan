using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScanMan
{
    public partial class AssetKitting : UserControl
    {
        public AssetKitting()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            // Detach the event to make sure we don't fire the event on .Clear()
            this.txtAsset.TextChanged -= txtAsset_TextChanged;

            // Clear the fields
            this.txtType.Clear();
            this.txtAsset.Clear();
            this.txtLocationAD.Clear();

            // Reattach it
            this.txtAsset.TextChanged += txtAsset_TextChanged;
        }

        private void txtAsset_TextChanged(object sender, EventArgs e)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                // Find a computer
                ComputerPrincipal computer = ComputerPrincipal.FindByIdentity(context, txtType.Text + txtAsset.Text);
                if (computer != null)
                {
                    txtLocationAD.Text = computer.DistinguishedName;
                    txtLocationAD.BackColor = System.Drawing.Color.YellowGreen;
                }
                else
                {
                    txtLocationAD.Text = "Not found!";
                    txtLocationAD.BackColor = System.Drawing.Color.OrangeRed;
                }
            } 
        }
    }
}
