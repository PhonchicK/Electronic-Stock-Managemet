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
            this.colorsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resistanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // colorsComboBox
            // 
            this.colorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorsComboBox.FormattingEnabled = true;
            this.colorsComboBox.Location = new System.Drawing.Point(20, 149);
            this.colorsComboBox.Name = "colorsComboBox";
            this.colorsComboBox.Size = new System.Drawing.Size(129, 21);
            this.colorsComboBox.TabIndex = 1;
            this.colorsComboBox.SelectedIndexChanged += new System.EventHandler(this.colorsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strip Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(342, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ω";
            // 
            // resistanceTextBox
            // 
            this.resistanceTextBox.Location = new System.Drawing.Point(236, 149);
            this.resistanceTextBox.Name = "resistanceTextBox";
            this.resistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.resistanceTextBox.TabIndex = 6;
            this.resistanceTextBox.TextChanged += new System.EventHandler(this.resistanceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resistance";
            // 
            // ResistorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resistanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorsComboBox);
            this.Controls.Add(this.resistorImage);
            this.MinimumSize = new System.Drawing.Size(378, 222);
            this.Name = "ResistorControl";
            this.Size = new System.Drawing.Size(378, 222);
            this.Load += new System.EventHandler(this.ResistorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resistorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resistorImage;
        private System.Windows.Forms.ComboBox colorsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resistanceTextBox;
        private System.Windows.Forms.Label label2;
    }
}
