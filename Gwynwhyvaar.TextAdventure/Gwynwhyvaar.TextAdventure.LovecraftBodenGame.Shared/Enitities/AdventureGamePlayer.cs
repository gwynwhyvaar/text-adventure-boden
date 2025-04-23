using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class AdventureGamePlayer: AdventureGameBase
    {
        public string PortraitImagePrefab { get; set; }
        public string CharacterBioGraphy { get; set; }
        public string FullProfileImagePrefab { get; set; }
    }
}