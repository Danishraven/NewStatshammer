namespace NewStatshammer.Client.Models.Interfaces
{
    public interface IDamage
    {
        double Hit { get; set; }
        double Crit { get; set; }
        public abstract IDamage CopyDamage();
    }
}
