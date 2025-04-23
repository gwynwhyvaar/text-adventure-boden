using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    public class ScenarioNodeBase
    {
        public string AddressGuid { get; set; } = Guid.NewGuid().ToString("X");
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Name { get; set; }
    }
}