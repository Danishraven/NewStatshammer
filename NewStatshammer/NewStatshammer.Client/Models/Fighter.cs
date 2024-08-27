using NewStatshammer.Client.Models.Interfaces;
using System.ComponentModel;

namespace NewStatshammer.Client.Models
{
    public class Fighter : IFighter
    {
        public string Name { get; set; }
        public List<IProfile> Profiles { get; set; }
        public Guid Id { get; set; }
        public Fighter()
        {
            Name = string.Empty;
            Profiles = new List<IProfile>
            {
                new Profile()
            };
            Id = Guid.NewGuid();
        }

        public Fighter CopyFighter()
        {
            List<IProfile> profiles = new();
            foreach (var profile in Profiles)
            {
                profiles.Add(profile.CopyProfile());
            }
            return new Fighter()
            {
                Name = Name,
                Profiles = profiles,
                Id = Guid.NewGuid(),
            };
        }

        public void AddProfile()
        {
            Profiles.Add(new Profile());
        }

        public void RemoveProfile(Guid id)
        {
            IProfile? profile = Profiles.Find(p => p.Id == id);
            if (profile != null) Profiles.Remove(profile);
        }
    }
}
