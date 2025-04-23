using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    public class ScenarioMap : ScenarioNodeBase
    {
        public string BackgroundImagePrefab { get; set; }
        public string BackgroundMusicPrefab { get; set; }
        public string VoicePrefab { get; set; }
        public bool ShowPortrait { get; set; }
        public string ScenarioDescription { get; set; }
        public List<ScenarioMapPrefab> ScenarioMapPrefabs { get; set; }
    }
}