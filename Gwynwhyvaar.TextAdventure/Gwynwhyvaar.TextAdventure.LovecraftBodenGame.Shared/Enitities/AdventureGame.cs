using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGame : AdventureGameBase
    {
        [DataMember] public AdventureGamePlayer CurrentPlayer { get; set; }
        [DataMember] public AdventureGameSetting Setting { get; set; }
        [DataMember] public Dictionary<string, Scenario> Scenarios { get; set; }
        [DataMember] public Scenario LastScenario { get; set; }
    }
}