using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace ToDoList.Utils;

public class ImageHelper
{
    public static Bitmap LoadImage(Uri uriPath)
    {
        return new Bitmap(AssetLoader.Open(uriPath));
        // using var httpClient = new HttpClient();
        // try
        // {
        //     var response = await httpClient.GetAsync(uriPath);
        //     response.EnsureSuccessStatusCode();
        //     var data = await response.Content.ReadAsByteArrayAsync();
        //     return new Bitmap(new MemoryStream(data));
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e);
        //     return null;
        // }
    }
}