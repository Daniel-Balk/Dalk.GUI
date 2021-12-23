using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalk.GUI
{
    public class MultistateControl : Control
    {
        public event StateEventHandler StateHasChanged;
        public ControlState State { get; set; } = ControlState.Default;
        private bool Hover { get; set; }
        private bool Clicking { get; set; }
        private bool Clicked { get; set; }
        public virtual void OnStateHasChanged(ControlState state)
        {
            State = state;
            StateHasChanged?.Invoke(this, new StateEventArgs(state));
        }
        private void CheckState()
        {
            ControlState news = ControlState.Default;
            if (Clicked)
                news = ControlState.Pressed;
             if (Hover)
                news = ControlState.Hover;
            if (Clicking)
                news = ControlState.Pressing;
           
            if(news != State)
                OnStateHasChanged(news);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Hover = true;
            CheckState();
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left | e.Button == MouseButtons.Middle | e.Button == MouseButtons.Right)
            {
                Clicking = true;
                Clicked = true;
            }
            CheckState();
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Clicking = false;
            CheckState();
            base.OnMouseUp(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            Hover = false;
            CheckState();
            base.OnMouseLeave(e);
        }
    }
}