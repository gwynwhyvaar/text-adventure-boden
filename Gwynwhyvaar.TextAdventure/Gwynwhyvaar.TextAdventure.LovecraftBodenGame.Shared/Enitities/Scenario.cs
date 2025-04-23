using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class Scenario : ScenarioNodeBase
    {
        [DataMember] public string CommandText { get; set; }
        [DataMember] public ScenarioMap Map { get; set; }
        [DataMember] public Dictionary<string, ScenarioCommand> Commands { get; set; }
    }
}