

namespace Generator
{

    public class PortalDomainRoleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PortalDomainRole>
    {
        public PortalDomainRoleMapping()
            : this("dbo")
        {
        }

        public PortalDomainRoleMapping(string schema)
        {
            ToTable("PortalDomainRoles", schema);
            HasKey(x => new { x.PortalRoleId, x.PortalDomainId });

            Property(x => x.PortalRoleId).HasColumnName(@"PortalRoleId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PortalDomainId).HasColumnName(@"PortalDomainId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.PortalDomain).WithMany(b => b.PortalDomainRoles).HasForeignKey(c => c.PortalDomainId);
            HasRequired(a => a.PortalRole).WithMany(b => b.PortalDomainRoles).HasForeignKey(c => c.PortalRoleId);
        }
    }

}
