using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGameActivity : AdventureGameBase
    {
        [DataMember] public Dictionary<string, ActivityLog> ActivityLogs { get; set; }
    }
}