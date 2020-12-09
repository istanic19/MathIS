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
    public class MatrixControl : AritmeticControl
    {
        private Matrix _matrix;

        public Matrix Matrix
        {
            get { return _matrix; }
        }

        public MatrixControl(Matrix matrix, Control parent) : base(parent, matrix)
        {
            _matrix = matrix;
            InitializeDataGrid();
        }

        
        protected override void InitializeData()
        {
            for (int i = 0; i < _matrix.Columns; ++i)
            {
                var column = new System.Windows.Forms.DataGridViewTextBoxColumn();
                column.Name = string.Format("col_{0}", 1);
                column.DefaultCellStyle = dataGridViewCellStyle1;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                _dataGrid.Columns.Add(column);
            }

            for (int i = 0; i < _matrix.Rows; ++i)
            {
                _dataGrid.Rows.Add();
                for (int j = 0; j < _matrix.Columns; ++j)
                {
                    _dataGrid.Rows[i].Cells[j].Tag = _matrix.Components[i, j];
                    _dataGrid.Rows[i].Cells[j].Value = _matrix.Components[i, j].ToString(false);
                }
            }
        }

        
        
    }
}
