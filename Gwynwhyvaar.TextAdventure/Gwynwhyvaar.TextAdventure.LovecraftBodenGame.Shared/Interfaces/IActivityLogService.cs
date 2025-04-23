using System.Threading.Tasks;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IActivityLogService
    {
        Task SaveAsync(AdventureGameActivity adventureGameActivity, string fileName);
        Task<AdventureGameActivity> LoadAsync(string fileName);
    }
}