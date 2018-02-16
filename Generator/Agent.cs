

namespace Generator
{

    public class Agent
    {
        public int PhoebusContactId { get; set; }
        public int? BrokerManagerId { get; set; }
        public bool? IsFieldBased { get; set; }
        public bool IsAdmin { get; set; }


        public virtual BrokerManager BrokerManager { get; set; }

        public Agent()
        {
            IsAdmin = false;
        }
    }

}
