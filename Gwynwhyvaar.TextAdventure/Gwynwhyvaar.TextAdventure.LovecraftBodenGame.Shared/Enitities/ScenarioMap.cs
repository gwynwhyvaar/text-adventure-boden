using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class ScenarioMap : ScenarioNodeBase
    {
        [DataMember] public string BackgroundImagePrefab { get; set; }
        [DataMember] public string BackgroundMusicPrefab { get; set; }
        [DataMember] public string VoicePrefab { get; set; }
        [DataMember] public bool ShowPortrait { get; set; }
        [DataMember] public string ScenarioDescription { get; set; }
        [DataMember] public List<ScenarioMapPrefab> ScenarioMapPrefabs { get; set; }
    }
}