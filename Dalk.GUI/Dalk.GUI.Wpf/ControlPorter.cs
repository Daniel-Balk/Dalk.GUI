using System;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Dalk.GUI.Wpf
{

    public class ControlPorter : WindowsFormsHost
    {
        static ControlPorter()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlPorter), new FrameworkPropertyMetadata(typeof(ControlPorter)));
        }
        private System.Windows.Forms.Control UIControl { get; set; }
        protected override void OnInitialized(EventArgs e)
        {
            Child = UIControl;
            base.OnInitialized(e);
        }
    }
}
