

namespace Generator
{

    public class LogoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Logo>
    {
        public LogoMapping()
            : this("dbo")
        {
        }

        public LogoMapping(string schema)
        {
            ToTable("LOGO", schema);
            HasKey(x => new { x.Logo030, x.Logo010, x.Logo020 });

            Property(x => x.Logo010).HasColumnName(@"LOGO010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logo020).HasColumnName(@"LOGO020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logo030).HasColumnName(@"LOGO030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Logo040).HasColumnName(@"LOGO040").HasColumnType("datetime").IsRequired();
            Property(x => x.Logo050).HasColumnName(@"LOGO050").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Logodtm).HasColumnName(@"LOGODTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Logo060).HasColumnName(@"LOGO060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logo070).HasColumnName(@"LOGO070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
