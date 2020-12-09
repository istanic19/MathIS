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
    public class VectorControl : AritmeticControl
    {
        private Vector _vector;

        public Vector Vector
        {
            get { return _vector; }
        }

        public VectorControl(Vector vector, Control parent) : base(parent, vector)
        {
            _vector = vector;
            InitializeDataGrid();
        }


        protected override void InitializeData()
        {
            for (int i = 0; i < _vector.Components.Count; ++i)
            {
                var column = new System.Windows.Forms.DataGridViewTextBoxColumn();
                column.Name = string.Format("col_{0}", 1);
                column.DefaultCellStyle = dataGridViewCellStyle1;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                _dataGrid.Columns.Add(column);
            }

            _dataGrid.Rows.Add();

            for (int i = 0; i < _vector.Components.Count; ++i)
            {
                _dataGrid.Rows[0].Cells[i].Tag = _vector.Components.ElementAt(i);
                _dataGrid.Rows[0].Cells[i].Value = _vector.Components.ElementAt(i).ToString(false);
            }
        }

        


    }
}
