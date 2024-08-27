using NewStatshammer.Client.Models.Interfaces;

namespace NewStatshammer.Client.Models
{
    public class Damage : IDamage
    {
        public double Hit { get; set; }
        public double Crit { get; set; }
        public Damage()
        {
            Hit = 1;
            Crit = 3;
        }
        public IDamage CopyDamage () 
        { 
            return new Damage 
            { 
                Hit = Hit, 
                Crit = Crit 
            }; 
        }
    }
}
