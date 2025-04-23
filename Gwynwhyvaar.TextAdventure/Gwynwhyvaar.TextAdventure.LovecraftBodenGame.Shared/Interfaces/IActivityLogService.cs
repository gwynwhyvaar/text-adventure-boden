using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IActivityLogService
    {
        void Save(AdventureGameActivity adventureGameActivity, string fileName);
        AdventureGameActivity Load(string fileName);
        List<ActivityLog> LoadAllActivities(string fileName);
    }
}