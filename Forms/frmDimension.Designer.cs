namespace MathIS.Forms
{
    partial class frmDimension
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
            this.lblDim = new System.Windows.Forms.Label();
            this.nmValueRow = new System.Windows.Forms.NumericUpDown();
            this.nmValueColumn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDim
            // 
            this.lblDim.AutoSize = true;
            this.lblDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDim.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblDim.Location = new System.Drawing.Point(4, 3);
            this.lblDim.Name = "lblDim";
            this.lblDim.Size = new System.Drawing.Size(71, 13);
            this.lblDim.TabIndex = 0;
            this.lblDim.Text = "Dimensions";
            this.lblDim.DoubleClick += new System.EventHandler(this.lblDim_DoubleClick);
            // 
            // nmValueRow
            // 
            this.nmValueRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nmValueRow.Location = new System.Drawing.Point(5, 19);
            this.nmValueRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmValueRow.Name = "nmValueRow";
            this.nmValueRow.Size = new System.Drawing.Size(46, 20);
            this.nmValueRow.TabIndex = 2;
            this.nmValueRow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmValueRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmValueRow_KeyDown);
            // 
            // nmValueColumn
            // 
            this.nmValueColumn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nmValueColumn.Location = new System.Drawing.Point(57, 19);
            this.nmValueColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmValueColumn.Name = "nmValueColumn";
            this.nmValueColumn.Size = new System.Drawing.Size(46, 20);
            this.nmValueColumn.TabIndex = 3;
            this.nmValueColumn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmValueColumn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmValueColumn_KeyDown);
            // 
            // frmDimension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(108, 43);
            this.ControlBox = false;
            this.Controls.Add(this.nmValueColumn);
            this.Controls.Add(this.nmValueRow);
            this.Controls.Add(this.lblDim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "frmDimension";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Deactivate += new System.EventHandler(this.frmDimension_Deactivate);
            this.Load += new System.EventHandler(this.frmDimension_Load);
            this.Shown += new System.EventHandler(this.frmDimension_Shown);
            this.DoubleClick += new System.EventHandler(this.frmDimension_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.nmValueRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValueColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDim;
        private System.Windows.Forms.NumericUpDown nmValueRow;
        private System.Windows.Forms.NumericUpDown nmValueColumn;
    }
}