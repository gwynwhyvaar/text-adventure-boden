using System.Runtime.Serialization;

namespace Gwynwhyvaar.TextAdventure.LovecraftBodenGame.Shared
{
    [DataContract]
    public class AdventureGamePlayer : AdventureGameBase
    {
        [DataMember] public string PortraitImagePrefab { get; set; }
        [DataMember] public string CharacterBioGraphy { get; set; }
        [DataMember] public string FullProfileImagePrefab { get; set; }
    }
}