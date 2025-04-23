using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGameService : IAdventureGameService
    {
        private readonly FileManager<FileSystemEntity<AdventureGame>> _fileManager =
            FileManager<FileSystemEntity<AdventureGame>>.Instance;

        public async Task SaveAsync(AdventureGame adventureGame, string fileName)
        {
            var file = adventureGame.AdventureGameToFileSystemEntity();
            await _fileManager.SaveAsync(file, fileName);
        }

        public async Task<AdventureGame> LoadAsync(string fileName)
        {
            var data = await _fileManager.LoadAsync(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public async Task<AdventureGame> UpdateAsync(AdventureGame adventureGame, string fileName)
        {
            var input = await _fileManager.LoadAsync(fileName);
            var data = adventureGame.CopyAdventureGameToFileSystemEntity(input);
            var result = await _fileManager.UpdateAsync(data, fileName);
            if (result!= null) return result.Data;
            return null;
        }
    }
}