using MathIS.UI;

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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ddiOperation = new MathIS.UI.DropDownImage();
            this.pnlBreakLine = new System.Windows.Forms.Panel();
            this.grpVarB = new System.Windows.Forms.GroupBox();
            this.matrix_B = new MathIS.UI.ImageButton();
            this.vector_B = new MathIS.UI.ImageButton();
            this.num_B = new MathIS.UI.ImageButton();
            this.grpVarA = new System.Windows.Forms.GroupBox();
            this.matrix_A = new MathIS.UI.ImageButton();
            this.vector_A = new MathIS.UI.ImageButton();
            this.num_A = new MathIS.UI.ImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_rbresult_B = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_rbresult_A = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_rbresult_Default = new System.Windows.Forms.CheckBox();
            this.btnCalculateVector = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.conjugateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlB = new System.Windows.Forms.Panel();
            this.pnlA = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCopy = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpVarB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vector_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).BeginInit();
            this.grpVarA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vector_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cntxMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionToolStripMenuItem.Text = "Connection ...";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings ...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 635);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.ddiOperation);
            this.tabPage2.Controls.Add(this.pnlBreakLine);
            this.tabPage2.Controls.Add(this.grpVarB);
            this.tabPage2.Controls.Add(this.grpVarA);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.pnlResult);
            this.tabPage2.Controls.Add(this.pnlB);
            this.tabPage2.Controls.Add(this.pnlA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vectors and Matrix";
            // 
            // ddiOperation
            // 
            this.ddiOperation.Location = new System.Drawing.Point(282, 169);
            this.ddiOperation.Name = "ddiOperation";
            this.ddiOperation.SelectedItem = null;
            this.ddiOperation.Size = new System.Drawing.Size(32, 32);
            this.ddiOperation.TabIndex = 13;
            // 
            // pnlBreakLine
            // 
            this.pnlBreakLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.pnlBreakLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.pnlBreakLine.Location = new System.Drawing.Point(8, 251);
            this.pnlBreakLine.Name = "pnlBreakLine";
            this.pnlBreakLine.Size = new System.Drawing.Size(600, 4);
            this.pnlBreakLine.TabIndex = 12;
            // 
            // grpVarB
            // 
            this.grpVarB.Controls.Add(this.matrix_B);
            this.grpVarB.Controls.Add(this.vector_B);
            this.grpVarB.Controls.Add(this.num_B);
            this.grpVarB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.grpVarB.Location = new System.Drawing.Point(149, 6);
            this.grpVarB.Name = "grpVarB";
            this.grpVarB.Size = new System.Drawing.Size(135, 96);
            this.grpVarB.TabIndex = 11;
            this.grpVarB.TabStop = false;
            this.grpVarB.Text = "Variable B";
            // 
            // matrix_B
            // 
            this.matrix_B.DialogResult = System.Windows.Forms.DialogResult.None;
            this.matrix_B.DisabledImage = global::MathIS.Properties.Resources.matrixDisabled;
            this.matrix_B.DownImage = global::MathIS.Properties.Resources.matrixDown;
            this.matrix_B.HoverImage = global::MathIS.Properties.Resources.matrixHover;
            this.matrix_B.Location = new System.Drawing.Point(86, 19);
            this.matrix_B.Name = "matrix_B";
            this.matrix_B.NormalImage = global::MathIS.Properties.Resources.matrix;
            this.matrix_B.Size = new System.Drawing.Size(34, 34);
            this.matrix_B.TabIndex = 31;
            this.matrix_B.TabStop = false;
            this.toolTip1.SetToolTip(this.matrix_B, "Matrix \r\n(rows X columns)");
            this.matrix_B.Click += new System.EventHandler(this.matrix_B_Click);
            // 
            // vector_B
            // 
            this.vector_B.DialogResult = System.Windows.Forms.DialogResult.None;
            this.vector_B.DisabledImage = global::MathIS.Properties.Resources.vectorDisabled;
            this.vector_B.DownImage = global::MathIS.Properties.Resources.vectorDown;
            this.vector_B.HoverImage = global::MathIS.Properties.Resources.vectorHover;
            this.vector_B.Location = new System.Drawing.Point(46, 19);
            this.vector_B.Name = "vector_B";
            this.vector_B.NormalImage = global::MathIS.Properties.Resources.vector;
            this.vector_B.Size = new System.Drawing.Size(34, 34);
            this.vector_B.TabIndex = 30;
            this.vector_B.TabStop = false;
            this.toolTip1.SetToolTip(this.vector_B, "n-Dimensional vector");
            this.vector_B.Click += new System.EventHandler(this.vector_B_Click);
            // 
            // num_B
            // 
            this.num_B.DialogResult = System.Windows.Forms.DialogResult.None;
            this.num_B.DisabledImage = global::MathIS.Properties.Resources.numberDisabled;
            this.num_B.DownImage = global::MathIS.Properties.Resources.numberDown;
            this.num_B.HoverImage = global::MathIS.Properties.Resources.numberHover;
            this.num_B.Location = new System.Drawing.Point(6, 19);
            this.num_B.Name = "num_B";
            this.num_B.NormalImage = global::MathIS.Properties.Resources.number;
            this.num_B.Size = new System.Drawing.Size(34, 34);
            this.num_B.TabIndex = 29;
            this.num_B.TabStop = false;
            this.toolTip1.SetToolTip(this.num_B, "Complex number\r\na + bj");
            this.num_B.Click += new System.EventHandler(this.num_B_Click);
            // 
            // grpVarA
            // 
            this.grpVarA.Controls.Add(this.matrix_A);
            this.grpVarA.Controls.Add(this.vector_A);
            this.grpVarA.Controls.Add(this.num_A);
            this.grpVarA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.grpVarA.Location = new System.Drawing.Point(8, 6);
            this.grpVarA.Name = "grpVarA";
            this.grpVarA.Size = new System.Drawing.Size(135, 96);
            this.grpVarA.TabIndex = 10;
            this.grpVarA.TabStop = false;
            this.grpVarA.Text = "Variable A";
            // 
            // matrix_A
            // 
            this.matrix_A.DialogResult = System.Windows.Forms.DialogResult.None;
            this.matrix_A.DisabledImage = global::MathIS.Properties.Resources.matrixDisabled;
            this.matrix_A.DownImage = global::MathIS.Properties.Resources.matrixDown;
            this.matrix_A.HoverImage = global::MathIS.Properties.Resources.matrixHover;
            this.matrix_A.Location = new System.Drawing.Point(86, 19);
            this.matrix_A.Name = "matrix_A";
            this.matrix_A.NormalImage = global::MathIS.Properties.Resources.matrix;
            this.matrix_A.Size = new System.Drawing.Size(34, 34);
            this.matrix_A.TabIndex = 31;
            this.matrix_A.TabStop = false;
            this.toolTip1.SetToolTip(this.matrix_A, "Matrix \r\n(rows X columns)");
            this.matrix_A.Click += new System.EventHandler(this.matrix_A_Click);
            // 
            // vector_A
            // 
            this.vector_A.DialogResult = System.Windows.Forms.DialogResult.None;
            this.vector_A.DisabledImage = global::MathIS.Properties.Resources.vectorDisabled;
            this.vector_A.DownImage = global::MathIS.Properties.Resources.vectorDown;
            this.vector_A.HoverImage = global::MathIS.Properties.Resources.vectorHover;
            this.vector_A.Location = new System.Drawing.Point(46, 19);
            this.vector_A.Name = "vector_A";
            this.vector_A.NormalImage = global::MathIS.Properties.Resources.vector;
            this.vector_A.Size = new System.Drawing.Size(34, 34);
            this.vector_A.TabIndex = 30;
            this.vector_A.TabStop = false;
            this.toolTip1.SetToolTip(this.vector_A, "n-Dimensional vector");
            this.vector_A.Click += new System.EventHandler(this.vector_A_Click);
            // 
            // num_A
            // 
            this.num_A.DialogResult = System.Windows.Forms.DialogResult.None;
            this.num_A.DisabledImage = global::MathIS.Properties.Resources.numberDisabled;
            this.num_A.DownImage = global::MathIS.Properties.Resources.numberDown;
            this.num_A.HoverImage = global::MathIS.Properties.Resources.numberHover;
            this.num_A.Location = new System.Drawing.Point(6, 19);
            this.num_A.Name = "num_A";
            this.num_A.NormalImage = global::MathIS.Properties.Resources.number;
            this.num_A.Size = new System.Drawing.Size(34, 34);
            this.num_A.TabIndex = 29;
            this.num_A.TabStop = false;
            this.toolTip1.SetToolTip(this.num_A, "Complex number\r\na + bj");
            this.num_A.Click += new System.EventHandler(this.num_A_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_rbresult_B);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_rbresult_A);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_rbresult_Default);
            this.groupBox1.Controls.Add(this.btnCalculateVector);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.groupBox1.Location = new System.Drawing.Point(292, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "To B";
            // 
            // cb_rbresult_B
            // 
            this.cb_rbresult_B.AutoSize = true;
            this.cb_rbresult_B.ForeColor = System.Drawing.Color.White;
            this.cb_rbresult_B.Location = new System.Drawing.Point(13, 67);
            this.cb_rbresult_B.Name = "cb_rbresult_B";
            this.cb_rbresult_B.Size = new System.Drawing.Size(15, 14);
            this.cb_rbresult_B.TabIndex = 12;
            this.cb_rbresult_B.UseVisualStyleBackColor = true;
            this.cb_rbresult_B.CheckedChanged += new System.EventHandler(this.resultTo_checkedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To A";
            // 
            // cb_rbresult_A
            // 
            this.cb_rbresult_A.AutoSize = true;
            this.cb_rbresult_A.ForeColor = System.Drawing.Color.White;
            this.cb_rbresult_A.Location = new System.Drawing.Point(13, 44);
            this.cb_rbresult_A.Name = "cb_rbresult_A";
            this.cb_rbresult_A.Size = new System.Drawing.Size(15, 14);
            this.cb_rbresult_A.TabIndex = 10;
            this.cb_rbresult_A.UseVisualStyleBackColor = true;
            this.cb_rbresult_A.CheckedChanged += new System.EventHandler(this.resultTo_checkedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Default";
            // 
            // cb_rbresult_Default
            // 
            this.cb_rbresult_Default.AutoSize = true;
            this.cb_rbresult_Default.Checked = true;
            this.cb_rbresult_Default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rbresult_Default.ForeColor = System.Drawing.Color.White;
            this.cb_rbresult_Default.Location = new System.Drawing.Point(13, 20);
            this.cb_rbresult_Default.Name = "cb_rbresult_Default";
            this.cb_rbresult_Default.Size = new System.Drawing.Size(15, 14);
            this.cb_rbresult_Default.TabIndex = 8;
            this.cb_rbresult_Default.UseVisualStyleBackColor = true;
            this.cb_rbresult_Default.CheckedChanged += new System.EventHandler(this.resultTo_checkedChanged);
            // 
            // btnCalculateVector
            // 
            this.btnCalculateVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(240)))));
            this.btnCalculateVector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculateVector.ForeColor = System.Drawing.Color.White;
            this.btnCalculateVector.Location = new System.Drawing.Point(83, 15);
            this.btnCalculateVector.Name = "btnCalculateVector";
            this.btnCalculateVector.Size = new System.Drawing.Size(73, 23);
            this.btnCalculateVector.TabIndex = 7;
            this.btnCalculateVector.Text = "Calculate";
            this.btnCalculateVector.UseVisualStyleBackColor = false;
            this.btnCalculateVector.Click += new System.EventHandler(this.btnCalculateVector_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.ContextMenuStrip = this.cntxMenu;
            this.pnlResult.Location = new System.Drawing.Point(8, 289);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(268, 73);
            this.pnlResult.TabIndex = 8;
            // 
            // cntxMenu
            // 
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.conjugateToolStripMenuItem,
            this.normalizeToolStripMenuItem});
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.Size = new System.Drawing.Size(130, 98);
            this.cntxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxMenu_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
            // 
            // conjugateToolStripMenuItem
            // 
            this.conjugateToolStripMenuItem.Name = "conjugateToolStripMenuItem";
            this.conjugateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.conjugateToolStripMenuItem.Text = "Conjugate";
            this.conjugateToolStripMenuItem.Click += new System.EventHandler(this.conjugateToolStripMenuItem_Click);
            // 
            // normalizeToolStripMenuItem
            // 
            this.normalizeToolStripMenuItem.Name = "normalizeToolStripMenuItem";
            this.normalizeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.normalizeToolStripMenuItem.Text = "Normalize";
            this.normalizeToolStripMenuItem.Click += new System.EventHandler(this.normalizeToolStripMenuItem_Click);
            // 
            // pnlB
            // 
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.ContextMenuStrip = this.cntxMenu;
            this.pnlB.Location = new System.Drawing.Point(320, 147);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(268, 73);
            this.pnlB.TabIndex = 2;
            // 
            // pnlA
            // 
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.ContextMenuStrip = this.cntxMenu;
            this.pnlA.Location = new System.Drawing.Point(8, 147);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(268, 73);
            this.pnlA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
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
            this.tabPage1.Size = new System.Drawing.Size(916, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Complex";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.editToolStripMenuItem_DropDownOpened);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 659);
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
            this.tabPage2.ResumeLayout(false);
            this.grpVarB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vector_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).EndInit();
            this.grpVarA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vector_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cntxMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Button btnCalculateVector;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpVarA;
        private UI.ImageButton num_A;
        private UI.ImageButton matrix_A;
        private UI.ImageButton vector_A;
        private System.Windows.Forms.GroupBox grpVarB;
        private UI.ImageButton matrix_B;
        private UI.ImageButton vector_B;
        private UI.ImageButton num_B;
        private System.Windows.Forms.Panel pnlBreakLine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conjugateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizeToolStripMenuItem;
        private DropDownImage ddiOperation;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_rbresult_Default;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_rbresult_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_rbresult_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

