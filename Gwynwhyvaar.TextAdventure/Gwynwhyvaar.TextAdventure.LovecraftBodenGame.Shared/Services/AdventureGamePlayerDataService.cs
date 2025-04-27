using System.Collections.Generic;
using System.Linq;

using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGamePlayerDataService : IAdventureGamePlayerDataService
    {
        private readonly FileManager<FileSystemEntity<AdventureGamePlayerData>> _fileManager =
            FileManager<FileSystemEntity<AdventureGamePlayerData>>.Instance;

        public void Save(AdventureGamePlayerData adventureGamePlayerData, string fileName)
        {
            var data = adventureGamePlayerData.AdventureGamePlayerDataToFileSystemEntity();
            _fileManager.Save(data, fileName);
        }

        public AdventureGamePlayerData Load(string fileName)
        {
            var data = _fileManager.Load(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public List<AdventureGamePlayer> LoadAll(string fileName)
        {
            var data = Load(fileName);
            if (data != null && data.AdventureGamePlayers != null) return data.AdventureGamePlayers.Values.ToList();
            return null;
        }
    }
}