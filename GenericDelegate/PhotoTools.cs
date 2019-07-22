using System;

namespace GenericDelegate
{
    class PhotoTools
    {

        public void SetBrightness(Photo photo)
        {
            Console.WriteLine("Set brightness");
        }

        public void Rotate(Photo photo)
        {
            Console.WriteLine("Rotate photo");
        }

        public void Trim(Photo photo)
        {
            Console.WriteLine("Trim photo");
        }
    }
}
