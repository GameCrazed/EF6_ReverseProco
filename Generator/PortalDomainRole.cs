

namespace Generator
{

    public class PortalDomainRole
    {
        public int PortalRoleId { get; set; }
        public int PortalDomainId { get; set; }


        public virtual PortalDomain PortalDomain { get; set; }

        public virtual PortalRole PortalRole { get; set; }
    }

}
