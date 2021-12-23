using System;

namespace Dalk.GUI
{
    public class StateEventArgs : EventArgs
    {
        public ControlState State { get; set; }
        public StateEventArgs(ControlState state)
        {
            State = state;
        }
    }
}