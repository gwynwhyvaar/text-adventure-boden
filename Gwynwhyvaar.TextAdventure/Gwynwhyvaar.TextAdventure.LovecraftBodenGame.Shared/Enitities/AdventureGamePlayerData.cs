using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGamePlayerData
    {
        [DataMember] public Dictionary<string, AdventureGamePlayer> AdventureGamePlayers { get; set; }
    }
}