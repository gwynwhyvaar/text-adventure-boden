using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGameService : IAdventureGameService
    {
        private readonly FileManager<FileSystemEntity<AdventureGame>> _fileManager =
            FileManager<FileSystemEntity<AdventureGame>>.Instance;

        public void Save(AdventureGame adventureGame, string fileName)
        {
            var file = adventureGame.AdventureGameToFileSystemEntity();
            _fileManager.Save(file, fileName);
        }

        public AdventureGame Load(string fileName)
        {
            var data = _fileManager.Load(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public AdventureGame Update(AdventureGame adventureGame, string fileName)
        {
            var input = _fileManager.Load(fileName);
            var data = adventureGame.CopyAdventureGameToFileSystemEntity(input);
            var result = _fileManager.Update(data, fileName);
            if (result != null) return result.Data;
            return null;
        }
    }
}