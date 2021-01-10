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
            this.txtDim = new System.Windows.Forms.TextBox();
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
            // 
            // txtDim
            // 
            this.txtDim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDim.Location = new System.Drawing.Point(7, 22);
            this.txtDim.Name = "txtDim";
            this.txtDim.Size = new System.Drawing.Size(75, 15);
            this.txtDim.TabIndex = 1;
            this.txtDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDim_KeyDown);
            // 
            // frmDimension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(91, 43);
            this.ControlBox = false;
            this.Controls.Add(this.txtDim);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDim;
        private System.Windows.Forms.TextBox txtDim;
    }
}