using System.Threading.Tasks;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IAdventureGameService
    {
        Task SaveAsync(AdventureGame adventureGame, string fileName);
        Task<AdventureGame> LoadAsync(string fileName);
        Task<AdventureGame> UpdateAsync(AdventureGame adventureGame, string fileName);
    }
}