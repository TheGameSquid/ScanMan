namespace ScanMan
{
    partial class AssetKitting
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.txtLocationAD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(6, 6);
            this.txtType.Margin = new System.Windows.Forms.Padding(6);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(198, 44);
            this.txtType.TabIndex = 4;
            // 
            // txtAsset
            // 
            this.txtAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset.Location = new System.Drawing.Point(216, 6);
            this.txtAsset.Margin = new System.Windows.Forms.Padding(6);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.Size = new System.Drawing.Size(390, 44);
            this.txtAsset.TabIndex = 5;
            this.txtAsset.TextChanged += new System.EventHandler(this.txtAsset_TextChanged);
            // 
            // txtLocationAD
            // 
            this.txtLocationAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocationAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationAD.Location = new System.Drawing.Point(618, 6);
            this.txtLocationAD.Margin = new System.Windows.Forms.Padding(6);
            this.txtLocationAD.Name = "txtLocationAD";
            this.txtLocationAD.Size = new System.Drawing.Size(648, 44);
            this.txtLocationAD.TabIndex = 6;
            // 
            // AssetKitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLocationAD);
            this.Controls.Add(this.txtAsset);
            this.Controls.Add(this.txtType);
            this.Name = "AssetKitting";
            this.Size = new System.Drawing.Size(1285, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox txtAsset;
        public System.Windows.Forms.TextBox txtLocationAD;

    }
}
