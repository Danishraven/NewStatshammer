using NewStatshammer.Client.Models.Interfaces;

namespace NewStatshammer.Client.Models
{
    public class StateContainer
    {
        public Dictionary<int, object> ObjectTunnel = new();
    }
}
