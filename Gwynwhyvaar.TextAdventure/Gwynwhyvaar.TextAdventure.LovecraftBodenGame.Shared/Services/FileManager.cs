using System.IO;
using System.Threading.Tasks;
using Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Interfaces;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared.Services
{
    internal class FileManager<TEntity> : IFileManagerService<TEntity>
    {
        private static FileManager<TEntity> _instance;
        public static FileManager<TEntity> Instance => _instance ??= new FileManager<TEntity>();

        public async Task<TEntity> LoadAsync(string fileName)
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
            // todo: fix this ...
            var data = await LoadAsync(fileName);
            data = file;
            await SaveAsync(data, fileName);
            return file;
        }
    }
}