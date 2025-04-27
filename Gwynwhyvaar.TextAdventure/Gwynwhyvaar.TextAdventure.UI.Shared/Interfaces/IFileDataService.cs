using Gwynwhyvaar.TextAdventure.UI.Shared.Entities;

namespace Gwynwhyvaar.TextAdventure.UI.Shared.Interfaces
{
    public interface IFileDataService
    {
        FileDataEntity GetFile(string path);
        List<FileDataEntity> GetFiles(string path);
    }
}
