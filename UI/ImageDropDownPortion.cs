using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathIS.UI
{
    public delegate void ToolStripDropDownEventDelegate(object sender, EventArgs e);

    public delegate void ToolStripDropDownWMEventDelegate(object sender, WinMessageEventArgs e);
    internal class ImageDropDownPortion : ToolStripDropDown
    {
        internal event ToolStripDropDownEventDelegate DropDownActivated;
        internal event ToolStripDropDownEventDelegate KeyUp;


        /*protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }*/

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case NativeMethods.WM_ACTIVATE:
                    int action = (int)(m.WParam.ToInt64() & 0xFFFF);
                    if (action == NativeMethods.WA_ACTIVE)
                    {
                        if (DropDownActivated != null)
                            DropDownActivated(this, new EventArgs());
                    }
                    break;
                case NativeMethods.WM_KEYUP:
                    if (KeyUp != null)
                        KeyUp(this, new EventArgs());
                    break;
            }

            if (InternalProcessResizing(ref m, false))
            {
                return;
            }

            /*const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 &&
                    pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);

                    return;
                }
            }*/


            base.WndProc(ref m);
        }



        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool InternalProcessResizing(ref Message m, bool contentControl)
        {
            if (m.Msg == NativeMethods.WM_NCHITTEST)
            {
                return OnNcHitTest(ref m, contentControl);
            }
            else if (m.Msg == NativeMethods.WM_GETMINMAXINFO)
            {
                return OnGetMinMaxInfo(ref m);
            }
            return false;
        }
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool OnGetMinMaxInfo(ref Message m)
        {
            NativeMethods.MINMAXINFO minmax = (NativeMethods.MINMAXINFO)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.MINMAXINFO));
            if (!MaximumSize.IsEmpty)
            {
                minmax.maxTrackSize = MaximumSize;
            }
            minmax.minTrackSize = MinimumSize;
            Marshal.StructureToPtr(minmax, m.LParam, false);
            return true;
        }

        private bool OnNcHitTest(ref Message m, bool contentControl)
        {

            int x = Cursor.Position.X; // NativeMethods.LOWORD(m.LParam);
            int y = Cursor.Position.Y; // NativeMethods.HIWORD(m.LParam);
            Point clientLocation = PointToClient(new Point(x, y));

            GripBounds gripBouns = new GripBounds(contentControl ? _content.ClientRectangle : ClientRectangle);
            IntPtr transparent = new IntPtr(NativeMethods.HTTRANSPARENT);


            if (gripBouns.BottomRight.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTBOTTOMRIGHT;
                return true;
            }
            if (gripBouns.Bottom.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTBOTTOM;
                return true;
            }

            if (gripBouns.Right.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTRIGHT;
                return true;
            }
            return false;
        }

        private System.Windows.Forms.Control _content;
        private System.Windows.Forms.ToolStripControlHost _host;
        internal Size _minimumSize;

        public ImageDropDownPortion(System.Windows.Forms.Control content, Size minimumSize)
        {
            //Basic setup...
            this.AutoSize = false;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            this._content = content;
            this._host = new System.Windows.Forms.ToolStripControlHost(content);
            content.Location = new Point(8, 0);
            content.Size = new Size(Width, Height - 3);

            AutoSize = false;
            DoubleBuffered = true;
            ResizeRedraw = true;

            //Positioning and Sizing
            this.MinimumSize = minimumSize;
            //this.MaximumSize = content.Size;
            //this.Size = content.Size;
            content.Location = Point.Empty;

            this.Margin = Padding.Empty;
            Padding = Margin = _host.Padding = _host.Margin = Padding.Empty;



            //Add the host to the list)
            this.Items.Add(this._host);

            content.Disposed += (sender, e) =>
            {
                content = null;
                Dispose(true);
            };
            //content.RegionChanged += (sender, e) => UpdateRegion();
            //UpdateRegion();
        }

        protected void UpdateRegion()
        {
            if (Region != null)
            {
                Region.Dispose();
                Region = null;
            }
            if (_content.Region != null)
            {
                Region = _content.Region.Clone();
            }
        }



        internal void SizePanel()
        {
            _content.Size = new Size(Width - 2, Height - 10);
            _content.Location = new Point(1, 1);
        }

        internal void SizePanel(Panel panel)
        {
            panel.Size = new Size(Width - 7, Height - 10);

            panel.Location = new Point(1, 1);
            _content.Size = new Size(Width - 3, Height - 10);
            _content.Location = new Point(1, 1);

        }
    }

    public class WinMessageEventArgs : EventArgs
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
    }

    internal struct GripBounds
    {
        private const int GripSize = 6;
        private const int CornerGripSize = GripSize << 1;

        public GripBounds(Rectangle clientRectangle)
        {
            this.clientRectangle = clientRectangle;
        }

        private Rectangle clientRectangle;
        public Rectangle ClientRectangle
        {
            get { return clientRectangle; }
            //set { clientRectangle = value; }
        }

        public Rectangle Bottom
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - GripSize + 1;
                rect.Height = GripSize;
                return rect;
            }
        }

        public Rectangle BottomRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - CornerGripSize + 1;
                rect.Height = CornerGripSize;
                rect.X = rect.Width - CornerGripSize + 1;
                rect.Width = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Top
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = GripSize;
                return rect;
            }
        }

        public Rectangle TopRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = CornerGripSize;
                rect.X = rect.Width - CornerGripSize + 1;
                rect.Width = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Left
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = GripSize;
                return rect;
            }
        }

        public Rectangle BottomLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CornerGripSize;
                rect.Y = rect.Height - CornerGripSize + 1;
                rect.Height = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Right
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.X = rect.Right - GripSize + 1;
                rect.Width = GripSize;
                return rect;
            }
        }

        public Rectangle TopLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CornerGripSize;
                rect.Height = CornerGripSize;
                return rect;
            }
        }
    }
}
