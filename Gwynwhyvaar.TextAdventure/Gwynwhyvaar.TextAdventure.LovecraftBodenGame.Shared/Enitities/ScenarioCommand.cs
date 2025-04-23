using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class ScenarioCommand : ScenarioNodeBase
    {
        [DataMember] public string CommandText { get; set; }
        [DataMember] public string ScenarioGuid { get; set; }
        [DataMember] public string NavigationHotKey { get; set; }
        [DataMember] public int CommandOrder { get; set; }
    }
}