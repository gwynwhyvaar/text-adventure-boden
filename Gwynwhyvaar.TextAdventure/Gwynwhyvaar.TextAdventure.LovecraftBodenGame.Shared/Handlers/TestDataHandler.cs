namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Handlers
{
    public class TestDataHandler
    {
        public AdventureGame GetPreloadedAdventures()
        {
            var game = new AdventureGame();
            game.Scenarios = new System.Collections.Generic.Dictionary<string, Scenario>();
            // the player profile
            var adventureGamePlayer = new AdventureGamePlayer();
            adventureGamePlayer.CharacterBioGraphy =
                "An Antiquarian. Your life is about books -lost and ancient books. ";
            adventureGamePlayer.Name = "The Antiquarian";
            adventureGamePlayer.PortraitImagePrefab = "Images/Profile/DemoPlayer/text_adventure_profile_picture_01";
            adventureGamePlayer.FullProfileImagePrefab =
                "Images/Profile/DemoPlayer/text_adventure_full_profile_picture_01";
            // add the player
            game.CurrentPlayer = adventureGamePlayer;

            // scenario 1
            var scenario1 = new Scenario();
            scenario1.Map = new ScenarioMap();
            scenario1.Map.Name = "Map_01";
            scenario1.Map.BackgroundImagePrefab = "Images/BackgroundImages/map_01_demo_image_background";
            scenario1.Map.VoicePrefab = "map_01_demo_audio";
            scenario1.Map.BackgroundMusicPrefab = "map_01_demo_audio_background";
            scenario1.Map.ShowPortrait = true;
            scenario1.Map.ScenarioDescription = "You are in front of your apartment. it's freezing outside..";
            scenario1.Name = "Apartment Door";
            scenario1.CommandText = "What will you do?";
            scenario1.Commands = new System.Collections.Generic.Dictionary<string, ScenarioCommand>();

            // scenario 2
            var scenario2 = new Scenario();
            scenario2.Map = new ScenarioMap();
            scenario2.Map.Name = "Map_02";
            scenario2.Map.BackgroundImagePrefab = "Images/BackgroundImages/map_02_demo_image_background";
            scenario2.Map.VoicePrefab = "map_02_demo_audio";
            scenario2.Map.BackgroundMusicPrefab = "map_02_demo_audio_background";
            scenario2.Map.ShowPortrait = true;
            scenario2.Map.ScenarioDescription =
                "You went down the stairs and can see some benches covered in snow. You feel so cold, your fingers begin to go numb..";
            scenario2.Name = "Below the Apartment Door";
            scenario2.CommandText = "What else will you do?";
            scenario2.Commands = new System.Collections.Generic.Dictionary<string, ScenarioCommand>();

            // scenario 3
            var scenario3 = new Scenario();
            scenario3.Map = new ScenarioMap();
            scenario3.Map.Name = "Map_03";
            scenario3.Map.BackgroundImagePrefab = "Images/BackgroundImages/map_03_demo_image_background";
            scenario3.Map.VoicePrefab = "map_03_demo_audio";
            scenario3.Map.BackgroundMusicPrefab = "map_03_demo_audio_background";
            scenario3.Map.ShowPortrait = true;
            scenario3.Map.ScenarioDescription =
                "You are back indoors. You can see a pair of boots and warm clothes on the rack.";
            scenario3.Name = "Indoors";
            scenario3.CommandText = "What will you do?";
            scenario3.Commands = new System.Collections.Generic.Dictionary<string, ScenarioCommand>();

            // create commands
            var cmd1 = new ScenarioCommand();
            cmd1.Name = "command_01";
            cmd1.ScenarioGuid = scenario2.AddressGuid;
            cmd1.CommandOrder = 1;
            cmd1.CommandText = "Go down the stairs...";
            cmd1.NavigationHotKey = "1";

            scenario1.Commands[cmd1.NavigationHotKey] = cmd1;

            var cmd2 = new ScenarioCommand();
            cmd2.Name = "command_02";
            cmd2.ScenarioGuid = scenario2.AddressGuid;
            cmd2.CommandOrder = 2;
            cmd2.CommandText = "Go back indoors";
            cmd2.NavigationHotKey = "2";

            scenario1.Commands[cmd2.NavigationHotKey] = cmd2;

            // commands #2 for Map_02 ...
            var cmd3 = new ScenarioCommand();
            cmd3.Name = "command_03";
            cmd3.ScenarioGuid = scenario1.AddressGuid;
            cmd3.CommandOrder = 1;
            cmd3.CommandText = "It's freezing outside; go back indoors...";
            cmd3.NavigationHotKey = "1";

            scenario2.Commands[cmd3.NavigationHotKey] = cmd3;

            // add scenario 01 to the dictionary
            game.Scenarios[scenario1.AddressGuid] = scenario1;
            game.Scenarios[scenario2.AddressGuid] = scenario2;
            game.Scenarios[scenario3.AddressGuid] = scenario3;

            // add the default scenerio 
            game.LastScenario = scenario1;

            // add the game settings ..
            game.Setting = new AdventureGameSetting();
            game.Setting.SoundVolume = 1;
            game.Setting.ShowLogs = true;

            return game;
        }
    }
}
