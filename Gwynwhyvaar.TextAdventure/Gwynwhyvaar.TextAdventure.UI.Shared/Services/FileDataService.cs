
using Gwynwhyvaar.TextAdventure.UI.Shared.Entities;
using Gwynwhyvaar.TextAdventure.UI.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.UI.Shared.Services
{
    public class FileDataService : IFileDataService
    {
        public FileDataEntity GetFile(string path)
        {
            return GetFileFromPath(path);
        }

        private static FileDataEntity GetFileFromPath(string path)
        {
            var data = File.ReadAllBytes(path);
            if (data != null)
            {
                var fileName = Path.GetFileName(path);
                FileDataEntity file = new FileDataEntity();
                file.FileName = fileName;
                file.FileData = data;
                file.FilePath = path;
                return file;
            }
            return null;
        }

        public List<FileDataEntity> GetFiles(string path)
        {
            var content = Directory.GetFiles(path);
            if (content != null)
            {
                var files = new List<FileDataEntity>();
                foreach (var item in content)
                {
                    var data = GetFileFromPath(item);
                    files.Add(data);
                }
                return files;
            }
            return null;
        }
    }
}
