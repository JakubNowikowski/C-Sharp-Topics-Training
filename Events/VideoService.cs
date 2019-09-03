using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class VideoService
    {
        public void OnCameraFocussed(object source, CameraEventArgs e)
        {
            Console.WriteLine("Video Service: Shooting video..." + e.Camera.Name);
        }
    }
}
