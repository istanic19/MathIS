using MathIS.Components;
using MathIS.Model.Entities;
using MathIS.Model.Enums;
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions form = new frmOptions(_settings);
            form.ShowDialog(this);
        }

        #endregion

        private void resultTo_checkedChanged(object sender, EventArgs e)
        {
            if (EventDisable)
                return;
            Control c = sender as Control;

            EventDisable++;
            if (c == cb_rbresult_Default)
            {
                if (cb_rbresult_Default.Checked)
                {
                    cb_rbresult_A.Checked = false;
                    cb_rbresult_B.Checked = false;
                }
                else
                {
                    cb_rbresult_A.Checked = true;
                    cb_rbresult_B.Checked = false;
                }
            }
            else if (c == cb_rbresult_A)
            {
                if (cb_rbresult_A.Checked)
                {
                    cb_rbresult_Default.Checked = false;
                    cb_rbresult_B.Checked = false;
                }
                else
                {
                    cb_rbresult_Default.Checked = true;
                    cb_rbresult_B.Checked = false;
                }
            }
            else if (c == cb_rbresult_B)
            {
                if (cb_rbresult_B.Checked)
                {
                    cb_rbresult_Default.Checked = false;
                    cb_rbresult_A.Checked = false;
                }
                else
                {
                    cb_rbresult_Default.Checked = true;
                    cb_rbresult_A.Checked = false;
                }
            }
            EventDisable--;
        }

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

              
        private void num_A_Click(object sender, EventArgs e)
        {
            ClearA();
            var n = new Number(0);
            var nc = new NumberControl(n, pnlA);
            nc.Grid.ContextMenuStrip = cntxMenu;
            nc.Grid.Focus();
            ArrangeControls();
        }

        private void vector_A_Click(object sender, EventArgs e)
        {
            var result = GetVectorDimensions(sender as Control);
            if (!result.HasValue)
            {
                return;
            }
            ClearA();
            var v = new Vector(result.Value);
            var vc = new VectorControl(v, pnlA);
            vc.Grid.ContextMenuStrip = cntxMenu;
            vc.Grid.Focus();
            ArrangeControls();
        }

        private void matrix_A_Click(object sender, EventArgs e)
        {
            var result = GetMatrixDimensions(sender as Control);
            if (result == null)
            {
                return;
            }
            ClearA();
            var m = new Matrix(result.Item1, result.Item2);
            var mnc = new MatrixControl(m, pnlA);
            mnc.Grid.ContextMenuStrip = cntxMenu;
            mnc.Grid.Focus();
            ArrangeControls();
        }

        private void num_B_Click(object sender, EventArgs e)
        {
            ClearB();
            var n = new Number(0);
            var nc = new NumberControl(n, pnlB);
            nc.Grid.ContextMenuStrip = cntxMenu;
            nc.Grid.Focus();
            ArrangeControls();
        }

        private void vector_B_Click(object sender, EventArgs e)
        {
            var result = GetVectorDimensions(sender as Control);
            if (!result.HasValue)
            {
                return;
            }
            ClearB();
            var v = new Vector(result.Value);
            var vc = new VectorControl(v, pnlB);
            vc.Grid.ContextMenuStrip = cntxMenu;
            vc.Grid.Focus();
            ArrangeControls();
        }

        private void matrix_B_Click(object sender, EventArgs e)
        {
            var result = GetMatrixDimensions(sender as Control);
            if (result == null)
            {
                return;
            }
            ClearB();
            var m = new Matrix(result.Item1, result.Item2);
            var mnc = new MatrixControl(m, pnlB);
            mnc.Grid.ContextMenuStrip = cntxMenu;
            mnc.Grid.Focus();
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

            var ac = CreateAritmeticControl(AritmeticsService.CopiedEntity, container);
            ac.Grid.Focus();

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
                conjugateToolStripMenuItem.Visible = false;
                normalizeToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                copyToolStripMenuItem.Visible = false;
                pasteToolStripMenuItem.Visible = true;
            }
            else
            {
                conjugateToolStripMenuItem.Visible = true;
                normalizeToolStripMenuItem.Visible = true;
                toolStripMenuItem1.Visible = true;
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

        private void conjugateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = cntxMenu.SourceControl;
            var ac = ctrl.Parent.Tag as AritmeticControl;
            if (ac != null)
            {
                BaseMathEntity conj = null;
                try
                {
                    conj = AritmeticsService.Conjugate(ac.Entity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Conjugate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

                var acC = CreateAritmeticControl(conj, container);
                acC.Grid.Focus();

                ArrangeControls();
            }
        }

        private void normalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = cntxMenu.SourceControl;
            var ac = ctrl.Parent.Tag as AritmeticControl;
            if (ac != null)
            {
                BaseMathEntity conj = null;
                try
                {
                    conj = AritmeticsService.Normalize(ac.Entity);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Normalize", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
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

                var acC = CreateAritmeticControl(conj, container);
                acC.Grid.Focus();

                ArrangeControls();
            }
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

            ddiOperation.Items.Add(new DropDownImageItem() { Image = Properties.Resources.Add, Text = "Add", Tag = new VectorOperation(VectorOperationEnum.Add) });
            ddiOperation.Items.Add(new DropDownImageItem() { Image = Properties.Resources.Subtract, Text = "Subtract", Tag = new VectorOperation(VectorOperationEnum.Subtract) });
            ddiOperation.Items.Add(new DropDownImageItem() { Image = Properties.Resources.Multiply, Text = "Multiply", Tag = new VectorOperation(VectorOperationEnum.Multiply) });
            ddiOperation.Items.Add(new DropDownImageItem() { Image = Properties.Resources.MatrixMultiply, Text = "Matrix multiply", Tag = new VectorOperation(VectorOperationEnum.MatrixMupltiply) });

            ddiOperation.SelectedItem = ddiOperation.Items[0];
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
                result = AritmeticsService.CalculateVector((VectorOperation)ddiOperation.SelectedItem.Tag, ac.Entity, bc.Entity);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message,"Calculate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (result == null)
                return;

            if(cb_rbresult_A.Checked)
            {
                ClearA();
                CreateAritmeticControl(result, pnlA);
                
            }
            else if(cb_rbresult_B.Checked)
            {
                ClearB();
                CreateAritmeticControl(result, pnlB);
            }
            else
            {
                ClearResult();
                CreateAritmeticControl(result, pnlResult);
                
            }

            ArrangeControls();


        }

        private AritmeticControl CreateAritmeticControl(BaseMathEntity entity, Control container)
        {
            AritmeticControl ac = null;
            if (entity is Number)
                ac = new NumberControl((Number)entity, container);
            else if (entity is Vector)
                ac = new VectorControl((Vector)entity, container);
            else if (entity is Matrix)
                ac = new MatrixControl((Matrix)entity, container);

            if (ac != null)
                ac.Grid.ContextMenuStrip = cntxMenu;

            return ac;
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
            int top = grpVarA.Location.Y + grpVarA.Height + 20;
            int gap = 6;

            int maxHeight = pnlA.Height;
            if (pnlB.Height > maxHeight)
                maxHeight = pnlB.Height;
            if (ddiOperation.Height > maxHeight)
                maxHeight = ddiOperation.Height;

            pnlA.Location = new Point(pnlA.Location.X, top + (maxHeight - pnlA.Height) / 2);

            ddiOperation.Location = new Point(pnlA.Location.X + pnlA.Width + gap, top + (maxHeight - ddiOperation.Height) / 2);

            pnlB.Location = new Point(ddiOperation.Location.X + ddiOperation.Width + gap, top + (maxHeight - pnlB.Height) / 2);

            int bottom = pnlA.Location.Y + pnlA.Height;
            if ((pnlB.Location.Y + pnlB.Height) > bottom)
                bottom = pnlB.Location.Y + pnlB.Height;

            pnlResult.Location = new Point(pnlResult.Location.X, bottom + 50);

            pnlBreakLine.Location = new Point(pnlBreakLine.Location.X, bottom + 25 - pnlBreakLine.Height / 2);
            pnlBreakLine.Size = new Size(pnlB.Location.X + pnlB.Width - pnlBreakLine.Location.X, pnlBreakLine.Height);

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

        private int? GetVectorDimensions(Control sender)
        {
            var location = sender.PointToScreen(new Point(sender.Width, 0));
            frmDimension frm = new frmDimension(false, location);
            frm.ShowDialog(this);

            return frm.Dimensions;
        }

        private Tuple<int,int> GetMatrixDimensions(Control sender)
        {
            var location = sender.PointToScreen(new Point(sender.Width, 0));
            frmDimension frm = new frmDimension(true, location);
            frm.ShowDialog(this);

            return frm.MatrixOrder;
        }





        #endregion

        
    }
}
