using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGamePlayerData
    {
        public AdventureGamePlayerData()
        {
            if (this.AdventureGamePlayers == null)
            {
                this.AdventureGamePlayers = new Dictionary<string, AdventureGamePlayer>();
            }
        }

        [DataMember] public Dictionary<string, AdventureGamePlayer> AdventureGamePlayers { get; set; }
    }
}