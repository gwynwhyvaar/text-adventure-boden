namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    public class ScenarioCommand : ScenarioNodeBase
    {
        public string CommandText { get; set; }
        public string ScenarioGuid { get; set; }
        public string NavigationHotKey { get; set; }
        public int CommandOrder { get; set; }
    }
}