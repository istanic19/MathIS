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
            txtDim.Focus();
            txtDim.SelectAll();
        }

        private void txtDim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OnEnter();
            }
            else
            {
                if (!_availableKeys.Contains(e.KeyCode))
                    e.SuppressKeyPress = true;
                if (txtDim.Text.Contains(",") && e.KeyCode == Keys.Oemcomma)
                    e.SuppressKeyPress = true;
            }
        }

        private void frmDimension_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            /*48-57, 96-105   -numbers
             
             */
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

            if (_matrix)
            {
                _availableKeys.Add(Keys.Oemcomma);
                txtDim.Text = "2,2";
            }
            else
            {
                txtDim.Text = "2";
            }


        }

        private void OnEnter()
        {
            if (_matrix)
            {
                var s = txtDim.Text.Trim().Split(',');
                if (s.Length != 2)
                {
                    HandleError("Invalid input");
                    return;
                }

                if (!int.TryParse(s[0], out var rows) || rows < 2)
                {
                    HandleError("Minimum row number is 2");
                    return;
                }
                if (!int.TryParse(s[1], out var columns) || columns < 2)
                {
                    HandleError("Minimum column number is 2");
                    return;
                }

                _matrixOrder = new Tuple<int, int>(rows, columns);


            }
            else
            {
                if (!int.TryParse(txtDim.Text.Trim(), out var result) || result < 2)
                {
                    HandleError("Invalid input");
                    return;
                }
                else
                {
                    _dimensions = result;
                }
            }

            this.Close();
        }

        private void HandleError(string message)
        {
            if(_matrix)
            {
                txtDim.Text = "2,2";
            }
            else
            {
                txtDim.Text = "2";
            }
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
