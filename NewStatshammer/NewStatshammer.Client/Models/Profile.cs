namespace NewStatshammer.Client.Models
{
    public class Profile
    {
        public bool Active {  get; set; }
        public Guid Id {  get; set; }
        public string? Range {  get; set; }
        public double Attacks {  get; set; }
        public double Strength {  get; set; }
        public Damage Damage {  get; set; }
        
        public Profile()
        {
            Active = false;
            Id = Guid.NewGuid();
            Range = string.Empty;
            Attacks = 1;
            Strength = 3;
            Damage = new Damage();
        }
        public Profile CopyProfile()
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
