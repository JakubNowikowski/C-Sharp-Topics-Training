using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var camera = new Camera() { Name = "Camera 1" };
            var cameraFoccusing = new CameraFocussingOperations(); //publisher
            var photoService = new PhotoService(); //subscriber
            var videoService = new VideoService(); //subscriber

            cameraFoccusing.CameraFocussed += photoService.OnCameraFocussed;
            cameraFoccusing.CameraFocussed += videoService.OnCameraFocussed;

            cameraFoccusing.Focus(camera);

            Console.ReadKey();
        }
    }
}
