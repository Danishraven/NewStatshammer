namespace NewStatshammer.Client.Models
{
    public class Dice
    {
        public List<int> Faces;
        public int Index = 0;
        public Dice(int numberOfFaces)
        {
            Faces = new List<int>();
            for (int i = 0; i < numberOfFaces; i++) { Faces.Add(i + 1); }
        }
    }
}
