namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Extensions
{
    internal static class FileSystemEntityExtension
    {
        public static FileSystemEntity<AdventureGame> AdventureGameToFileSystemEntity(this AdventureGame adventureGame)
        {
            return new FileSystemEntity<AdventureGame>
            {
                Data = adventureGame, Name = adventureGame.Name
            };
        }
        public static FileSystemEntity<AdventureGame> CopyAdventureGameToFileSystemEntity(this AdventureGame adventureGame, FileSystemEntity<AdventureGame> input)
        {
           input.Data = adventureGame;
           input.Name = adventureGame.Name;
           return input;
        }
        public static FileSystemEntity<AdventureGameActivity> AdventureGameActivityToFileSystemEntity(this AdventureGameActivity adventureGameActivity)
        {
            return new FileSystemEntity<AdventureGameActivity>
            {
                Data = adventureGameActivity, Name = adventureGameActivity.Name
            };
        }
        public static FileSystemEntity<AdventureGamePlayerData> AdventureGamePlayerDataToFileSystemEntity(this AdventureGamePlayerData adventureGamePlayerData)
        {
            return new FileSystemEntity<AdventureGamePlayerData>
            {
                Data = adventureGamePlayerData
            };
        }
    }
}