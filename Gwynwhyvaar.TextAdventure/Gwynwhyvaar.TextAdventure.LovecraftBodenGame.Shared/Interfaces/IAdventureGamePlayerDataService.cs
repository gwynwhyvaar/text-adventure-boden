using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IAdventureGamePlayerDataService
    {
        Task SaveAsync(AdventureGamePlayerData adventureGamePlayerData, string fileName);
        Task<AdventureGamePlayerData> LoadAsync(string fileName);
        Task<List<AdventureGamePlayer>> LoadAllAsync(string fileName);
    }
}