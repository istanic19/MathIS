using MathIS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.UI
{
    public class NumberControl : AritmeticControl
    {
        private Number _number;

        public Number Number
        {
            get { return _number; }
        }

        public NumberControl(Number number, Control parent) : base(parent, number)
        {
            _number = number;
            InitializeDataGrid();
        }


        protected override void InitializeData()
        {
            var column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            column.Name = string.Format("col_{0}", 1);
            column.DefaultCellStyle = dataGridViewCellStyle1;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            _dataGrid.Columns.Add(column);

            _dataGrid.Rows.Add();

            _dataGrid.Rows[0].Cells[0].Tag = _number;
            _dataGrid.Rows[0].Cells[0].Value = _number.ToString(false);
        }
    }
}
