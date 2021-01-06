using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.UI
{
    public partial class DropDownImage : UserControl
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _eventDisable = false;
        private ImageDropDownPortion _dropDown;
        private Panel _panelContainer;
        private List<DropDownImageItem> _items;
        private DropDownImageItem _selectedItem;

        public List<DropDownImageItem> Items
        {
            get { return _items; }
        }

        public DropDownImageItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SelecteItem(value);
            }
        }

        #endregion

        #region Event Handlers
        private void pbDisplay_Click(object sender, EventArgs e)
        {
            if (_dropDown == null || !_dropDown.Visible)
                ShowDropDown();
        }
        private void Pb_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            SelecteItem(ctrl.Tag as DropDownImageItem);
        }
        #endregion

        #region Constructor
        public DropDownImage()
        {
            _items = new List<DropDownImageItem>();
            InitializeComponent();
        }

        #endregion

        #region Methods

        internal void ShowDropDown()
        {
            bool init = false;
            if (_dropDown == null)
            {
                CreateDropDown();
                init = true;
            }


            SetDropDownSize();


            _eventDisable = true;
            
            _eventDisable = false;


            if (init)
            {
                // ReSharper disable PossibleNullReferenceException
                _dropDown.Size = new Size(_dropDown.Size.Width + 1, _dropDown.Size.Height);
                // ReSharper restore PossibleNullReferenceException
                _dropDown.Size = new Size(_dropDown.Size.Width - 1, _dropDown.Size.Height);
            }
            _dropDown.SizePanel();



            Point pt = PointToScreen(Location);


            _dropDown.Location = new Point(pt.X - Location.X, pt.Y + Height - Location.Y);

            if ((_dropDown.Location.Y + _dropDown.Height) > Screen.FromControl(this).WorkingArea.Height)
            {
                _dropDown.Location = new Point(_dropDown.Location.X, _dropDown.Location.Y - (_dropDown.Height + Height));
            }

            _dropDown.Show(_dropDown.Location);
            
        }

        private void SelecteItem(DropDownImageItem item)
        {
            if (_items.Contains(item) && _selectedItem != item)
            {
                _selectedItem = item;
                pbDisplay.Image = _selectedItem.Image;

                toolTip2.RemoveAll();
                toolTip2.SetToolTip(pbDisplay, _selectedItem.Text);
                
                
                if (_dropDown != null && _dropDown.Visible)
                {
                   _dropDown.Close();
                }
            }
        }

        private void SetDropDownSize()
        {
            if (_dropDown == null)
                return;


            _dropDown.Size = new Size(this.Width + 1, this.Height * Items.Count + 1);
        }

        private void CreateDropDown()
        {
            _panelContainer = new Panel();
            //panelContainer.BorderStyle = BorderStyle.FixedSingle;

            _panelContainer.Size = new Size(Width + 1, Height * Items.Count + 1);

            _panelContainer.Location = new Point(1, 1);

            _dropDown = new ImageDropDownPortion(_panelContainer, _panelContainer.Size);
            _dropDown._minimumSize = _dropDown.Size;

            //panelContainer.FormBorderStyle = FormBorderStyle.None;
            _dropDown.BackColor = BackColor;

            _dropDown.Size = new Size(_dropDown.Size.Width, _dropDown.Size.Height);

            for (int i = 0; i < Items.Count; ++i)
            {
                PictureBox pb = new PictureBox();
                pb.Cursor = Cursors.Hand;
                pb.Size = new Size(this.Width, this.Height);
                pb.Location = new Point(0, this.Height * i);
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                pb.Parent = _panelContainer;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Image = Items[i].Image;
                pb.Tag = Items[i];
                toolTip1.SetToolTip(pb, Items[i].Text);
                pb.Click += Pb_Click;

            }


        }

        


        #endregion


    }

    public class DropDownImageItem
    {
        public string Text { get; set; }
        public Image Image { get; set; }
        public object Tag { get; set; }
    }
}
