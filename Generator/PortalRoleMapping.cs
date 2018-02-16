

namespace Generator
{

    public class PortalRoleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PortalRole>
    {
        public PortalRoleMapping()
            : this("dbo")
        {
        }

        public PortalRoleMapping(string schema)
        {
            ToTable("PortalRoles", schema);
            HasKey(x => x.PortalRoleId);

            Property(x => x.PortalRoleId).HasColumnName(@"PortalRoleId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }

}
