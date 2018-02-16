

namespace Generator
{

    public class PortalRole
    {
        public int PortalRoleId { get; set; }
        public string Name { get; set; }

        public virtual System.Collections.Generic.ICollection<PortalDomainRole> PortalDomainRoles { get; set; }

        public PortalRole()
        {
            PortalDomainRoles = new System.Collections.Generic.List<PortalDomainRole>();
        }
    }

}
