using System;
using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class FileSystemEntity<T>
    {
        [DataMember] public Guid FileSystemGuid { get; set; } = Guid.NewGuid();
        [DataMember] public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DataMember] public string Name { get; set; }
        [DataMember] public T Data { get; set; }
    }
}