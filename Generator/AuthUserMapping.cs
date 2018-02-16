

namespace Generator
{

    public class AuthUserMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AuthUser>
    {
        public AuthUserMapping()
            : this("dbo")
        {
        }

        public AuthUserMapping(string schema)
        {
            ToTable("Auth_User", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.RealName).HasColumnName(@"RealName").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.Password).HasColumnName(@"Password").HasColumnType("varbinary").IsRequired().HasMaxLength(512);
            Property(x => x.ForcePasswordChange).HasColumnName(@"ForcePasswordChange").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(1);
            Property(x => x.LoginFailureCount).HasColumnName(@"LoginFailureCount").HasColumnType("int").IsOptional();
            Property(x => x.PasswordLastChangeDate).HasColumnName(@"PasswordLastChangeDate").HasColumnType("datetime").IsOptional();
            Property(x => x.LastLoginDate).HasColumnName(@"LastLoginDate").HasColumnType("datetime").IsOptional();
            Property(x => x.FromDate).HasColumnName(@"FromDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ThruDate).HasColumnName(@"ThruDate").HasColumnType("datetime").IsRequired();
            Property(x => x.AuthorisedBy).HasColumnName(@"AuthorisedBy").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.LastChangeDate).HasColumnName(@"LastChangeDate").HasColumnType("datetime").IsRequired();
            Property(x => x.LastChangeBy).HasColumnName(@"LastChangeBy").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(100);
            Property(x => x.Identifier1).HasColumnName(@"Identifier1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Identifier2).HasColumnName(@"Identifier2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Identifier3).HasColumnName(@"Identifier3").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.DontLock).HasColumnName(@"dontLock").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(1);
            Property(x => x.ManagerDivision).HasColumnName(@"ManagerDivision").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
        }
    }

}
