using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGamePlayerDataService : IAdventureGamePlayerDataService
    {
        private readonly FileManager<AdventureGamePlayerData> _fileManager =
            FileManager<AdventureGamePlayerData>.Instance;

        public Task SaveAsync(AdventureGamePlayerData adventureGamePlayerData, string fileName)
        {
            return _fileManager.SaveAsync(adventureGamePlayerData, fileName);
        }

        public Task<AdventureGamePlayerData> LoadAsync(string fileName)
        {
            return _fileManager.LoadAsync(fileName);
        }
    }
}