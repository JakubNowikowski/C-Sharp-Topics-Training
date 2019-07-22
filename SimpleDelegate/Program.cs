using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoEditor();

            var tools = new PhotoTools();

            PhotoEditor.PhotoToolsHandler toolsHandler = tools.SetBrightness;
            toolsHandler += tools.Rotate;
            toolsHandler += tools.Trim;
            toolsHandler += ConvertToBlackAndWhite;

            photoProcessor.Process("photoPath.jpg", toolsHandler);

            Console.ReadKey();
        }

        static void ConvertToBlackAndWhite(Photo photo)
        {
            Console.WriteLine("Convert to black and white");
        }

    }
}
