using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using dbConn;
using MathIS.Components;
using MathIS.Forms;


namespace MathIS.Forms
{
    public partial class frmConnection : Form
    {
        #region fields

        private CDBConnection _Connection;
        private bool _TestConnection = false;

        private Rectangle _titleRect;
        private Font _titleFont = new Font("Arial", 8, FontStyle.Bold);
        private Brush _titleBrush;

        #endregion

        #region properties

        public CDBConnection Connection
        {
            get { return _Connection; }
        }

        #endregion

        #region Event handlers

        #region Form load close

        private void frmConnection_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.frmConnectionLocation;

            LoadData();
        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.frmConnectionLocation = this.Location;
            Properties.Settings.Default.Save();
        }

        #endregion

        #endregion

        private void cbAutent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAutent.SelectedIndex == 0)
            {
                EnableUserPasswordControls(true);
            }
            else
            {
                EnableUserPasswordControls(false);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (SaveConnection())
                DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (_TestConnection)
            {
                if (bgWorker.IsBusy)
                {
                    bgWorker.Abort();
                }
                else
                    DialogResult = DialogResult.Cancel;
                return;
            }

            DialogResult = DialogResult.Cancel;
        }

        private void frmConnection_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgList.Images[5], 10, 3);
            if (_titleBrush != null)
                e.Graphics.DrawString(Text, _titleFont, _titleBrush, 30, 4);
        }

        #region Constructor

        public frmConnection(CDBConnection Connection)
        {
            if (Connection != null)
                _Connection = Connection.Clone();
            else
                _Connection = new CDBConnection("", "");
            InitializeComponent();
        }

        

        #endregion

        #region Methods

        private void EnableUserPasswordControls(bool enable)
        {
            txUser.Enabled = enable;
            txPassword.Enabled = enable;
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WinAPI.WM_NCHITTEST)
            {
                int x = m.LParam.ToInt32() & 0xffff;
                int y = m.LParam.ToInt32() >> 16;
                Point pt = PointToClient(new Point(x, y));

                if (_titleRect.Contains(pt))
                {
                    m.Result = (IntPtr)WinAPI.HTCAPTION;
                    return;
                }
            }

            if (m.Msg == WinAPI.WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.DefWndProc(ref m);
        }

        private void LoadData()
        {
            

            _titleRect = new Rectangle(0, 0, Width, pnMain.Location.Y - 1);

            pbWork.Image = MathIS.Properties.Resources.ajax_loader;
            cbAutent.SelectedIndex = 0;
            cbAutent_SelectedIndexChanged(this, new EventArgs());

            txServer.Text = Connection.Server;
            txDatabase.Text = Connection.Database;
            if (Connection.SqlAuthentication)
            {
                txUser.Text = Connection.UserID;
                txPassword.Text = Connection.Password;
                cbAutent.SelectedIndex = 0;
                EnableUserPasswordControls(true);
            }
            else
            {
                txUser.Text = "";
                txPassword.Text = "";
                cbAutent.SelectedIndex = 1;
                EnableUserPasswordControls(false);
            }

            
        }

        private void UpdateConnection()
        {
            _Connection.Server = txServer.Text.Trim();
            _Connection.Database = txDatabase.Text.Trim();
            if (cbAutent.SelectedIndex == 0)
            {
                _Connection.SqlAuthentication = true;
                _Connection.UserID = txUser.Text.Trim();
                _Connection.Password = txPassword.Text.Trim();
            }
            else
            {
                _Connection.SqlAuthentication = false;
                _Connection.UserID = "";
                _Connection.Password = "";
            }
        }

        private void Test()
        {
            UpdateConnection();
            if (_Connection.Server == "")
            {
                MessageBox.Show(this, "Upišite naziv servera!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txServer.Focus();
                return;
            }
            if (_Connection.Database == "")
            {
                MessageBox.Show(this, "Upišite naziv baze podataka!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txDatabase.Focus();
                return;
            }
            if (_Connection.SqlAuthentication && _Connection.UserID == "")
            {
                MessageBox.Show(this, "Upišite UserID!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txUser.Focus();
                return;
            }

            _TestConnection = true;
            ArrangeControls(false);
            bgWorker.RunWorkerAsync("Test");
        }

        public void ArrangeControls(bool show)
        {
            txServer.Enabled = show;
            cbAutent.Enabled = show;

            if (show)
            {
                if (cbAutent.SelectedIndex == 0)
                    EnableUserPasswordControls(true);
                else
                    EnableUserPasswordControls(false);
            }
            else
                EnableUserPasswordControls(false);
            pnRestore.Visible = !show;
            btOk.Enabled = show;
            btTestConn.Enabled = show;
        }
            

        private bool SaveConnection()
        {
            UpdateConnection();

            if (_Connection.Server == "")
            {
                MessageBox.Show(this, "Upišite naziv servera!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txServer.Focus();
                return false;
            }
            if (_Connection.Database == "")
            {
                MessageBox.Show(this, "Upišite naziv baze podataka!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txDatabase.Focus();
                return false;
            }
            if (_Connection.SqlAuthentication && _Connection.UserID == "")
            {
                MessageBox.Show(this, "Upišite UserID!", "Podaci za spajanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txUser.Focus();
                return false;
            }

            return true;
        }

        #endregion

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string sMessage = "";
            if (!CDatabase.TestConnection(_Connection.ConnectionString, out sMessage))
            {
                e.Result = sMessage;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string errorMessage = null;
            try
            {
                errorMessage = e.Result as string;
            }
            catch
            {
                errorMessage = "";
            }

            ArrangeControls(true);

            if (bgWorker.Canceled)
                return;
            if (e.Error != null)
                MessageBox.Show(this, "Pogreška prilikom spajanja na bazu podataka!\n" + e.Error.Message, "Spajanje na bazu podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!string.IsNullOrEmpty(errorMessage))
                MessageBox.Show(this, "Pogreška prilikom spajanja na bazu podataka!\n" + errorMessage, "Spajanje na bazu podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_TestConnection)
                    MessageBox.Show(this, "Uspješno spajanje na bazu podataka!", "Spajanje na bazu podataka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DialogResult = DialogResult.OK;
            }

            _TestConnection = false;
        }


    }
}
