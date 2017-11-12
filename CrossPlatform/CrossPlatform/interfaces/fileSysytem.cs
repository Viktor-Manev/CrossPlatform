using System.IO;
using System.Threading.Tasks;

namespace CrossPlatform.Files
{
    public interface IFileSystemCommands
    {
        bool FileExists(string filename);

        Task WriteTextAsync(string filename, string text);

        void WriteText(string filename, string content);

        Task<string> ReadTextAsync(string filename);

        string ReadText(string fileName);

        string[] ReadAllLines(string fileName);

        void DeleteFile(string filename);

        string ReadAsset();

        void SaveStream(string path, Stream stream);

        string GetFilePath(string name);
 
    }
}