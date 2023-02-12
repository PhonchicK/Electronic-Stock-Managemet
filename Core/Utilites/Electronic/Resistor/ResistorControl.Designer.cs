namespace Core.Utilites.Electronic.Resistor
{
    partial class ResistorControl
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
            this.resistorImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resistorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // resistorImage
            // 
            this.resistorImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.resistorImage.Location = new System.Drawing.Point(0, 0);
            this.resistorImage.Name = "resistorImage";
            this.resistorImage.Size = new System.Drawing.Size(378, 107);
            this.resistorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resistorImage.TabIndex = 0;
            this.resistorImage.TabStop = false;
            this.resistorImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resistorImage_MouseClick);
            // 
            // ResistorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resistorImage);
            this.MinimumSize = new System.Drawing.Size(378, 222);
            this.Name = "ResistorControl";
            this.Size = new System.Drawing.Size(378, 222);
            this.Load += new System.EventHandler(this.ResistorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resistorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox resistorImage;
    }
}
