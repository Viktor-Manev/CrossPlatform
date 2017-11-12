using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Android.Content.Res;
using System.IO;
using System.Threading.Tasks;
using CrossPlatform.Files;

[assembly: Dependency(typeof(CrossPlatform.FileSystemDroid))]
namespace CrossPlatform
{

    class FileSystemDroid : IFileSystemCommands
    {
        public bool FileExists(string filename)
        {
            return File.Exists(CreatePathToFile(filename));
        }

        public async Task<string> ReadTextAsync(string filename)
        {
            var path = CreatePathToFile(filename);
            using (StreamReader sr = File.OpenText(path))
            {
                return await sr.ReadToEndAsync();
            }
        }

        string CreatePathToFile(string filename)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(docsPath, filename);
        }

        public string ReadText(string fileName)
        {
            return System.IO.File.ReadAllText(CreatePathToFile(fileName));
        }

        public string[] ReadAllLines(string fileName)
        {
            return System.IO.File.ReadAllLines(CreatePathToFile(fileName));
        }

        public void WriteText(string filename, string content)
        {
            var path = CreatePathToFile(filename);
            System.IO.File.WriteAllText(path, content);
        }

        public async Task WriteTextAsync(string filename, string text)
        {
            var path = CreatePathToFile(filename);
            using (StreamWriter sw = File.CreateText(path))
            {
                await sw.WriteAsync(text);
            }
        }

        public void DeleteFile(string filename)
        {
            System.IO.File.Delete(CreatePathToFile(filename));
        }

        public string ReadAsset()
        {
            return string.Empty;
        }
    }

}




