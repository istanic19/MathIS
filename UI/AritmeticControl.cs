using MathIS.Forms;
using MathIS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.UI
{
    public abstract class AritmeticControl
    {
        protected DataGridViewEx _dataGrid;
        protected Control _parentContainer;
        protected DataGridViewCellStyle dataGridViewCellStyle1;
        private BaseMathEntity _aritmeticObject;

        public BaseMathEntity Entity
        {
            get { return _aritmeticObject; }
        }

        public DataGridViewEx Grid
        {
            get { return _dataGrid; }
        }

        public AritmeticControl(Control parent, BaseMathEntity aritmeticObject)
        {
            _aritmeticObject = aritmeticObject;
            _parentContainer = parent;
            _parentContainer.Tag = this;
        }

        protected void InitializeDataGrid()
        {
            _dataGrid = new DataGridViewEx();
            _dataGrid.AllowUserToResizeColumns = false;
            _dataGrid.AllowUserToResizeRows = false;
            _dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            _dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGrid.ColumnHeadersVisible = false;
            _dataGrid.AllowUserToAddRows = false;
            _dataGrid.RowHeadersVisible = false;
            _dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            _dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            _dataGrid.Tag = _aritmeticObject;
            _dataGrid.Location = new Point(0, 0);
 
            dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            InitializeData();

            _dataGrid.Parent = _parentContainer;

            AdjustSize();

            _dataGrid.CellEndEdit += _dataGrid_CellEndEdit;
            _dataGrid.KeyDown += _dataGrid_KeyDown;
        }

        private void _dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _dataGrid.EndEdit();
                e.Handled = true;
            }
        }

        protected virtual void InitializeData()
        {
            
        }

        private void AdjustSize()
        {
            int width = 3;

            foreach (DataGridViewCell cell in _dataGrid.Rows[0].Cells)
                width += cell.Size.Width;

            int h = _dataGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            _dataGrid.Size = new Size(width, h + 3);

            _parentContainer.Size = new Size(_dataGrid.Width + 2, _dataGrid.Height + 2);
        }

        private void _dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = _dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var originlNum = cell.Tag as Number;
            var num = Number.ParseFrom(cell.Value.ToString());
            if (num != null)
            {
                originlNum.CopyFrom(num);
            }
            cell.Value = originlNum.ToString(false);
            AdjustSize();
            UpdateControls();
        }

        private void UpdateControls()
        {
            Control parent = _parentContainer;
            while (!(parent is frmMain))
            {
                parent = parent.Parent;
                if (parent == null)
                    break;
            }

            if (parent != null && parent is frmMain)
            {
                ((frmMain)parent).ArrangeControls();
            }
        }
    }
}
