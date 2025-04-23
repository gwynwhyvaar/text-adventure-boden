using System;
using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class AdventureGame : AdventureGameBase
    {
        public AdventureGamePlayer CurrentPlayer { get; set; }
        public AdventureGameSetting Setting { get; set; }
        public Dictionary<string, Scenario> Scenarios { get; set; }
        public Scenario LastScenario { get; set; }
    }
}