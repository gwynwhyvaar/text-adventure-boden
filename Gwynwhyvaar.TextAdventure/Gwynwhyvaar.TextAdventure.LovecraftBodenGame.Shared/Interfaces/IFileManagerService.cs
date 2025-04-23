namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IFileManagerService<TEntity>
    {
        TEntity Load(string fileName);
        void Save(TEntity file, string fileName);
        TEntity Update(TEntity file, string fileName);
    }
}