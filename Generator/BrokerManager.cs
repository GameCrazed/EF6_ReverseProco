

namespace Generator
{

    public class BrokerManager
    {
        public int BrokerManagerId { get; set; }
        public string Name { get; set; }

        public virtual System.Collections.Generic.ICollection<Agent> Agents { get; set; }

        public BrokerManager()
        {
            Agents = new System.Collections.Generic.List<Agent>();
        }
    }

}
