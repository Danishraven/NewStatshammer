namespace NewStatshammer.Client.Models
{
    public class Damage
    {
        public double Hit { get; set; }
        public double Crit { get; set; }
        public Damage()
        {
            Hit = 1;
            Crit = 3;
        }
        public Damage CopyDamage () 
        { 
            return new Damage 
            { 
                Hit = Hit, 
                Crit = Crit 
            }; 
        }
    }
}
