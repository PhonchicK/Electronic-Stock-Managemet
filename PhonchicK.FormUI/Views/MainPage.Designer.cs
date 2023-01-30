namespace PhonchicK.FormUI.Views
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.resistorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.capacitorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.transistorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iCsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.otherObjectsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resistorToolStripButton,
            this.capacitorToolStripButton,
            this.transistorToolStripButton,
            this.iCsToolStripButton,
            this.otherObjectsToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // resistorToolStripButton
            // 
            this.resistorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resistorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resistorToolStripButton.Image")));
            this.resistorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resistorToolStripButton.Name = "resistorToolStripButton";
            this.resistorToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.resistorToolStripButton.Text = "Resistor";
            this.resistorToolStripButton.Click += new System.EventHandler(this.resistorToolStripButton_Click);
            // 
            // capacitorToolStripButton
            // 
            this.capacitorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.capacitorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("capacitorToolStripButton.Image")));
            this.capacitorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.capacitorToolStripButton.Name = "capacitorToolStripButton";
            this.capacitorToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.capacitorToolStripButton.Text = "Capacitor";
            // 
            // transistorToolStripButton
            // 
            this.transistorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.transistorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("transistorToolStripButton.Image")));
            this.transistorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transistorToolStripButton.Name = "transistorToolStripButton";
            this.transistorToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.transistorToolStripButton.Text = "Transistor";
            // 
            // iCsToolStripButton
            // 
            this.iCsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.iCsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("iCsToolStripButton.Image")));
            this.iCsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iCsToolStripButton.Name = "iCsToolStripButton";
            this.iCsToolStripButton.Size = new System.Drawing.Size(27, 22);
            this.iCsToolStripButton.Text = "ICs";
            // 
            // otherObjectsToolStripButton
            // 
            this.otherObjectsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.otherObjectsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otherObjectsToolStripButton.Image")));
            this.otherObjectsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otherObjectsToolStripButton.Name = "otherObjectsToolStripButton";
            this.otherObjectsToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.otherObjectsToolStripButton.Text = "Other Objects";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainPage";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton resistorToolStripButton;
        private System.Windows.Forms.ToolStripButton capacitorToolStripButton;
        private System.Windows.Forms.ToolStripButton transistorToolStripButton;
        private System.Windows.Forms.ToolStripButton iCsToolStripButton;
        private System.Windows.Forms.ToolStripButton otherObjectsToolStripButton;
    }
}