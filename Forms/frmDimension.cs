using MathIS.Services;
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
    public partial class frmDimension : Form
    {
        #region Fields
        private bool _matrix;
        private List<Keys> _availableKeys;
        private Point _location;

        private int? _dimensions;
        private Tuple<int, int> _matrixOrder;

        public int? Dimensions
        {
            get { return _dimensions; }
        }

        public Tuple<int, int> MatrixOrder
        {
            get { return _matrixOrder; }
        }

        #endregion

        #region Constructor
        public frmDimension(bool matrix, Point location)
        {
            _location = location;
            _matrix = matrix;
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void frmDimension_Load(object sender, EventArgs e)
        {
            LoadData();
            Location = _location;
        }

        private void frmDimension_Shown(object sender, EventArgs e)
        {
            nmValueRow.Focus();
            nmValueRow.Select(0, 100);
        }

        private void nmValueRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (!_matrix)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    OnEnter();
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    nmValueColumn.Focus();
                    nmValueColumn.Select(0, 100);
                }
            }
        }

        private void nmValueColumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OnEnter();
            }
        }

        
        private void frmDimension_DoubleClick(object sender, EventArgs e)
        {
            OnEnter();
        }

        private void lblDim_DoubleClick(object sender, EventArgs e)
        {
            OnEnter();
        }

        private void frmDimension_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            _availableKeys = new List<Keys>();
            for (int i = 0; i < 10; ++i)
            {
                _availableKeys.Add((Keys)(48 + i));
                _availableKeys.Add((Keys)(96 + i));
            }
            _availableKeys.Add(Keys.Up);
            _availableKeys.Add(Keys.Down);
            _availableKeys.Add(Keys.Left);
            _availableKeys.Add(Keys.Right);
            _availableKeys.Add(Keys.Delete);
            _availableKeys.Add(Keys.Back);

            if (!_matrix)
            {
                nmValueColumn.Visible = false;
                nmValueRow.Size = new Size(nmValueRow.Width + 10, nmValueRow.Height);

                nmValueRow.Value = AppSettings.Dimensions.VectorDimensions;
            }
            else
            {
                nmValueRow.Value = AppSettings.Dimensions.MatrixRows;
                nmValueColumn.Value = AppSettings.Dimensions.MatrixColumns;
            }
        }

        private void OnEnter()
        {
            if (_matrix)
            {
                _matrixOrder = new Tuple<int, int>((int)nmValueRow.Value, (int)nmValueColumn.Value);
                AppSettings.Dimensions.MatrixRows = (int)nmValueRow.Value;
                AppSettings.Dimensions.MatrixColumns = (int)nmValueColumn.Value;
            }
            else
            {
                _dimensions = (int)nmValueRow.Value;
                AppSettings.Dimensions.VectorDimensions = (int)nmValueRow.Value;
            }

            this.Close();
        }

        

        protected override void WndProc(ref Message m)
        {
            //134 = WM_NCACTIVATE
            if (m.Msg == 134)
            {
                //Check if other app is activating - if so, we do not close         
                if (m.LParam == IntPtr.Zero)
                {
                    if (m.WParam != IntPtr.Zero)
                    {
                        //Other form in our app has focus
                        this.Close();
                    }

                }
            }

            base.WndProc(ref m);
            
        }






        #endregion

        
    }
}
