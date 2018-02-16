

namespace Generator
{

    public class PortalDomainMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PortalDomain>
    {
        public PortalDomainMapping()
            : this("dbo")
        {
        }

        public PortalDomainMapping(string schema)
        {
            ToTable("PortalDomains", schema);
            HasKey(x => x.PortalDomainId);

            Property(x => x.PortalDomainId).HasColumnName(@"PortalDomainId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
        }
    }

}
