

namespace Generator
{

    public class EaStatusMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaStatus>
    {
        public EaStatusMapping()
            : this("dbo")
        {
        }

        public EaStatusMapping(string schema)
        {
            ToTable("ea_status", schema);
            HasKey(x => x.StatusId);

            Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationID").HasColumnType("int").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.StatusCode).HasColumnName(@"StatusCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.DateModified).HasColumnName(@"DateModified").HasColumnType("datetime").IsOptional();
            Property(x => x.IpAddress).HasColumnName(@"IPAddress").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
        }
    }

}
