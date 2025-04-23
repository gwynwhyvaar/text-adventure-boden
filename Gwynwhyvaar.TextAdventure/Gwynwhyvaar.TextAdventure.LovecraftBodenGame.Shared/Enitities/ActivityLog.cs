using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class ActivityLog : AdventureGameBase
    {
        public string AdventureGameGuid { get; set; }
        public string ScenarioGuid { get; set; }
        public string ScenarioDescription { get; set; }
        public string ScenarioName { get; set; }
    }
}