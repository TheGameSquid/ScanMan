namespace ScanMan
{
    partial class ModeKittingControl
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.controlKittingAsset = new ScanMan.AssetKitting();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAsset = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(570, 442);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(201, 75);
            this.buttonPrint.TabIndex = 29;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelName.Location = new System.Drawing.Point(374, 116);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 37);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Naam";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(513, 112);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(652, 44);
            this.txtName.TabIndex = 23;
            // 
            // controlKittingAsset
            // 
            this.controlKittingAsset.Location = new System.Drawing.Point(197, 260);
            this.controlKittingAsset.Name = "controlKittingAsset";
            this.controlKittingAsset.Size = new System.Drawing.Size(1285, 59);
            this.controlKittingAsset.TabIndex = 30;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(908, 442);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(201, 75);
            this.buttonClear.TabIndex = 31;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelType.Location = new System.Drawing.Point(190, 220);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(87, 37);
            this.labelType.TabIndex = 32;
            this.labelType.Text = "Type";
            // 
            // labelAsset
            // 
            this.labelAsset.AutoSize = true;
            this.labelAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAsset.Location = new System.Drawing.Point(411, 220);
            this.labelAsset.Name = "labelAsset";
            this.labelAsset.Size = new System.Drawing.Size(97, 37);
            this.labelAsset.TabIndex = 33;
            this.labelAsset.Text = "Asset";
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAD.Location = new System.Drawing.Point(811, 220);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(239, 37);
            this.labelAD.TabIndex = 34;
            this.labelAD.Text = "Active Directory";
            // 
            // ModeKittingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelAD);
            this.Controls.Add(this.labelAsset);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.controlKittingAsset);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Name = "ModeKittingControl";
            this.Size = new System.Drawing.Size(1678, 959);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private AssetKitting controlKittingAsset;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAsset;
        private System.Windows.Forms.Label labelAD;
    }
}
