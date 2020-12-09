namespace MathIS.Forms
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRestore = new System.Windows.Forms.Panel();
            this.pbWork = new System.Windows.Forms.PictureBox();
            this.bgWorker = new MathIS.Components.AbortableBackgroundWorker();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.btCancel = new MathIS.UI.ImageButton();
            this.btTestConn = new MathIS.UI.ImageButton();
            this.btOk = new MathIS.UI.ImageButton();
            this.btClose = new MathIS.UI.ImageButton();
            this.panel1.SuspendLayout();
            this.pnRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWork)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTestConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lozinka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "User ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 55);
            this.panel1.TabIndex = 20;
            // 
            // txPassword
            // 
            this.txPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPassword.Location = new System.Drawing.Point(97, 29);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(226, 20);
            this.txPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // txUser
            // 
            this.txUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUser.Location = new System.Drawing.Point(96, 3);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(226, 20);
            this.txUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User ID:";
            // 
            // cbAutent
            // 
            this.cbAutent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAutent.FormattingEnabled = true;
            this.cbAutent.Items.AddRange(new object[] {
            "SQL Authentication",
            "Windows Authentication"});
            this.cbAutent.Location = new System.Drawing.Point(99, 55);
            this.cbAutent.Name = "cbAutent";
            this.cbAutent.Size = new System.Drawing.Size(226, 21);
            this.cbAutent.TabIndex = 19;
            this.cbAutent.SelectedIndexChanged += new System.EventHandler(this.cbAutent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Authentication:";
            // 
            // txDatabase
            // 
            this.txDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDatabase.Location = new System.Drawing.Point(99, 29);
            this.txDatabase.Name = "txDatabase";
            this.txDatabase.Size = new System.Drawing.Size(226, 20);
            this.txDatabase.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baza podataka:";
            // 
            // txServer
            // 
            this.txServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txServer.Location = new System.Drawing.Point(99, 3);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(226, 20);
            this.txServer.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server:";
            // 
            // pnRestore
            // 
            this.pnRestore.Controls.Add(this.pbWork);
            this.pnRestore.Location = new System.Drawing.Point(6, 148);
            this.pnRestore.Name = "pnRestore";
            this.pnRestore.Size = new System.Drawing.Size(38, 40);
            this.pnRestore.TabIndex = 22;
            this.pnRestore.Visible = false;
            // 
            // pbWork
            // 
            this.pbWork.Location = new System.Drawing.Point(3, 3);
            this.pbWork.Name = "pbWork";
            this.pbWork.Size = new System.Drawing.Size(32, 32);
            this.pbWork.TabIndex = 0;
            this.pbWork.TabStop = false;
            // 
            // bgWorker
            // 
            this.bgWorker.Canceled = false;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Iconleak-Or-Light-bulb16.ico");
            this.imgList.Images.SetKeyName(1, "Iconleak-Or-Light-bulb16grayed.ico");
            this.imgList.Images.SetKeyName(2, "Group.ico");
            this.imgList.Images.SetKeyName(3, "UnGroup.ico");
            this.imgList.Images.SetKeyName(4, "Layer2.ico");
            this.imgList.Images.SetKeyName(5, "DB1.ico");
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.btCancel);
            this.pnMain.Controls.Add(this.btTestConn);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.pnRestore);
            this.pnMain.Controls.Add(this.cbAutent);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.txDatabase);
            this.pnMain.Controls.Add(this.txServer);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Location = new System.Drawing.Point(3, 22);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(352, 193);
            this.pnMain.TabIndex = 23;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btCancel.DisabledImage = global::MathIS.Properties.Resources.DBStopDisabled;
            this.btCancel.DownImage = global::MathIS.Properties.Resources.DBStopDown;
            this.btCancel.HoverImage = global::MathIS.Properties.Resources.DBStopHover;
            this.btCancel.Location = new System.Drawing.Point(100, 158);
            this.btCancel.Name = "btCancel";
            this.btCancel.NormalImage = global::MathIS.Properties.Resources.DBStop;
            this.btCancel.Size = new System.Drawing.Size(18, 18);
            this.btCancel.TabIndex = 30;
            this.btCancel.TabStop = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btTestConn
            // 
            this.btTestConn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btTestConn.DisabledImage = global::MathIS.Properties.Resources.DB1Disabled;
            this.btTestConn.DownImage = global::MathIS.Properties.Resources.DB1Down;
            this.btTestConn.HoverImage = global::MathIS.Properties.Resources.DB1Hovered;
            this.btTestConn.Location = new System.Drawing.Point(61, 158);
            this.btTestConn.Name = "btTestConn";
            this.btTestConn.NormalImage = global::MathIS.Properties.Resources.DB1;
            this.btTestConn.Size = new System.Drawing.Size(18, 18);
            this.btTestConn.TabIndex = 29;
            this.btTestConn.TabStop = false;
            this.btTestConn.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btOk.DisabledImage = global::MathIS.Properties.Resources.Ok16Disabled;
            this.btOk.DownImage = global::MathIS.Properties.Resources.Ok16Down;
            this.btOk.HoverImage = global::MathIS.Properties.Resources.Ok16Hower;
            this.btOk.Location = new System.Drawing.Point(337, 219);
            this.btOk.Name = "btOk";
            this.btOk.NormalImage = global::MathIS.Properties.Resources.Ok16;
            this.btOk.Size = new System.Drawing.Size(18, 18);
            this.btOk.TabIndex = 28;
            this.btOk.TabStop = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.DisabledImage = global::MathIS.Properties.Resources.Close16Disabled;
            this.btClose.DownImage = global::MathIS.Properties.Resources.Close16Down;
            this.btClose.HoverImage = global::MathIS.Properties.Resources.Close16Hower;
            this.btClose.Location = new System.Drawing.Point(339, 3);
            this.btClose.Name = "btClose";
            this.btClose.NormalImage = global::MathIS.Properties.Resources.Close16;
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 27;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(359, 240);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.Text = "Database connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnection_FormClosing);
            this.Load += new System.EventHandler(this.frmConnection_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmConnection_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnRestore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWork)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTestConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAutent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnRestore;
        private System.Windows.Forms.PictureBox pbWork;
        private MathIS.Components.AbortableBackgroundWorker bgWorker;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel pnMain;
        private MathIS.UI.ImageButton btClose;
        private MathIS.UI.ImageButton btOk;
        private MathIS.UI.ImageButton btTestConn;
        private MathIS.UI.ImageButton btCancel;
    }
}
