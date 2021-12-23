using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalk.GUI
{
    public static class Extension
    {
        public static Region ToRegion(this GraphicsPath gp)
        {
            return new Region(gp);
        }
    }
}
