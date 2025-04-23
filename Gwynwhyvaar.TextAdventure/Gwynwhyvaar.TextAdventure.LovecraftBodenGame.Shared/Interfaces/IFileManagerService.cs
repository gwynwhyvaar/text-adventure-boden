using System.Threading.Tasks;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces
{
    internal interface IFileManagerService<TEntity>
    {
        Task<TEntity> LoadAsync(string fileName);
        Task SaveAsync(TEntity file, string fileName);
        Task<TEntity> UpdateAsync(TEntity file, string fileName);
    }
}