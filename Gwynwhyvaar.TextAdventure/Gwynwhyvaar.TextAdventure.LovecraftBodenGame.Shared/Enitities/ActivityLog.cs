using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class ActivityLog : AdventureGameBase
    {
        [DataMember] public string AdventureGameGuid { get; set; }
        [DataMember] public string ScenarioGuid { get; set; }
        [DataMember] public string ScenarioDescription { get; set; }
        [DataMember] public string ScenarioName { get; set; }
    }
}