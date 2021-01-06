using MathIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.Forms
{
    public partial class frmOptions : Form
    {
        #region Fields
        private AppSettings _settings; 
        #endregion

        #region Event Handlers
        private void frmOptions_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _settings.Precision = (int)nmPrecision.Value;
            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Constructor
        public frmOptions(AppSettings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            nmPrecision.Value = _settings.Precision;
        }

        #endregion

    }
}
