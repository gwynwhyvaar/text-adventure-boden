using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class AdventureGameService : IAdventureGameService
    {
        private readonly FileManager<AdventureGame> _fileManager = FileManager<AdventureGame>.Instance;

        public async Task SaveAsync(AdventureGame adventureGame, string fileName)
        {
            await _fileManager.SaveAsync(adventureGame, fileName);
        }

        public Task<AdventureGame> LoadAsync(string fileName)
        {
            return _fileManager.LoadAsync(fileName);
        }

        public Task<AdventureGame> UpdateAsync(AdventureGame adventureGame, string fileName)
        {
            return _fileManager.UpdateAsync(adventureGame, fileName);
        }
    }
}