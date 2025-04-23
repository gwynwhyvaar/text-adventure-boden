using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGamePlayerDataService : IAdventureGamePlayerDataService
    {
        private readonly FileManager<FileSystemEntity<AdventureGamePlayerData>> _fileManager =
            FileManager<FileSystemEntity<AdventureGamePlayerData>>.Instance;

        public async Task SaveAsync(AdventureGamePlayerData adventureGamePlayerData, string fileName)
        {
            var data = adventureGamePlayerData.AdventureGamePlayerDataToFileSystemEntity();
            await _fileManager.SaveAsync(data, fileName);
        }

        public async Task<AdventureGamePlayerData> LoadAsync(string fileName)
        {
            var data = await _fileManager.LoadAsync(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public async Task<List<AdventureGamePlayer>> LoadAllAsync(string fileName)
        {
            var data = await LoadAsync(fileName);
            if (data != null && data.AdventureGamePlayers != null) return data.AdventureGamePlayers.Values.ToList();
            return null;
        }
    }
}