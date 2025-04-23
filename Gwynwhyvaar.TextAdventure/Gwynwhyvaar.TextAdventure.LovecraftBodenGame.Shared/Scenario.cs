using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    public class Scenario : ScenarioNodeBase
    {
        public string CommandText { get; set; }
        public ScenarioMap Map { get; set; }
        public Dictionary<string, ScenarioCommand> Commands { get; set; }
    }
}