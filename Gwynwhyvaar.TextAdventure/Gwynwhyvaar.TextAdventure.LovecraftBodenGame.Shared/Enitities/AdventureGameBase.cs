using System;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGameBase
    {
        [DataMember] public string Name { get; set; }
        [DataMember] public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DataMember] public string AdventureGuid { get; set; } = Guid.NewGuid().ToString("X");
    }
}