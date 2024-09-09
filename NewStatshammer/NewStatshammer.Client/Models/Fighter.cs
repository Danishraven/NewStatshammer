using System.ComponentModel;

namespace NewStatshammer.Client.Models
{
    public class Fighter
    {
        public string Name { get; set; }
        public List<Profile> Profiles { get; set; }
        public Guid Id { get; set; }
        public Fighter()
        {
            Name = string.Empty;
            Profiles = new List<Profile>
            {
                new Profile()
            };
            Id = Guid.NewGuid();
        }

        public Fighter CopyFighter()
        {
            List<Profile> profiles = new();
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
            Profile? profile = Profiles.Find(p => p.Id == id);
            if (profile != null) Profiles.Remove(profile);
        }
    }
}
