namespace RefactoringGolf.Stack
{
    public class ImageInfo
    {
        public string Path { get; private set; }

        public ImageInfo(string path)
        {
            Path = path;
        }

        public string ImageType
        {
            get
            {
                return Path.Substring(Path.IndexOf(".") + 1);
            }
        }
    }
}