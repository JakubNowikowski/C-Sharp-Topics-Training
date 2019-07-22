using System;

namespace GenericDelegate
{
    class PhotoEditor
    {
        public void Process(string path, Action<Photo> toolsHandler)
        {
            var photo = new Photo(path);

            var tools = new PhotoTools();
            toolsHandler(photo);
        }
    }
}
