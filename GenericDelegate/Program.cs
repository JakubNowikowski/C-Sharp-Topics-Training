using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoEditor();

            var tools = new PhotoTools();

            Action<Photo> toolsHandler = tools.SetBrightness;
            toolsHandler += tools.Rotate;
            toolsHandler += tools.Trim;

            photoProcessor.Process("photoPath.jpg", toolsHandler);

            Console.ReadKey();
        }
    }
}
