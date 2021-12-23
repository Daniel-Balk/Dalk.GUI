using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalk.GUI
{
    public class Button : LibraryControl
    {
        [Category("Dalk.GUI")]
        public Color BackgroundColor { get; set; } = Color.FromArgb(19, 154, 67);
        [Category("Dalk.GUI")]
        public Color HoverBackgroundColor { get; set; } = Color.FromArgb(13, 171, 118);
        [Category("Dalk.GUI")]
        public Color TextColor { get; set; } = Color.White;
        [Category("Dalk.GUI")]
        public string ButtonText { get; set; }
        [Category("Dalk.GUI")]
        public int BorderRadius { get; set; } = 15;
        [Category("Dalk.GUI")]
        public Image Image { get; set; }
        [Category("Dalk.GUI")]
        public int ImageHeight { get; set; } = 20;
        [Category("Dalk.GUI")]
        public int ImageWidth { get; set; } = 20;
        [Category("Dalk.GUI")]
        public int ImageMargin { get; set; } = 8;

        public Button()
        {
            DoubleBuffered = true;
            Height = 32;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            cg = false;
            OnStateHasChanged(State);
        }
        bool cg = true;
        public override void OnStateHasChanged(ControlState state)
        {
            base.OnStateHasChanged(state);
            if (cg)
            {
                g = CreateGraphics();
            }
            else
            {
                cg = true;
            }
            switch (state)
            {
                case ControlState.Hover:
                    Hover();
                    break;
                case ControlState.Pressed:
                    Default();
                    break;
                case ControlState.Pressing:
                    Default();
                    break;
                case ControlState.Default:
                    Default();
                    break;
            }
        }
        Graphics g;
        private void Default()
        {
            Draw(BackgroundColor);
        }

        private void Hover()
        {
            Draw(HoverBackgroundColor);
        }

        private void Draw(Color backgroundColor)
        {
            // Background
            g.Clear(BackColor);
            var rgn = RoundedRectangle.Create(0, 0, Width, Height, BorderRadius).ToRegion();
            g.FillRegion(new SolidBrush(backgroundColor), rgn);
            rgn.Dispose();

            // Text
            var tms = g.MeasureString(ButtonText, Font);
            var iw = 0;
            if (Image != null)
                iw = ImageWidth + ImageMargin;
            var xw = tms.Width;
            var xh = tms.Height;
            var tx = Width / 2 - xw / 2 + iw / 2;
            var ty = Height / 2 - xh / 2;
            g.DrawString(ButtonText, Font, new SolidBrush(TextColor), tx, ty);

            // Image
            if (Image != null)
            {
                var ix = tx - ImageWidth - ImageMargin;
                var iy = Height / 2 - ImageHeight / 2;
                g.DrawImage(Image, ix, iy, ImageWidth, ImageHeight);
            }
        }
    }
}