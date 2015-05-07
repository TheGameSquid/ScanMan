namespace ScanMan
{
    partial class Asset
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
            this.txtLocationAd = new System.Windows.Forms.TextBox();
            this.cmdDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(3, 3);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(101, 26);
            this.txtType.TabIndex = 3;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtAsset
            // 
            this.txtAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset.Location = new System.Drawing.Point(110, 3);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.Size = new System.Drawing.Size(197, 26);
            this.txtAsset.TabIndex = 4;
            this.txtAsset.TextChanged += new System.EventHandler(this.txtAsset_TextChanged);
            // 
            // txtLocationAd
            // 
            this.txtLocationAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocationAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationAd.Location = new System.Drawing.Point(313, 3);
            this.txtLocationAd.Name = "txtLocationAd";
            this.txtLocationAd.Size = new System.Drawing.Size(328, 26);
            this.txtLocationAd.TabIndex = 5;
            this.txtLocationAd.TextChanged += new System.EventHandler(this.txtLocationAd_TextChanged);
            // 
            // cmdDel
            // 
            this.cmdDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdDel.Location = new System.Drawing.Point(652, 0);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(44, 32);
            this.cmdDel.TabIndex = 6;
            this.cmdDel.Text = "X";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.txtLocationAd);
            this.Controls.Add(this.txtAsset);
            this.Controls.Add(this.txtType);
            this.Name = "Asset";
            this.Size = new System.Drawing.Size(696, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox txtAsset;
        public System.Windows.Forms.TextBox txtLocationAd;
        public System.Windows.Forms.Button cmdDel;

    }
}
