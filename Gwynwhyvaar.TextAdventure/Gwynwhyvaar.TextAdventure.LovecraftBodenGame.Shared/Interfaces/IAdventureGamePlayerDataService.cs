using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IAdventureGamePlayerDataService
    {
        void Save(AdventureGamePlayerData adventureGamePlayerData, string fileName);
        AdventureGamePlayerData Load(string fileName);
        List<AdventureGamePlayer> LoadAll(string fileName);
    }
}