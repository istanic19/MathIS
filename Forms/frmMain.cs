using MathIS.Components;
using MathIS.Model.Entities;
using MathIS.Services;
using MathIS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.Forms
{
    public partial class frmMain : Form
    {
        #region Fields
        private AppSettings _settings;
        private EventDisabler EventDisable = new EventDisabler();
        #endregion

        #region Event Handlers

        #region Form Load, Closing, Shown

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.frmMainLocation;
            this.Size = Properties.Settings.Default.frmMainSize;
            this.WindowState = Properties.Settings.Default.frmMainState;

            _settings = AppSettings.Load();

            EventDisable++;
            LoadData();
            EventDisable--;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.frmMainState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.frmMainLocation = this.Location;
                Properties.Settings.Default.frmMainSize = this.Size;
            }
            else
            {
                Properties.Settings.Default.frmMainLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.frmMainSize = this.RestoreBounds.Size;
            }


            Properties.Settings.Default.Save();

            _settings.Save();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        #endregion

        #region Main menu

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConnection();

            string message = "";

            if (!AppSettings.TestConnection(AppSettings.Connection, out message))
            {
                MessageBox.Show(this, message, @"Veza s bazom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        #endregion

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ParseNum1();
            }
        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ParseNum2();
            }
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            ParseNum1();
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
            ParseNum2();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Number num = lblResult.Tag as Number;

            if (num != null)
                Clipboard.SetText(num.Text);
        }

        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            string message = "";
            if (!_settings.TestAllConnections(out message))
            {
                bool result = ShowConnection();
                if (!result)
                {
                    Close();
                    return;
                }
            }
            cmbOperation.DataSource = AritmeticsService.Operations;
            cmbOperation.SelectedIndex = 0;
                      

        }

        private bool ShowConnection()
        {
            frmConnection form = new frmConnection(AppSettings.Connection);

            if (form.ShowDialog() == DialogResult.OK)
            {
                string message = "";

                if (!AppSettings.TestConnection(form.Connection, out message))
                {
                    MessageBox.Show(this, message, @"Veza s bazom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ShowConnection();
                }
                else
                {
                    _settings.SetConnection(form.Connection);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void ParseNum1()
        {
            var num1 = Number.ParseFrom(txtNum1.Text);

            lblNum1.Text = num1 != null ? num1.ToString() : "Error";
            lblNum1.Tag = num1;
        }

        private void ParseNum2()
        {
            var num2 = Number.ParseFrom(txtNum2.Text);

            lblNum2.Text = num2 != null ? num2.ToString() : "Error";
            lblNum2.Tag = num2;
        }

        private void Calculate()
        {
            Number result = null;

            try
            {
                result = AritmeticsService.Calculate(cmbOperation.SelectedItem as MatOperation, lblNum1.Tag as Number, lblNum2.Tag as Number);

                lblResult.Text = result.ToString();
                lblResult.Tag = result;

            }
            catch(Exception ex)
            {
                lblResult.Text = string.Format("Error: {0}", ex.Message);
            }
        }




        #endregion

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int h = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            dataGridView1.Size = new Size(dataGridView1.Width, h+3);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new Matrix(3, 3);

            m.Components[1, 1] = new Number(2, -3);

            var nc = new MatrixControl(m, pnlA);
        }
    }
}
