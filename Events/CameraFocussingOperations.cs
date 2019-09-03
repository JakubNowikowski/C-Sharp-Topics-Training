using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class CameraFocussingOperations
    {
        // - Define Delegate
        // - Define an event based on delegate
        // - Raise an event

        // custom delegate
        //public delegate void CameraFocussedEventHandler(object source, CameraEventArgs args);
        //public event CameraFocussedEventHandler CameraFocussed;


        // shorter form with special EventHandler delegate
        public event EventHandler<CameraEventArgs> CameraFocussed;

        public void Focus(Camera camera)
        {
            Console.WriteLine("Focussing the camera...");
            Thread.Sleep(3000);

            OnCameraFocussed(camera);
        }

        protected virtual void OnCameraFocussed(Camera camera)
        {
            if (CameraFocussed != null)
                CameraFocussed(this, new CameraEventArgs() { Camera = camera });
        }
    }
}
