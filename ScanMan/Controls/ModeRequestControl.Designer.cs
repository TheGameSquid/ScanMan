namespace ScanMan
{
    partial class ModeRequestControl
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAssets = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureScanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1153, 72);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 75);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelAssets
            // 
            this.panelAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAssets.AutoScroll = true;
            this.panelAssets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAssets.Location = new System.Drawing.Point(28, 206);
            this.panelAssets.Margin = new System.Windows.Forms.Padding(6);
            this.panelAssets.Name = "panelAssets";
            this.panelAssets.Size = new System.Drawing.Size(1615, 729);
            this.panelAssets.TabIndex = 21;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1037, 72);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 75);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(921, 72);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(104, 75);
            this.buttonPrint.TabIndex = 19;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDepartment.Location = new System.Drawing.Point(21, 149);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(201, 37);
            this.labelDepartment.TabIndex = 18;
            this.labelDepartment.Text = "Departement";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelReason.Location = new System.Drawing.Point(113, 87);
            this.labelReason.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(109, 37);
            this.labelReason.TabIndex = 17;
            this.labelReason.Text = "Reden";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelName.Location = new System.Drawing.Point(125, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 37);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Naam";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(239, 143);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(6);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(652, 44);
            this.txtDepartment.TabIndex = 15;
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(239, 82);
            this.txtReason.Margin = new System.Windows.Forms.Padding(6);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(652, 44);
            this.txtReason.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(239, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(652, 44);
            this.txtName.TabIndex = 13;
            // 
            // pictureScanner
            // 
            this.pictureScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureScanner.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureScanner.Image = global::ScanMan.Properties.Resources.scanner;
            this.pictureScanner.InitialImage = global::ScanMan.Properties.Resources.scanner;
            this.pictureScanner.Location = new System.Drawing.Point(1423, 9);
            this.pictureScanner.Margin = new System.Windows.Forms.Padding(6);
            this.pictureScanner.Name = "pictureScanner";
            this.pictureScanner.Size = new System.Drawing.Size(220, 187);
            this.pictureScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureScanner.TabIndex = 23;
            this.pictureScanner.TabStop = false;
            this.pictureScanner.Click += new System.EventHandler(this.pictureScanner_Click);
            // 
            // ModeRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureScanner);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelAssets);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtName);
            this.Name = "ModeRequestControl";
            this.Size = new System.Drawing.Size(1678, 959);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureScanner;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.FlowLayoutPanel panelAssets;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtName;

    }
}
