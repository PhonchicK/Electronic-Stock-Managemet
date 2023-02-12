namespace PhonchicK.FormUI.Views.ListViews
{
    partial class ResistorListView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistorViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resistorControl1 = new Core.Utilites.Electronic.Resistor.ResistorControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.resistanceDataGridViewTextBoxColumn,
            this.toleranceDataGridViewTextBoxColumn,
            this.bandCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resistorViewModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(376, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "$";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 25;
            // 
            // resistanceDataGridViewTextBoxColumn
            // 
            this.resistanceDataGridViewTextBoxColumn.DataPropertyName = "Resistance";
            this.resistanceDataGridViewTextBoxColumn.HeaderText = "Resistance";
            this.resistanceDataGridViewTextBoxColumn.Name = "resistanceDataGridViewTextBoxColumn";
            this.resistanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.resistanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // toleranceDataGridViewTextBoxColumn
            // 
            this.toleranceDataGridViewTextBoxColumn.DataPropertyName = "Tolerance";
            this.toleranceDataGridViewTextBoxColumn.HeaderText = "Tolerance";
            this.toleranceDataGridViewTextBoxColumn.Name = "toleranceDataGridViewTextBoxColumn";
            this.toleranceDataGridViewTextBoxColumn.ReadOnly = true;
            this.toleranceDataGridViewTextBoxColumn.Width = 65;
            // 
            // bandCountDataGridViewTextBoxColumn
            // 
            this.bandCountDataGridViewTextBoxColumn.DataPropertyName = "BandCount";
            this.bandCountDataGridViewTextBoxColumn.HeaderText = "BandCount";
            this.bandCountDataGridViewTextBoxColumn.Name = "bandCountDataGridViewTextBoxColumn";
            this.bandCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bandCountDataGridViewTextBoxColumn.Width = 85;
            // 
            // resistorViewModelBindingSource
            // 
            this.resistorViewModelBindingSource.DataSource = typeof(PhonchicK.FormUI.Models.ResistorViewModel);
            // 
            // resistorControl1
            // 
            this.resistorControl1.BandCount = 4;
            this.resistorControl1.Location = new System.Drawing.Point(410, 23);
            this.resistorControl1.MinimumSize = new System.Drawing.Size(378, 222);
            this.resistorControl1.Name = "resistorControl1";
            this.resistorControl1.Resistance = 10F;
            this.resistorControl1.Size = new System.Drawing.Size(378, 222);
            this.resistorControl1.TabIndex = 1;
            this.resistorControl1.Tolerance = 5;
            // 
            // ResistorListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resistorControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResistorListView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ResistorListView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resistorViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandCountDataGridViewTextBoxColumn;
        private Core.Utilites.Electronic.Resistor.ResistorControl resistorControl1;
    }
}