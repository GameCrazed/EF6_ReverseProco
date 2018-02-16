

namespace Generator
{

    public class SunaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Suna>
    {
        public SunaMapping()
            : this("dbo")
        {
        }

        public SunaMapping(string schema)
        {
            ToTable("SUNA", schema);
            HasKey(x => x.Suna060);

            Property(x => x.Suna010).HasColumnName(@"SUNA010").HasColumnType("int").IsRequired();
            Property(x => x.Suna020).HasColumnName(@"SUNA020").HasColumnType("int").IsRequired();
            Property(x => x.Suna030).HasColumnName(@"SUNA030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Suna040).HasColumnName(@"SUNA040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Suna050).HasColumnName(@"SUNA050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Suna060).HasColumnName(@"SUNA060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Suna070).HasColumnName(@"SUNA070").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sunadtm).HasColumnName(@"SUNADTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
