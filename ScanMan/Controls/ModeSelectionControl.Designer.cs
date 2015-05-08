namespace ScanMan
{
    partial class ModeSelectionControl
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
            this.buttonModeKitting = new System.Windows.Forms.Button();
            this.buttonWIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModeKitting
            // 
            this.buttonModeKitting.Location = new System.Drawing.Point(70, 19);
            this.buttonModeKitting.Name = "buttonModeKitting";
            this.buttonModeKitting.Size = new System.Drawing.Size(735, 919);
            this.buttonModeKitting.TabIndex = 0;
            this.buttonModeKitting.Text = "Kitting";
            this.buttonModeKitting.UseVisualStyleBackColor = true;
            this.buttonModeKitting.Click += new System.EventHandler(this.buttonModeKitting_Click);
            // 
            // buttonWIP
            // 
            this.buttonWIP.Location = new System.Drawing.Point(871, 19);
            this.buttonWIP.Name = "buttonWIP";
            this.buttonWIP.Size = new System.Drawing.Size(735, 919);
            this.buttonWIP.TabIndex = 1;
            this.buttonWIP.Text = "WIP";
            this.buttonWIP.UseVisualStyleBackColor = true;
            this.buttonWIP.Click += new System.EventHandler(this.buttonWIP_Click);
            // 
            // ModeSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonWIP);
            this.Controls.Add(this.buttonModeKitting);
            this.Name = "ModeSelectionControl";
            this.Size = new System.Drawing.Size(1678, 959);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModeKitting;
        private System.Windows.Forms.Button buttonWIP;
    }
}
