using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class CameraEventArgs : EventArgs
    {
        public Camera Camera { get; set; }
    }
}
