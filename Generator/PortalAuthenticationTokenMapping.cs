

namespace Generator
{

    public class PortalAuthenticationTokenMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PortalAuthenticationToken>
    {
        public PortalAuthenticationTokenMapping()
            : this("dbo")
        {
        }

        public PortalAuthenticationTokenMapping(string schema)
        {
            ToTable("PortalAuthenticationTokens", schema);
            HasKey(x => x.Username);

            Property(x => x.Username).HasColumnName(@"Username").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Token).HasColumnName(@"Token").HasColumnType("uniqueidentifier").IsRequired();
        }
    }

}
