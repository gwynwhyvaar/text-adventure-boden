﻿using System.Collections.Generic;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    public class AdventureGame : AdventureGameBase
    {
        public AdventureGamePlayer CurrentPlayer { get; set; }
        public AdventureGameSetting Setting { get; set; }
        public List<Scenario> Scenarios { get; set; }
    }
}