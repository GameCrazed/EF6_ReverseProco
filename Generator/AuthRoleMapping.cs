

namespace Generator
{

    public class AuthRoleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AuthRole>
    {
        public AuthRoleMapping()
            : this("dbo")
        {
        }

        public AuthRoleMapping(string schema)
        {
            ToTable("Auth_Roles", schema);
            HasKey(x => x.RoleId);

            Property(x => x.RoleId).HasColumnName(@"RoleID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Role).HasColumnName(@"Role").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.LastChangeDate).HasColumnName(@"LastChangeDate").HasColumnType("datetime").IsRequired();
            Property(x => x.LastChangeBy).HasColumnName(@"LastChangeBy").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
        }
    }

}
