using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class AdventureGameSetting : AdventureGameBase
    {
        public int SoundVolume { get; set; }
        public bool ShowLogs { get; set; }
    }
}