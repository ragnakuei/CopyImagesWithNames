public class ImageStore
{
    private int _index;

    private string[] _imageFiles;

    public ImageStore(string sourceImageFolder, string[] extensions)
    {
        var extensionsWithDot = new HashSet<string>(extensions.Select(ext => "." + ext));

        _imageFiles = Directory.GetFiles(sourceImageFolder, "*.*", SearchOption.AllDirectories)
                               .Where(s => extensionsWithDot.Contains(Path.GetExtension(s).ToLower()))
                               .ToArray();

        _index = 0;
    }

    public string GetNextImage()
    {
        if(_index >= _imageFiles.Length)
        {
            _index = 0;
        }

        return _imageFiles[_index++];
    }
}
