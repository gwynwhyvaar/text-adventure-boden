using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly FileManager<AdventureGameActivity> _fileManager = FileManager<AdventureGameActivity>.Instance;

        public Task SaveAsync(AdventureGameActivity adventureGameActivity, string fileName)
        {
            return _fileManager.SaveAsync(adventureGameActivity, fileName);
        }

        public Task<AdventureGameActivity> LoadAsync(string fileName)
        {
            return _fileManager.LoadAsync(fileName);
        }
    }
}