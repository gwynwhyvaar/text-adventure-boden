using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    public class AdventureGameBase
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string AdventureGuid { get; set; } = Guid.NewGuid().ToString("X");
    }
}