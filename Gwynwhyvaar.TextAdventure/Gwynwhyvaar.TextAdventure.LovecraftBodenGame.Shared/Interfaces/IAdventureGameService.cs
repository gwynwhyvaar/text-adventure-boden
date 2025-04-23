namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IAdventureGameService
    {
        void Save(AdventureGame adventureGame, string fileName);
        AdventureGame Load(string fileName);
        AdventureGame Update(AdventureGame adventureGame, string fileName);
    }
}