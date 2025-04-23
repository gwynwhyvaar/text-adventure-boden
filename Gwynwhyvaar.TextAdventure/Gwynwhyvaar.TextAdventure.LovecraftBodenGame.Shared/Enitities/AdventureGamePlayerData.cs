using System;
using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class AdventureGamePlayerData
    {
        public Dictionary<string, AdventureGamePlayer> AdventureGamePlayers { get; set; }
    }
}