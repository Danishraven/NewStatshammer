using System.ComponentModel;

namespace NewStatshammer.Client.Models.Interfaces
{
    public interface IFighter
    {
        string Name { get; set; }
        List<IProfile> Profiles { get; set; }
        Guid Id { get; set; }
        public abstract Fighter CopyFighter();
        public abstract void AddProfile();
        public abstract void RemoveProfile(Guid id);

    }
}
