using System;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGameSetting : AdventureGameBase
    {
        [DataMember] public int SoundVolume { get; set; }
        [DataMember] public bool ShowLogs { get; set; }
    }
}