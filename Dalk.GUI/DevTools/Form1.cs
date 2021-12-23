using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fn = textBox1.Text;
            var n = fn.Split('.').LastOrDefault();
            textBox2.Text = $@"
        [Category(""Dalk.GUI.Wpf"")]
        public Color {n}
        {{
            get
            {{
                return Color.FromArgb(
                    {fn}.A,
                    {fn}.R,
                    {fn}.G,
                    {fn}.B
                    );
            }}
            set
            {{
                {fn} = System.Drawing.Color.FromArgb(
                    value.A,
                    value.R,
                    value.G,
                    value.B
                    );
            }}
        }}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fn = textBox1.Text;
            var n = fn.Split('.').LastOrDefault();
            textBox2.Text = $@"
        [Category(""Dalk.GUI.Wpf"")]
        public BitmapSource {n}
        {{
            get
            {{
                using (var ms = new MemoryStream())
                {{
                    {fn}.Save(ms, ImageFormat.Bmp);
                    ms.Seek(0, SeekOrigin.Begin);

                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = ms;
                    bitmapImage.EndInit();
                    return bitmapImage;
                }}
            }}
            set
            {{
                var srs = value;
                int width = srs.PixelWidth;
                int height = srs.PixelHeight;
                int stride = width * ((srs.Format.BitsPerPixel + 7) / 8);
                IntPtr ptr = IntPtr.Zero;
                try
                {{
                    ptr = Marshal.AllocHGlobal(height * stride);
                    srs.CopyPixels(new Int32Rect(0, 0, width, height), ptr, height * stride, stride);
                    using (var btm = new System.Drawing.Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format1bppIndexed, ptr))
                    {{
                        {fn} = new System.Drawing.Bitmap(btm);
                    }}
                }}
                finally
                {{
                    if (ptr != IntPtr.Zero)
                        Marshal.FreeHGlobal(ptr);
                }}
            }}
        }}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fn = textBox1.Text;
            var n = fn.Split('.').LastOrDefault();
            textBox2.Text = $@"
        [Category(""Dalk.GUI.Wpf"")]
        public string {n}
        {{
            get
            {{
                return {fn};
            }}
            set
            {{
                {fn} = value;
            }}
        }}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fn = textBox1.Text;
            var n = fn.Split('.').LastOrDefault();
            textBox2.Text = $@"
        [Category(""Dalk.GUI.Wpf"")]
        public int {n}
        {{
            get
            {{
                return {fn};
            }}
            set
            {{
                {fn} = value;
            }}
        }}";
        }
    }
}
