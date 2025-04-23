using System.Threading.Tasks;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    public interface IFileManagerService<TEntity>
    {
        Task<TEntity> LoadAsync(TEntity file, string fileName);
        Task SaveAsync(TEntity file, string fileName);
        Task<TEntity> UpdateAsync(TEntity file, string fileName);
    }
}