var sourceImageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

var extensions = new[] { "jpg" };

var outputImageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OutputImages");

if (Directory.Exists(outputImageFolder) == false)
{
    Directory.CreateDirectory(outputImageFolder);
}

var outputFiles = new[]
                  {
                      "01.jpg",
                      "02.jpg",
                      "03.jpg",
                      "04.jpg",
                      "05.jpg",
                      "06.jpg",
                      "07.jpg",
                      "08.jpg",
                      "09.jpg",
                      "10.jpg",
                      "11.jpg",
                      "12.jpg",
                      "13.jpg",
                      "14.jpg",
                      "15.jpg",
                      "16.jpg",
                      "17.jpg",
                      "18.jpg",
                      "19.jpg",
                  };

var imageStore = new ImageStore(sourceImageFolder, extensions);

foreach (var output in outputFiles)
{
    var outputImage = Path.Combine(outputImageFolder, output);
    if (File.Exists(outputImage))
    {
        continue;
    }

    File.Copy(imageStore.GetNextImage(), outputImage);
}
