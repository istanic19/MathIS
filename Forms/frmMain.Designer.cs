namespace MathIS.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCopy = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnCalculateVector = new System.Windows.Forms.Button();
            this.cmbVectorOperation = new System.Windows.Forms.ComboBox();
            this.pnlB = new System.Windows.Forms.Panel();
            this.grpB = new System.Windows.Forms.GroupBox();
            this.btnCreate_2 = new System.Windows.Forms.Button();
            this.nmColumns_B = new System.Windows.Forms.NumericUpDown();
            this.nmRows_B = new System.Windows.Forms.NumericUpDown();
            this.cmbTypeB = new System.Windows.Forms.ComboBox();
            this.pnlA = new System.Windows.Forms.Panel();
            this.grpA = new System.Windows.Forms.GroupBox();
            this.btnCreate_1 = new System.Windows.Forms.Button();
            this.nmColumns_A = new System.Windows.Forms.NumericUpDown();
            this.nmRows_A = new System.Windows.Forms.NumericUpDown();
            this.cmbTypeA = new System.Windows.Forms.ComboBox();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmColumns_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRows_B)).BeginInit();
            this.grpA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmColumns_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRows_A)).BeginInit();
            this.cntxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.testToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.connectionToolStripMenuItem.Text = "Connection ...";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCopy);
            this.tabPage1.Controls.Add(this.btCalculate);
            this.tabPage1.Controls.Add(this.cmbOperation);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.lblNum2);
            this.tabPage1.Controls.Add(this.lblNum1);
            this.tabPage1.Controls.Add(this.txtNum2);
            this.tabPage1.Controls.Add(this.txtNum1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Complex";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(89, 132);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(58, 23);
            this.btCopy.TabIndex = 7;
            this.btCopy.Text = "Copy";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(8, 132);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 6;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // cmbOperation
            // 
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(6, 37);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(198, 21);
            this.cmbOperation.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(8, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(19, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "  ";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNum2.Location = new System.Drawing.Point(210, 64);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(17, 20);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "  ";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNum1.Location = new System.Drawing.Point(210, 9);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(17, 20);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "  ";
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNum2.Location = new System.Drawing.Point(8, 61);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(196, 26);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum2_KeyDown);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum2_Leave);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNum1.Location = new System.Drawing.Point(8, 6);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(196, 26);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum1_KeyDown);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlResult);
            this.tabPage2.Controls.Add(this.btnCalculateVector);
            this.tabPage2.Controls.Add(this.cmbVectorOperation);
            this.tabPage2.Controls.Add(this.pnlB);
            this.tabPage2.Controls.Add(this.grpB);
            this.tabPage2.Controls.Add(this.pnlA);
            this.tabPage2.Controls.Add(this.grpA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vectors and Matrix";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlResult
            // 
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.ContextMenuStrip = this.cntxMenu;
            this.pnlResult.Location = new System.Drawing.Point(8, 205);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(268, 73);
            this.pnlResult.TabIndex = 8;
            // 
            // btnCalculateVector
            // 
            this.btnCalculateVector.Location = new System.Drawing.Point(666, 34);
            this.btnCalculateVector.Name = "btnCalculateVector";
            this.btnCalculateVector.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateVector.TabIndex = 7;
            this.btnCalculateVector.Text = "Calculate";
            this.btnCalculateVector.UseVisualStyleBackColor = true;
            this.btnCalculateVector.Click += new System.EventHandler(this.btnCalculateVector_Click);
            // 
            // cmbVectorOperation
            // 
            this.cmbVectorOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVectorOperation.FormattingEnabled = true;
            this.cmbVectorOperation.Location = new System.Drawing.Point(282, 89);
            this.cmbVectorOperation.Name = "cmbVectorOperation";
            this.cmbVectorOperation.Size = new System.Drawing.Size(104, 21);
            this.cmbVectorOperation.TabIndex = 3;
            // 
            // pnlB
            // 
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.ContextMenuStrip = this.cntxMenu;
            this.pnlB.Location = new System.Drawing.Point(392, 63);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(268, 73);
            this.pnlB.TabIndex = 2;
            // 
            // grpB
            // 
            this.grpB.Controls.Add(this.btnCreate_2);
            this.grpB.Controls.Add(this.nmColumns_B);
            this.grpB.Controls.Add(this.nmRows_B);
            this.grpB.Controls.Add(this.cmbTypeB);
            this.grpB.Location = new System.Drawing.Point(392, 16);
            this.grpB.Name = "grpB";
            this.grpB.Size = new System.Drawing.Size(268, 41);
            this.grpB.TabIndex = 1;
            this.grpB.TabStop = false;
            this.grpB.Text = "B";
            // 
            // btnCreate_2
            // 
            this.btnCreate_2.Location = new System.Drawing.Point(223, 12);
            this.btnCreate_2.Name = "btnCreate_2";
            this.btnCreate_2.Size = new System.Drawing.Size(39, 23);
            this.btnCreate_2.TabIndex = 3;
            this.btnCreate_2.Text = "Add";
            this.btnCreate_2.UseVisualStyleBackColor = true;
            this.btnCreate_2.Click += new System.EventHandler(this.btnCreate_2_Click);
            // 
            // nmColumns_B
            // 
            this.nmColumns_B.Location = new System.Drawing.Point(167, 14);
            this.nmColumns_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmColumns_B.Name = "nmColumns_B";
            this.nmColumns_B.Size = new System.Drawing.Size(50, 20);
            this.nmColumns_B.TabIndex = 2;
            this.nmColumns_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmColumns_B.Visible = false;
            // 
            // nmRows_B
            // 
            this.nmRows_B.Location = new System.Drawing.Point(103, 14);
            this.nmRows_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRows_B.Name = "nmRows_B";
            this.nmRows_B.Size = new System.Drawing.Size(50, 20);
            this.nmRows_B.TabIndex = 1;
            this.nmRows_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRows_B.Visible = false;
            // 
            // cmbTypeB
            // 
            this.cmbTypeB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeB.FormattingEnabled = true;
            this.cmbTypeB.Location = new System.Drawing.Point(6, 14);
            this.cmbTypeB.Name = "cmbTypeB";
            this.cmbTypeB.Size = new System.Drawing.Size(74, 21);
            this.cmbTypeB.TabIndex = 0;
            this.cmbTypeB.SelectedIndexChanged += new System.EventHandler(this.cmbTypeB_SelectedIndexChanged);
            // 
            // pnlA
            // 
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.ContextMenuStrip = this.cntxMenu;
            this.pnlA.Location = new System.Drawing.Point(8, 63);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(268, 73);
            this.pnlA.TabIndex = 0;
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.btnCreate_1);
            this.grpA.Controls.Add(this.nmColumns_A);
            this.grpA.Controls.Add(this.nmRows_A);
            this.grpA.Controls.Add(this.cmbTypeA);
            this.grpA.Location = new System.Drawing.Point(8, 16);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(268, 41);
            this.grpA.TabIndex = 0;
            this.grpA.TabStop = false;
            this.grpA.Text = "A";
            // 
            // btnCreate_1
            // 
            this.btnCreate_1.Location = new System.Drawing.Point(223, 12);
            this.btnCreate_1.Name = "btnCreate_1";
            this.btnCreate_1.Size = new System.Drawing.Size(39, 23);
            this.btnCreate_1.TabIndex = 3;
            this.btnCreate_1.Text = "Add";
            this.btnCreate_1.UseVisualStyleBackColor = true;
            this.btnCreate_1.Click += new System.EventHandler(this.btnCreate_1_Click);
            // 
            // nmColumns_A
            // 
            this.nmColumns_A.Location = new System.Drawing.Point(167, 14);
            this.nmColumns_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmColumns_A.Name = "nmColumns_A";
            this.nmColumns_A.Size = new System.Drawing.Size(50, 20);
            this.nmColumns_A.TabIndex = 2;
            this.nmColumns_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmColumns_A.Visible = false;
            // 
            // nmRows_A
            // 
            this.nmRows_A.Location = new System.Drawing.Point(103, 14);
            this.nmRows_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRows_A.Name = "nmRows_A";
            this.nmRows_A.Size = new System.Drawing.Size(50, 20);
            this.nmRows_A.TabIndex = 1;
            this.nmRows_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRows_A.Visible = false;
            // 
            // cmbTypeA
            // 
            this.cmbTypeA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeA.FormattingEnabled = true;
            this.cmbTypeA.Location = new System.Drawing.Point(6, 14);
            this.cmbTypeA.Name = "cmbTypeA";
            this.cmbTypeA.Size = new System.Drawing.Size(74, 21);
            this.cmbTypeA.TabIndex = 0;
            this.cmbTypeA.SelectedIndexChanged += new System.EventHandler(this.cmbTypeA_SelectedIndexChanged);
            // 
            // cntxMenu
            // 
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.Size = new System.Drawing.Size(103, 48);
            this.cntxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxMenu_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmColumns_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRows_B)).EndInit();
            this.grpA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmColumns_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRows_A)).EndInit();
            this.cntxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpA;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.ComboBox cmbTypeA;
        private System.Windows.Forms.NumericUpDown nmColumns_A;
        private System.Windows.Forms.NumericUpDown nmRows_A;
        private System.Windows.Forms.Button btnCreate_1;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.GroupBox grpB;
        private System.Windows.Forms.Button btnCreate_2;
        private System.Windows.Forms.NumericUpDown nmColumns_B;
        private System.Windows.Forms.NumericUpDown nmRows_B;
        private System.Windows.Forms.ComboBox cmbTypeB;
        private System.Windows.Forms.ComboBox cmbVectorOperation;
        private System.Windows.Forms.Button btnCalculateVector;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

