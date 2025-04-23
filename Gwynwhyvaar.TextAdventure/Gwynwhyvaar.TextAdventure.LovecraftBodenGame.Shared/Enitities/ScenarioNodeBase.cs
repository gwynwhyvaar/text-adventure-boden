using System;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class ScenarioNodeBase
    {
        [DataMember] public string AddressGuid { get; set; } = Guid.NewGuid().ToString("X");
        [DataMember] public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DataMember] public string? Name { get; set; }
    }
}