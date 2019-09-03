using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class PhotoService
    {
        public void OnCameraFocussed(object source, CameraEventArgs e)
        {
            Console.WriteLine("Photo service: Taking a photo..." + e.Camera.Name);
        }
    }
}
