

namespace Generator
{

    public class PortalDomain
    {
        public int PortalDomainId { get; set; }
        public string Name { get; set; }

        public virtual System.Collections.Generic.ICollection<PortalDomainRole> PortalDomainRoles { get; set; }

        public PortalDomain()
        {
            PortalDomainRoles = new System.Collections.Generic.List<PortalDomainRole>();
        }
    }

}
