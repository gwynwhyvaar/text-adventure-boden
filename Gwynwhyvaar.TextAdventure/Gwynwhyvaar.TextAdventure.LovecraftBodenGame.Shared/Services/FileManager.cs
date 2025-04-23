using System.IO;
using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    public class FileManager<TEntity> : IFileManagerService<TEntity>
    {
        public async Task<TEntity> LoadAsync(TEntity file, string fileName)
        {
            var content = await File.ReadAllTextAsync(fileName);
            if (content != null) return System.Text.Json.JsonSerializer.Deserialize<TEntity>(content);
            return default;
        }

        public async Task SaveAsync(TEntity file, string fileName)
        {
            var content = System.Text.Json.JsonSerializer.Serialize(file);
            await File.WriteAllTextAsync(fileName, content);
        }

        public async Task<TEntity> UpdateAsync(TEntity file, string fileName)
        {
            var data = await LoadAsync(file, fileName);
            data = file;
            await SaveAsync(data, fileName);
            return file;
        }
    }
}