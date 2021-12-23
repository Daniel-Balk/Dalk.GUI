using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalk.GUI
{
    public class LibraryControl : MultistateControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            OnStateHasChanged(State);
            base.OnPaint(e);
        }
        public LibraryControl()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}
