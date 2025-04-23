using System.Collections.Generic;
using System.Linq;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly FileManager<FileSystemEntity<AdventureGameActivity>> _fileManager =
            FileManager<FileSystemEntity<AdventureGameActivity>>.Instance;

        public void Save(AdventureGameActivity adventureGameActivity, string fileName)
        {
            var data = adventureGameActivity.AdventureGameActivityToFileSystemEntity();
            _fileManager.Save(data, fileName);
        }

        public AdventureGameActivity Load(string fileName)
        {
            var data = _fileManager.Load(fileName);
            if (data != null) return data.Data;
            return null;
        }

        public List<ActivityLog> LoadAllActivities(string fileName)
        {
            var data = Load(fileName);
            if (data != null && data.ActivityLogs != null) return data.ActivityLogs.Values.ToList();
            return null;
        }
    }
}