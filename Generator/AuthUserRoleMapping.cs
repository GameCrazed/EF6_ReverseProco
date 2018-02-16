

namespace Generator
{

    public class AuthUserRoleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AuthUserRole>
    {
        public AuthUserRoleMapping()
            : this("dbo")
        {
        }

        public AuthUserRoleMapping(string schema)
        {
            ToTable("Auth_UserRoles", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FkRolesRoleId).HasColumnName(@"FKRoles_RoleID").HasColumnType("int").IsRequired();
            Property(x => x.FkUserUserId).HasColumnName(@"FKUser_UserID").HasColumnType("int").IsRequired();
            Property(x => x.FromDate).HasColumnName(@"FromDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ThruDate).HasColumnName(@"ThruDate").HasColumnType("datetime").IsRequired();
            Property(x => x.AuthorisedBy).HasColumnName(@"AuthorisedBy").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.LastChangeDate).HasColumnName(@"LastChangeDate").HasColumnType("datetime").IsRequired();
            Property(x => x.LastChangeBy).HasColumnName(@"LastChangeBy").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.InternalReference).HasColumnName(@"InternalReference").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExternalReference1).HasColumnName(@"ExternalReference1").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExternalReference2).HasColumnName(@"ExternalReference2").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }

}
