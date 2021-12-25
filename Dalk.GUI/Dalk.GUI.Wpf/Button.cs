using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dalk.GUI.Wpf
{
    public class Button : WindowsFormsHost
    {
        static Button()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Button), new FrameworkPropertyMetadata(typeof(Button)));
            
        }
        public Button()
        {
            ButtonText = "New Button";
            BackgroundColor = Color.FromRgb(19, 154, 67);
            HoverBackgroundColor = Color.FromRgb(13, 171, 118);
            TextColor = Color.FromRgb(255, 255, 255);
            UIControl.Click += new EventHandler((s, e) =>
            {
                ButtonClick?.Invoke(s, e);
            });
        }
        private GUI.Button UIControl { get; set; } = new GUI.Button();
        protected override void OnInitialized(EventArgs e)
        {
            Child = UIControl;
            base.OnInitialized(e);
        }
        [Category("Dalk.GUI.Wpf")]
        public Color BackgroundColor
        {
            get
            {
                return Color.FromArgb(
                    UIControl.BackgroundColor.A,
                    UIControl.BackgroundColor.R,
                    UIControl.BackgroundColor.G,
                    UIControl.BackgroundColor.B
                    );
            }
            set
            {
                UIControl.BackgroundColor = System.Drawing.Color.FromArgb(
                    value.A,
                    value.R,
                    value.G,
                    value.B
                    );
            }
        } 
        [Category("Dalk.GUI.Wpf")]
        public Color HoverBackgroundColor
        {
            get
            {
                return Color.FromArgb(
                    UIControl.HoverBackgroundColor.A,
                    UIControl.HoverBackgroundColor.R,
                    UIControl.HoverBackgroundColor.G,
                    UIControl.HoverBackgroundColor.B
                    );
            }
            set
            {
                UIControl.HoverBackgroundColor = System.Drawing.Color.FromArgb(
                    value.A,
                    value.R,
                    value.G,
                    value.B
                    );
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public Color TextColor
        {
            get
            {
                return Color.FromArgb(
                    UIControl.TextColor.A,
                    UIControl.TextColor.R,
                    UIControl.TextColor.G,
                    UIControl.TextColor.B
                    );
            }
            set
            {
                UIControl.TextColor = System.Drawing.Color.FromArgb(
                    value.A,
                    value.R,
                    value.G,
                    value.B
                    );
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public BitmapSource Image
        {
            get
            {
                using (var ms = new MemoryStream())
                {
                    UIControl.Image.Save(ms, ImageFormat.Bmp);
                    ms.Seek(0, SeekOrigin.Begin);

                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = ms;
                    bitmapImage.EndInit();
                    return bitmapImage;
                }
            }
            set
            {
                var srs = value;
                int width = srs.PixelWidth;
                int height = srs.PixelHeight;
                int stride = width * ((srs.Format.BitsPerPixel + 7) / 8);
                IntPtr ptr = IntPtr.Zero;
                try
                {
                    ptr = Marshal.AllocHGlobal(height * stride);
                    srs.CopyPixels(new Int32Rect(0, 0, width, height), ptr, height * stride, stride);
                    using (var btm = new System.Drawing.Bitmap(width, height, stride, System.Drawing.Imaging.PixelFormat.Format1bppIndexed, ptr))
                    {
                        UIControl.Image = new System.Drawing.Bitmap(btm);
                    }
                }
                finally
                {
                    if (ptr != IntPtr.Zero)
                        Marshal.FreeHGlobal(ptr);
                }
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public string ButtonText
        {
            get
            {
                return UIControl.ButtonText;
            }
            set
            {
                UIControl.ButtonText = value;
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public int BorderRadius
        {
            get
            {
                return UIControl.BorderRadius;
            }
            set
            {
                UIControl.BorderRadius = value;
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public int ImageHeight
        {
            get
            {
                return UIControl.ImageHeight;
            }
            set
            {
                UIControl.ImageHeight = value;
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public int ImageWidth
        {
            get
            {
                return UIControl.ImageWidth;
            }
            set
            {
                UIControl.ImageWidth = value;
            }
        }
        [Category("Dalk.GUI.Wpf")]
        public int ImageMargin
        {
            get
            {
                return UIControl.ImageMargin;
            }
            set
            {
                UIControl.ImageMargin = value;
            }
        }

        public event EventHandler ButtonClick;
    }
}
