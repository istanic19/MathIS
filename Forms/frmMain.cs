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

        private void cmbTypeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventDisable)
                return;
            switch(((AritmeticType)cmbTypeA.SelectedItem).Aritmetc)
            {
                case Model.Enums.AritmeticTypeEnum.Number:
                    nmColumns_A.Visible = false;
                    nmRows_A.Visible = false;
                    break;
                case Model.Enums.AritmeticTypeEnum.Vector:
                    nmColumns_A.Visible = false;
                    nmRows_A.Visible = true;
                    break;
                case Model.Enums.AritmeticTypeEnum.Matrix:
                    nmColumns_A.Visible = true;
                    nmRows_A.Visible = true;
                    break;
            }
        }

        private void cmbTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventDisable)
                return;
            switch (((AritmeticType)cmbTypeB.SelectedItem).Aritmetc)
            {
                case Model.Enums.AritmeticTypeEnum.Number:
                    nmColumns_B.Visible = false;
                    nmRows_B.Visible = false;
                    break;
                case Model.Enums.AritmeticTypeEnum.Vector:
                    nmColumns_B.Visible = false;
                    nmRows_B.Visible = true;
                    break;
                case Model.Enums.AritmeticTypeEnum.Matrix:
                    nmColumns_B.Visible = true;
                    nmRows_B.Visible = true;
                    break;
            }
        }

        private void btnCreate_1_Click(object sender, EventArgs e)
        {
            ClearA();
            switch (((AritmeticType)cmbTypeA.SelectedItem).Aritmetc)
            {
                case Model.Enums.AritmeticTypeEnum.Number:
                    var n = new Number(0);
                    var nc = new NumberControl(n, pnlA);
                    nc.Grid.ContextMenuStrip = cntxMenu;
                    break;
                case Model.Enums.AritmeticTypeEnum.Vector:
                    var v = new Vector((int)nmRows_A.Value);
                    var vc = new VectorControl(v, pnlA);
                    vc.Grid.ContextMenuStrip = cntxMenu;
                    break;
                case Model.Enums.AritmeticTypeEnum.Matrix:
                    var m = new Matrix((int)nmRows_A.Value, (int)nmColumns_A.Value);
                    var mnc = new MatrixControl(m, pnlA);
                    mnc.Grid.ContextMenuStrip = cntxMenu;
                    break;
            }
            ArrangeControls();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AritmeticsService.CopiedEntity == null)
                return;

            Control ctrl = cntxMenu.SourceControl;
            Control container = null;
            if (ctrl == pnlA || ctrl.Parent == pnlA)
            {
                container = pnlA;
                ClearA();
            }
            else if (ctrl == pnlB || ctrl.Parent == pnlB)
            {
                container = pnlB;
                ClearB();
            }
            else if (ctrl == pnlResult || ctrl.Parent == pnlResult)
            {
                container = pnlResult;
                ClearResult();
            }
            if (container == null)
                return;
            AritmeticControl ac = null;
            if (AritmeticsService.CopiedEntity is Number)
                ac = new NumberControl((Number)AritmeticsService.CopiedEntity, container);
            else if (AritmeticsService.CopiedEntity is Vector)
                ac = new VectorControl((Vector)AritmeticsService.CopiedEntity, container);
            else if (AritmeticsService.CopiedEntity is Matrix)
                ac = new MatrixControl((Matrix)AritmeticsService.CopiedEntity, container);

            if (ac != null)
                ac.Grid.ContextMenuStrip = cntxMenu;

            ArrangeControls();
        }

        private void btnCreate_2_Click(object sender, EventArgs e)
        {
            ClearB();
            switch (((AritmeticType)cmbTypeB.SelectedItem).Aritmetc)
            {
                case Model.Enums.AritmeticTypeEnum.Number:
                    var n = new Number(0);
                    var nc = new NumberControl(n, pnlB);
                    nc.Grid.ContextMenuStrip = cntxMenu;
                    break;
                case Model.Enums.AritmeticTypeEnum.Vector:
                    var v = new Vector((int)nmRows_B.Value);
                    var vc = new VectorControl(v, pnlB);
                    vc.Grid.ContextMenuStrip = cntxMenu;
                    break;
                case Model.Enums.AritmeticTypeEnum.Matrix:
                    var m = new Matrix((int)nmRows_B.Value, (int)nmColumns_B.Value);
                    var mnc = new MatrixControl(m, pnlB);
                    mnc.Grid.ContextMenuStrip = cntxMenu;
                    break;
            }
            ArrangeControls();
        }

        private void btnCalculateVector_Click(object sender, EventArgs e)
        {
            CalculateVector();
        }

        private void cntxMenu_Opening(object sender, CancelEventArgs e)
        {
            var control = cntxMenu.SourceControl;
            if(control== pnlA || control == pnlA || control == pnlResult)
            {
                copyToolStripMenuItem.Visible = false;
                pasteToolStripMenuItem.Visible = true;
            }
            else
            {
                copyToolStripMenuItem.Visible = true;
                pasteToolStripMenuItem.Visible = true;
            }

            if (AritmeticsService.CopiedEntity == null)
                pasteToolStripMenuItem.Enabled = false;
            else
                pasteToolStripMenuItem.Enabled = true;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = cntxMenu.SourceControl;
            var ac = ctrl.Parent.Tag as AritmeticControl;
            if (ac != null)
                AritmeticsService.CopiedEntity = ac.Entity;
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

            cmbTypeA.DataSource = new List<AritmeticType>(AritmeticsService.Types);
            cmbTypeA.SelectedIndex = 0;

            cmbTypeB.DataSource = new List<AritmeticType>(AritmeticsService.Types);
            cmbTypeB.SelectedIndex = 0;

            cmbVectorOperation.DataSource = AritmeticsService.VectorOperations;
            cmbVectorOperation.SelectedIndex = 0;

        }

        private void CalculateVector()
        {
            AritmeticControl ac = null;
            AritmeticControl bc = null;

            if (pnlA.Controls.Count != 0)
                ac = pnlA.Tag as AritmeticControl;
            if (pnlB.Controls.Count != 0)
                bc = pnlB.Tag as AritmeticControl;

            if (ac == null)
            {
                MessageBox.Show(this, "Variable A not defined!", "Calculate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bc == null)
            {
                MessageBox.Show(this, "Variable B not defined!", "Calculate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseMathEntity result = null;

            try
            {
                result = AritmeticsService.CalculateVector((VectorOperation)cmbVectorOperation.SelectedItem, ac.Entity, bc.Entity);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message,"Calculate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (result == null)
                return;

            ClearResult();
            AritmeticControl rc = null;
            if (result is Number)
                rc = new NumberControl((Number)result, pnlResult);
            else if (result is Vector)
                rc = new VectorControl((Vector)result, pnlResult);
            else if (result is Matrix)
                rc = new MatrixControl((Matrix)result, pnlResult);
            if (rc != null)
                rc.Grid.ContextMenuStrip = cntxMenu;
        }

        private void ClearA()
        {
            for (int i = pnlA.Controls.Count - 1; i >= 0; --i)
            {
                var control = pnlA.Controls[i];
                pnlA.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void ClearB()
        {
            for (int i = pnlB.Controls.Count - 1; i >= 0; --i)
            {
                var control = pnlB.Controls[i];
                pnlB.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void ClearResult()
        {
            for (int i = pnlResult.Controls.Count - 1; i >= 0; --i)
            {
                var control = pnlResult.Controls[i];
                pnlResult.Controls.Remove(control);
                control.Dispose();
            }
        }

        public void ArrangeControls()
        {
            int top = 63;
            int gap = 6;

            int maxHeight = pnlA.Height;
            if (pnlB.Height > maxHeight)
                maxHeight = pnlB.Height;
            if (cmbVectorOperation.Height > maxHeight)
                maxHeight = cmbVectorOperation.Height;

            pnlA.Location = new Point(pnlA.Location.X, top + (maxHeight - pnlA.Height) / 2);

            cmbVectorOperation.Location = new Point(pnlA.Location.X + pnlA.Width + gap, top + (maxHeight - cmbVectorOperation.Height) / 2);

            pnlB.Location = new Point(cmbVectorOperation.Location.X + cmbVectorOperation.Width + gap, top + (maxHeight - pnlB.Height) / 2);

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

        
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new Matrix(3, 3);

            m.Components[1, 1] = new Number(2, -3);

            var nc = new MatrixControl(m, pnlA);
        }

        
    }
}
