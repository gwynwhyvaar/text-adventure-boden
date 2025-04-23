using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly FileManager<FileSystemEntity<AdventureGameActivity>> _fileManager =
            FileManager<FileSystemEntity<AdventureGameActivity>>.Instance;

        public async Task SaveAsync(AdventureGameActivity adventureGameActivity, string fileName)
        {
            var data = adventureGameActivity.AdventureGameActivityToFileSystemEntity();
            await _fileManager.SaveAsync(data, fileName);
        }

        public async Task<AdventureGameActivity> LoadAsync(string fileName)
        {
            var data = await _fileManager.LoadAsync(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public async Task<List<ActivityLog>> LoadAllActivitiesAsync(string fileName)
        {
            var data = await LoadAsync(fileName);
            if (data != null && data.ActivityLogs != null) return data.ActivityLogs.Values.ToList();

            return null;
        }
    }
}