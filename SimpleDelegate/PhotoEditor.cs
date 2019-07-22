namespace SimpleDelegate
{
    class PhotoEditor
    {
        public delegate void PhotoToolsHandler(Photo photo);
        public void Process(string path, PhotoToolsHandler toolsHandler)
        {
            var photo = new Photo(path);

            var tools = new PhotoTools();
            toolsHandler(photo);
        }
    }
}
