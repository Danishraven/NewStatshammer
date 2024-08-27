namespace NewStatshammer.Client.Models.Interfaces
{
    public interface IProfile
    {
        bool Active { get; set; }
        Guid Id { get; set; }
        string? Range { get; set; }
        double Attacks { get; set; }
        double Strength { get; set; }
        IDamage Damage { get; set; }
        public abstract IProfile CopyProfile();
    }
}
