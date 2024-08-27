using NewStatshammer.Client.Models.Interfaces;

namespace NewStatshammer.Client.Models
{
    public class Profile : IProfile
    {
        public bool Active {  get; set; }
        public Guid Id {  get; set; }
        public string? Range {  get; set; }
        public double Attacks {  get; set; }
        public double Strength {  get; set; }
        public IDamage Damage {  get; set; }
        
        public Profile()
        {
            Active = false;
            Id = Guid.NewGuid();
            Range = string.Empty;
            Attacks = 1;
            Strength = 3;
            Damage = new Damage();
        }
        public IProfile CopyProfile()
        {
            return new Profile()
            {
                Active = Active,
                Id = Guid.NewGuid(),
                Range = Range,
                Attacks = Attacks,
                Strength = Strength,
                Damage = Damage.CopyDamage()
            };
        }
    }
}
