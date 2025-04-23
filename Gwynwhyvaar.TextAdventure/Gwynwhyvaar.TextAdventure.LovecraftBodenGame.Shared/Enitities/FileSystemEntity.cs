using System;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [Serializable]
    internal class FileSystemEntity<T>
    {
        public Guid FileSystemGuid { get; set; }=Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public T Data { get; set; }
    }
}