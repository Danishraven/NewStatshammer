using System.Collections.ObjectModel;

namespace NewStatshammer.Client.Models.Interfaces
{
    public interface IStateContainer
    {
        public Dictionary<int, object> ObjectTunnel { get; set; }
    }
}
